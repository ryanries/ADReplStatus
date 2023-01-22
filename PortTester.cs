using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADReplStatus
{
    public partial class PortTester : Form
    {
        bool g_checkAll_rbtn_isChecked = false;
        bool g_tnc_firstRun_onMulti = false;
        public PortTester()
        {
            InitializeComponent();
            this.target_txtbox.Text = $"{ADReplStatusForm.gTarget.ToString()}";
            portProtocolList();
        }

        private void portOverride_btn_CheckedChanged(object sender, EventArgs e)
        {
            if(this.port_label.Visible == false) 
            {
                this.port_label.Visible = true;
                this.port_txtbox.Visible = true;
                this.manualTest_btn.Visible = true;
            }
            else
            {
                this.port_label.Visible = false;
                this.port_txtbox.Visible = false;
                this.manualTest_btn.Visible = false;
            }
        }

        private void portProtocolList()
        {
            this.protocolTesterListBox.CheckOnClick = true;

            string rpcEpmString = "Remote Procedure Call // EndpointMapper";
            string ldapString = "LDAP";
            string ldapSSLString = "LDAP SSL";
            string dnsString = "Domain Name Service";
            string globalCatalogLDAPString = "Global Catalog LDAP";
            string globalCatalogLDAPSSLString = "Global Catalog LDAP SSL";
            string kerberosString = "Kerberos authentication";
            string smbString = "SMB, NetLogon, SamR";

            string[] stringArray;
            stringArray = new string[] { rpcEpmString, ldapString, ldapSSLString, dnsString, globalCatalogLDAPString, globalCatalogLDAPSSLString, kerberosString, smbString };

            foreach(String s in stringArray)
            {
                this.protocolTesterListBox.Items.Add(s);
            }

        }

        private async void manualTest_btn_Click(object sender, EventArgs e)
        {
            if(this.port_txtbox.Text == "" || this.port_txtbox.Text == null)
            {
                string errorMessage = "When using the manual test method you MUST provide a port to test with!";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Int32 port = Int32.Parse(this.port_txtbox.Text);
                await testNetConnection(this.target_txtbox.Text, port, false);
            }
            catch
            {
                //Do nothing, the exception should've already been caught in testNetConnection
            }
        }

        private async Task testNetConnection(string target, Int32 port, bool isMulti)
        {
            if(g_tnc_firstRun_onMulti && isMulti)
            {
                this.results_txtbox.Text = "";
            }
            else if(!isMulti)
            {
                this.results_txtbox.Text = "";
            }

            try
            {
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                this.results_txtbox.AppendText($"Testing TCP connection to {target} on port {port}:{Environment.NewLine}");
                await client.ConnectAsync(target, port);

                if (ADReplStatusForm.gLoggingEnabled)
                {
                    System.IO.File.AppendAllText(ADReplStatusForm.gLogfileName, $"[{DateTime.Now}] Connection to {target} was successful on {port}{Environment.NewLine}");
                }
                
                string successMessage = $"Connection successful! {Environment.NewLine}===========================";
                this.results_txtbox.AppendText(successMessage);
                this.results_txtbox.AppendText($"{Environment.NewLine}Local IP Address: {client.LocalEndPoint.ToString()}{Environment.NewLine}"); 
                this.results_txtbox.AppendText($"{Environment.NewLine}Remote IP Address: {client.RemoteEndPoint.ToString()}{Environment.NewLine}{Environment.NewLine}");

                new Thread(() => client.Disconnect(true));

            }
            catch (Exception ex)
            {
                string errorMessage = $"ERROR: Connection to {target} using port {port} failed!{Environment.NewLine}{Environment.NewLine}{ex.Message}{Environment.NewLine}";
                this.results_txtbox.AppendText($"{Environment.NewLine}{errorMessage}{Environment.NewLine}");

                if (ADReplStatusForm.gLoggingEnabled)
                {
                    System.IO.File.AppendAllText(ADReplStatusForm.gLogfileName, $"[{DateTime.Now}] {errorMessage}\n");
                }
            }
        }

        private void selectAll_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            g_checkAll_rbtn_isChecked = this.selectAll_rbtn.Checked;
        }

        private void selectAll_rbtn_Click(object sender, EventArgs e)
        {
            if(selectAll_rbtn.Checked && !g_checkAll_rbtn_isChecked)
            {
                selectAll_rbtn.Checked = false;
                for (int i = 0; i < this.protocolTesterListBox.Items.Count; i++)
                {
                    this.protocolTesterListBox.SetItemChecked(i, false);
                }
            }
            else
            {
                selectAll_rbtn.Checked = true;
                g_checkAll_rbtn_isChecked = false;
                for (int i = 0; i < this.protocolTesterListBox.Items.Count; i++)
                {
                    this.protocolTesterListBox.SetItemChecked(i, true);
                }
            }
        }

        private async void runTest_btn_Click(object sender, EventArgs e)
        {

            Int32 rpcEpmPort = 135;
            Int32 ldapPort = 389;
            Int32 ldapSSLPort = 636;
            Int32 globalCatalogLDAPPort = 3268;
            Int32 globalCatalogLDAPSSLPort = 3269;
            Int32 kerberosPort = 88;
            Int32 dnsPort = 53;
            Int32 smbPort = 445;

            try
            {
                g_tnc_firstRun_onMulti = true;
                foreach (var item in protocolTesterListBox.CheckedItems)
                {
                    string protocolname = item.ToString();
                    Int32 selectedPort;
                    switch (protocolname)
                    {
                        case "Remote Procedure Call // EndpointMapper":
                            selectedPort = rpcEpmPort;
                            break;
                        case "LDAP":
                            selectedPort = ldapPort;
                            break;
                        case "LDAP SSL":
                            selectedPort = ldapSSLPort;
                            break;
                        case "Domain Name Service":
                            selectedPort = globalCatalogLDAPPort;
                            break;
                        case "Global Catalog LDAP":
                            selectedPort = globalCatalogLDAPSSLPort;
                            break;
                        case "Global Catalog LDAP SSL":
                            selectedPort = kerberosPort;
                            break;
                        case "Kerberos authentication":
                            selectedPort = dnsPort;
                            break;
                        case "SMB, NetLogon, SamR":
                            selectedPort = smbPort;
                            break;
                        default:
                            return;
                    }
                    await testNetConnection(this.target_txtbox.Text, selectedPort, true);
                    g_tnc_firstRun_onMulti = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                g_tnc_firstRun_onMulti = false;
            }

        }

        private void exportResults_btn_Click(object sender, EventArgs e)
        {
            if(results_txtbox.Text.Length <= 0)
            {
                new Thread(() => MessageBox.Show("Cannot export an empty results report!", "No results available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)).Start();
            }
            else
            {
                try
                {
                    System.IO.File.WriteAllLines("PortTester_Results.txt", results_txtbox.Lines);
                    new Thread(() => MessageBox.Show($"Results exported to: {Application.StartupPath.ToString()}\\PortTester_Results.txt", "Successfl export", MessageBoxButtons.OK, MessageBoxIcon.Information)).Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
