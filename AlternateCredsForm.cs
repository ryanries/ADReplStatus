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
    }
}
