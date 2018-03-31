using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KF2ConfigEditor
{
    public partial class frmEditMapCycles : Form
    {
        public string MapCycle { get; set; }
        public frmEditMapCycles(string oldMapCycle)
        {
            InitializeComponent();
            tbMapCycle.Text = oldMapCycle;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.MapCycle = tbMapCycle.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();   
        }
    }
}
