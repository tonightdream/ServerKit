using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerKit.UI
{
    public partial class FrmMain : Form
    {
        ServerKitController objController = new ServerKitController();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            objController.check();
        }

        private void btn_Repair_Click(object sender, EventArgs e)
        {

        }
    }
}
