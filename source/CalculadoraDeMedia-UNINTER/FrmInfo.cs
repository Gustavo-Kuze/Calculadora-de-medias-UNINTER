using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraDeMedias_UNINTER
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
            initializeProgram();
        }

        private void initializeProgram()
        {
            Base.Program.GlobalEvents uiMethods = new Base.Program.GlobalEvents(this);

            btnMin.Click += uiMethods.btnMin_Click;
            btnClose.Click += uiMethods.btnClose_Click;
            paneTitleBar.MouseDown += uiMethods.frm_MouseDown;
            paneTitleBar.MouseMove += uiMethods.frm_MouseMove;
        }


        private void animateInfoPanel(bool show = true)
        {
            if (show)
            {
                paneMoreInfo.Size = new Size(paneMoreInfo.Size.Width, 526);
            }
            else
            {
                paneMoreInfo.Size = new Size(paneMoreInfo.Size.Width, 0);
            }
        }

        private void lblOpenMoreInfo_Click(object sender, EventArgs e)
        {
            animateInfoPanel();
        }

        private void btnCloseMoreInfo_Click(object sender, EventArgs e)
        {
            animateInfoPanel(false);
        }

        private void lblOpenGithub_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/gustavokuze/Calculadora-de-medias-UNINTER");
            }
            catch
            {
                MessageBox.Show("Não foi possível iniciar o link diretamente, por favor abra o painel de mais informações e abra a partir do link \"Página do projeto\".", 
                    "Impossível iniciar o processo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
