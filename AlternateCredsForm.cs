using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADReplStatus
{
    public partial class AlternateCredsForm : Form
    {
        public AlternateCredsForm()
        {
            InitializeComponent();
        }

        private void AlternateCredsButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0)
            {
                ADReplStatusForm.gUsername = UsernameTextBox.Text;

                ADReplStatusForm.gPassword = PasswordTextBox.Text;

                this.Dispose();

                if (ADReplStatusForm.gLoggingEnabled)
                {
                    System.IO.File.AppendAllText(ADReplStatusForm.gLogfileName, $"[{DateTime.Now}] Using alternate identity: {ADReplStatusForm.gUsername}\n");
                }
            }
        }

        private void AlternateCredsForm_Load(object sender, EventArgs e)
        {
            if (ADReplStatusForm.gDarkMode == true)
            {
                this.BackColor = Color.FromArgb(32, 32, 32);

                foreach (var control in this.Controls)
                {
                    if (control is Label)
                    {
                        ((Label)control).BackColor = Color.FromArgb(32, 32, 32);

                        ((Label)control).ForeColor = Color.White;
                    }
                    else if (control is TextBox)
                    {
                        ((TextBox)control).BackColor = Color.FromArgb(32, 32, 32);

                        ((TextBox)control).ForeColor = Color.White;
                    }
                    else if (control is Button)
                    {
                        ((Button)control).BackColor = Color.FromArgb(32, 32, 32);

                        ((Button)control).ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
