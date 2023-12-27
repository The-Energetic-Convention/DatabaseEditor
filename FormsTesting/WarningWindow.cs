using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTesting
{
    public partial class WarningWindow : Form
    {
        public WarningWindow(string message, string confirm, string cancel)
        {
            InitializeComponent();
            WarningMessage.Text = message;
            ConfirmExit.Text = $"Yes, {confirm}";
            CancelExit.Text = $"No, {cancel}";
            DialogResult = DialogResult.No;
        }


        private void ConfirmExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void CancelExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
