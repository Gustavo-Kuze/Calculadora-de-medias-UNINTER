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

            Utils.UIMethods uiMethods = new Utils.UIMethods(this);

            btnMin.Click += uiMethods.btnMin_Click;
            btnClose.Click += uiMethods.btnClose_Click;
            paneTitleBar.MouseDown += uiMethods.frm_MouseDown;
            paneTitleBar.MouseMove += uiMethods.frm_MouseMove;
        }

        private void lblOpenMoreInfo_Click(object sender, EventArgs e)
        {
            paneMoreInfo.Size = new Size(paneMoreInfo.Size.Width, 526);
        }

        private void btnCloseMoreInfo_Click(object sender, EventArgs e)
        {
            paneMoreInfo.Size = new Size(paneMoreInfo.Size.Width, 0);
        }

        private void lblOpenGithub_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/gustavokuze/Calculadora-de-medias-UNINTER");
            }
            catch
            {
            }
        }
    }
}
