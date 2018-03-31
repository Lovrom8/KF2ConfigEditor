using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KF2ConfigEditor.lib;

namespace KF2ConfigEditor
{
    public partial class frmEditSong : Form
    {

        public CustomMap Map;

        public frmEditSong(CustomMap _map)
        {
            InitializeComponent();
            tbSongName.Text = _map.Name;
            tbWorkshopKey.Text = _map.WSKey;
            comboMapType.SelectedIndex = comboMapType.Items.IndexOf(_map.Type);

            Map = new CustomMap();
        }

        private void btnEditSongCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnEditSongOK_Click(object sender, EventArgs e)
        {
            Map.Name = tbSongName.Text;
            Map.WSKey = tbWorkshopKey.Text;
            Map.Type = comboMapType.SelectedIndex == 0 ? "KF1" : "KF2";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
