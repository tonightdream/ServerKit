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
    public partial class Form1 : Form
    {
        ServerKitController objController = new ServerKitController();
        public Form1()
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
