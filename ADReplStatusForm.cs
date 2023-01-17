using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using Microsoft.Win32;
using BrightIdeasSoftware;

namespace ADReplStatus
{
    public partial class ADReplStatusForm : Form
    {
        public static bool gLoggingEnabled = false;

        public static bool gDarkMode = false;

        public static bool gErrorsOnly = false;

        public static string gLogfileName = string.Empty;

        public static string gForestName = string.Empty;

        public static string gUsername = string.Empty;

        public static string gPassword = string.Empty;        

        public static List<ADREPLDC> gDCs = new List<ADREPLDC>();
        
        public ADReplStatusForm()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ProgressPercentLabel.Visible = true;

            ProgressPercentLabel.Text = "0%";

            ActiveForm.Text = $"AD Replication Status Tool - {gForestName}";

            gDCs.Clear();
            

            foreach (var control in this.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled = false;
                }
            }

            backgroundWorker1.RunWorkerAsync();
        }

        private void ADReplStatusForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(RefreshButton, "Refresh Replication Status");

            toolTip1.SetToolTip(EnableLoggingButton, "Enable Logging");

            toolTip1.SetToolTip(SetForestButton, "Manually Set Forest");

            toolTip1.SetToolTip(AlternateCredsButton, "Provide Alternate Credentials");

            toolTip1.SetToolTip(ErrorsOnlyButton, "Show Errors Only");

            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\ADREPLSTATUS", false))
                {
                    if (key != null)
                    {
                        gForestName = key.GetValue("ForestName", string.Empty).ToString();
                        
                        gDarkMode = Convert.ToBoolean(key.GetValue("DarkMode", false));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while trying to read app settings from the registry!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (gDarkMode == true)
            {
                SetDarkMode();                
            }
            else
            {
                SetLightMode();
            }


            if (string.IsNullOrEmpty(gForestName))
            {
                try
                {
                    using (Forest forest = Forest.GetCurrentForest())
                    {
                        gForestName = forest.Name;
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to detect AD forest. You will need to manually enter the AD forest you wish to scan using the 'Manually Set Forest' button.\nThis happens on non-domain joined computers as well as hybrid or Azure AD domain-joined machines.", "Forest Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }            
        }

        private void ADReplStatusForm_Resize(object sender, EventArgs e)
        {            
            treeListView1.Top = 68;

            treeListView1.Left = 12;

            if (ActiveForm != null)
            {
                treeListView1.Width = ActiveForm.Width - 40;

                treeListView1.Height = ActiveForm.Height - 119;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Forest forest = null;

            try
            {
                DirectoryContext ForestContext = null;

                if (gUsername.Length > 0)
                {
                    backgroundWorker1.ReportProgress(0, $"Attempting to connect to forest {gForestName} with alternate user {gUsername}.");

                    ForestContext = new DirectoryContext(DirectoryContextType.Forest, gForestName, gUsername, gPassword);
                }
                else 
                {
                    backgroundWorker1.ReportProgress(0, $"Attempting to connect to forest {gForestName} as currently logged-on user.");

                    ForestContext = new DirectoryContext(DirectoryContextType.Forest, gForestName);
                }

                forest = Forest.GetForest(ForestContext);               
            }
            catch (Exception ex)
            {
                backgroundWorker1.ReportProgress(0, $"ERROR:Unable to find AD forest:{gForestName}\n{ex.Message}\n\nYou probably need to manually enter the forest using the button.");

                return;
            }

            DomainCollection domainCollection = forest.Domains;

            backgroundWorker1.ReportProgress(0, $"Found {domainCollection.Count} domains in forest {forest.Name}.");

            int CurrentDC = 0;

            int NumDCs = 0;

            foreach (Domain domain in domainCollection)
            {
                NumDCs += domain.DomainControllers.Count;
            }

            foreach (Domain domain in domainCollection)
            {
                DomainControllerCollection DCs = domain.DomainControllers;                

                foreach (DomainController dc in DCs)
                {                    
                    ADREPLDC adrepldc = new ADREPLDC();
                    
                    adrepldc.Name = dc.Name;

                    adrepldc.DomainName = domain.Name;

                    try
                    {
                        adrepldc.Site = dc.SiteName;                        
                    }
                    catch (Exception ex)
                    {
                        backgroundWorker1.ReportProgress((int)(((float)CurrentDC / (float)NumDCs) * 100), $"Failed to contact DC {adrepldc.Name} and fetch site name:{ex.Message}");

                        adrepldc.Site = "Unknown";

                        adrepldc.DiscoveryIssues = true;
                    }

                    try
                    {
                        adrepldc.IsGC = dc.IsGlobalCatalog().ToString();                        
                    }
                    catch (Exception ex)
                    {
                        backgroundWorker1.ReportProgress((int)(((float)CurrentDC / (float)NumDCs) * 100), $"Failed to contact DC {adrepldc.Name} and determine global catalog status:{ex.Message}");

                        adrepldc.IsGC = "Unknown";

                        adrepldc.DiscoveryIssues = true;
                    }

                    try
                    {
                        using (DirectoryEntry directoryEntry = new DirectoryEntry("LDAP://" + dc.Name))
                        {
                            using (DirectorySearcher search = new DirectorySearcher(directoryEntry))
                            {
                                search.ClientTimeout = new TimeSpan(0, 0, 20);

                                search.Filter = $"(samaccountname={dc.Name.Split('.')[0]}$)";

                                search.PropertiesToLoad.Add("msDS-isRODC");

                                SearchResult result = search.FindOne();

                                if (result == null || result.Properties["msDS-isRODC"].Count == 0)
                                {
                                    throw new Exception("msDS-isRODC attribute not found!");
                                }

                                if ((bool)result.Properties["msDS-isRODC"][0] == true)
                                {
                                    adrepldc.IsRODC = "True";
                                }
                                else
                                {
                                    adrepldc.IsRODC = "False";
                                }
                            }
                        }                        
                    }
                    catch (Exception ex)
                    {
                        backgroundWorker1.ReportProgress((int)(((float)CurrentDC / (float)NumDCs) * 100), $"Failed to determine RODC status for {dc.Name}:{ex.Message}");

                        adrepldc.IsRODC = "Unknown";

                        adrepldc.DiscoveryIssues = true;
                    }

                    if (adrepldc.DiscoveryIssues == false)
                    {
                        try
                        {
                            foreach (ReplicationNeighbor partner in dc.GetAllReplicationNeighbors())
                            {
                                adrepldc.ReplicationPartners.Add(partner);
                            }
                        }
                        catch (Exception ex)
                        {
                            backgroundWorker1.ReportProgress((int)(((float)CurrentDC / (float)NumDCs) * 100), $"Failed to determine replication neighbors and repl status for {dc.Name}:{ex.Message}");

                            adrepldc.DiscoveryIssues = true;
                        }
                    }
                    
                    gDCs.Add(adrepldc);

                    CurrentDC++;

                    backgroundWorker1.ReportProgress((int)(((float)CurrentDC / (float)NumDCs) * 100), "UPDATEPERCENT");
                }
            }

            

            treeListView1.SetObjects(gDCs);

            treeListView1.CanExpandGetter = delegate (object x) 
            {
                return (x is ADREPLDC);
            };

            treeListView1.ChildrenGetter = delegate (object x)
            {
                return ((ADREPLDC)x).ReplicationPartners;
            };
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressPercentLabel.Visible = false;            

            foreach (var control in this.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled = true;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (gLoggingEnabled)
            {
                System.IO.File.AppendAllText(gLogfileName, $"[{DateTime.Now}] {e.UserState}\n");
            }

            if (e.UserState.ToString().StartsWith("ERROR:"))
            {
                MessageBox.Show(e.UserState.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.UserState.ToString().Equals("UPDATEPERCENT"))
            {
                ProgressPercentLabel.Text = $"{e.ProgressPercentage}%";
            }
        }

        private void EnableLoggingButton_Click(object sender, EventArgs e)
        {
            gLoggingEnabled = !gLoggingEnabled;

            if (gLoggingEnabled)
            {
                toolTip1.SetToolTip(EnableLoggingButton, "Disable Logging");

                EnableLoggingButton.BackColor = SystemColors.ControlDark;

                DateTime Now = DateTime.Now;

                gLogfileName = $"adreplstatus_{Now.Month}.{Now.Day}.{Now.Year}.{Now.Hour}.{Now.Minute}.{Now.Second}.log";

                System.IO.File.AppendAllText(gLogfileName, $"[{DateTime.Now}] Logging enabled.\n");
            }
            else
            {
                toolTip1.SetToolTip(EnableLoggingButton, "Enable Logging");

                if (gDarkMode == true)
                {
                    EnableLoggingButton.BackColor = Color.FromArgb(32, 32, 32);
                }
                else
                {
                    EnableLoggingButton.BackColor = SystemColors.Control;
                }

                System.IO.File.AppendAllText(gLogfileName, $"[{DateTime.Now}] Logging disabled.\n");
            }
        }

        private void SetForestButton_Click(object sender, EventArgs e)
        {
            SetForestNameForm setForestNameForm = new SetForestNameForm();

            if (gLoggingEnabled)
            {
                System.IO.File.AppendAllText(gLogfileName, $"[{DateTime.Now}] SetForestName button was clicked.\n");
            }

            setForestNameForm.ShowDialog();

            setForestNameForm.Dispose();
        }

        private void AlternateCredsButton_Click(object sender, EventArgs e)
        {
            AlternateCredsForm alternateCredsForm = new AlternateCredsForm();

            if (gLoggingEnabled)
            {
                System.IO.File.AppendAllText(gLogfileName, $"[{DateTime.Now}] AlternateCreds button was clicked.\n");
            }

            alternateCredsForm.ShowDialog();

            alternateCredsForm.Dispose();
        }

        private void treeListView1_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            if (e.Model is ADREPLDC)
            {
                ADREPLDC dc = (ADREPLDC)e.Model;

                if (dc.DiscoveryIssues == true)
                {
                    e.Item.BackColor = Color.Red;

                    e.Item.ForeColor = Color.White;
                }
                else
                {
                    if (gDarkMode == true)
                    {
                        e.Item.ForeColor = Color.White;
                    }                    
                }
            }
            else if (e.Model is ReplicationNeighbor)
            {
                ReplicationNeighbor neighbor = (ReplicationNeighbor)e.Model;

                if (neighbor.ConsecutiveFailureCount > 0)
                {
                    e.Item.BackColor = Color.Red;

                    e.Item.ForeColor = Color.White;
                }
                else
                {
                    if (gDarkMode == true)
                    {
                        e.Item.ForeColor = Color.White;
                    }
                }
            }
        }

        private void ErrorsOnlyButton_Click(object sender, EventArgs e)
        {
            gErrorsOnly = !gErrorsOnly;

            if (gErrorsOnly == true)
            {
                toolTip1.SetToolTip(ErrorsOnlyButton, "Show Everything");

                ErrorsOnlyButton.BackColor = SystemColors.ControlDark;

                treeListView1.ExpandAll();

                treeListView1.ModelFilter = new ModelFilter(delegate (object x) 
                {
                    if (x is ADREPLDC)
                    {
                        return ((ADREPLDC)x).DiscoveryIssues;
                    }
                    else if (x is ReplicationNeighbor)
                    {
                        return (((ReplicationNeighbor)x).ConsecutiveFailureCount > 0);                        
                    }

                    return false;            
                });
            }
            else
            {
                toolTip1.SetToolTip(ErrorsOnlyButton, "Show Errors Only");

                if (gDarkMode == true)
                {
                    ErrorsOnlyButton.BackColor = Color.FromArgb(32, 32, 32);
                }
                else
                {
                    ErrorsOnlyButton.BackColor = SystemColors.Control;
                }

                treeListView1.ModelFilter = null;
            }
        }

        private void DarkModeButton_Click(object sender, EventArgs e)
        {
            gDarkMode = !gDarkMode;

            if (gDarkMode == true)
            {
                SetDarkMode();              
            }
            else
            {
                SetLightMode();
            }

            try
            {
                var key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\ADREPLSTATUS", true);

                if (key != null)
                {
                    if (gDarkMode == true)
                    {
                        key.SetValue("DarkMode", 1);
                    }
                    else
                    {
                        key.SetValue("DarkMode", 0);
                    }

                    key.Dispose();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"ERROR: Failed to write to the HKCU\\ADREPLSTATUS registry key!\n{ex.Message}\n";

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (gLoggingEnabled)
                {
                    System.IO.File.AppendAllText(ADReplStatusForm.gLogfileName, $"[{DateTime.Now}] {errorMessage}\n");
                }
            }
        }

        void SetDarkMode()
        {
            toolTip1.SetToolTip(DarkModeButton, "Light Mode");

            this.BackColor = Color.FromArgb(32, 32, 32);

            foreach (var control in this.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).BackColor = Color.FromArgb(32, 32, 32);
                }                

                if (control is Label)
                {
                    ((Label)control).BackColor = Color.FromArgb(32, 32, 32);

                    ((Label)control).ForeColor = Color.White;
                }
            }

            if (gLoggingEnabled == true)
            {
                EnableLoggingButton.BackColor = SystemColors.ControlDark;
            }

            if (gErrorsOnly == true)
            {
                ErrorsOnlyButton.BackColor = SystemColors.ControlDark;
            }

            treeListView1.BackColor = Color.FromArgb(32, 32, 32);

            foreach (OLVColumn item in treeListView1.Columns)
            {
                var headerstyle = new HeaderFormatStyle();

                headerstyle.SetBackColor(Color.FromArgb(32, 32, 32));

                headerstyle.SetForeColor(Color.White);

                item.HeaderFormatStyle = headerstyle;
            }
        }

        void SetLightMode()
        {
            toolTip1.SetToolTip(DarkModeButton, "Dark Mode");

            this.BackColor = SystemColors.Control;

            foreach (var control in this.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).BackColor = SystemColors.Control;
                }

                if (control is Label)
                {
                    ((Label)(control)).BackColor = SystemColors.Control;

                    ((Label)control).ForeColor = SystemColors.ControlText;
                }
            }

            if (gLoggingEnabled == true)
            {
                EnableLoggingButton.BackColor = SystemColors.ControlDark;
            }

            if (gErrorsOnly == true)
            {
                ErrorsOnlyButton.BackColor = SystemColors.ControlDark;
            }

            treeListView1.BackColor = SystemColors.Window;

            foreach (OLVColumn item in treeListView1.Columns)
            {
                var headerstyle = new HeaderFormatStyle();

                headerstyle.SetBackColor(SystemColors.Window);

                headerstyle.SetForeColor(SystemColors.ControlText);

                item.HeaderFormatStyle = headerstyle;
            }
        }
    }

    public class ADREPLDC
    {
        public string Name;

        public string DomainName;

        public bool DiscoveryIssues = false;

        public string Site;

        public string IsGC;

        public string IsRODC;

        public List<ReplicationNeighbor> ReplicationPartners = new List<ReplicationNeighbor>();
    }    

}

