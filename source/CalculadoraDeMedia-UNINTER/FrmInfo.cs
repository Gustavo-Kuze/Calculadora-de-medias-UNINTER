using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeMedia_UNINTER
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();

            btnMin.Click += new Utils.UIMethods().btnMin_Click;
            btnClose.Click += new Utils.UIMethods().btnClose_Click;
            paneTitleBar.MouseDown += new Utils.UIMethods().Frm_MouseDown;
        }

        private void lblOpenMoreInfo_Click(object sender, EventArgs e)
        {
            paneMoreInfo.Size = new Size(paneMoreInfo.Size.Width, 526);
        }

        private void btnCloseMoreInfo_Click(object sender, EventArgs e)
        {
            paneMoreInfo.Size = new Size(paneMoreInfo.Size.Width, 0);
        }
    }
}
