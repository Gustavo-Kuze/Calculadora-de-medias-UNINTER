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
    public partial class FrmMain : Form
    {
       
        public FrmMain()
        {
            InitializeComponent();
            initializeFields();
        }
        
        private void initializeFields()
        {
            txtMD.Text = "";
            lblResult.Text = "";

            btnMin.Click += new Utils.UIMethods().btnMin_Click;
            btnClose.Click += new Utils.UIMethods().btnClose_Click;
            paneTitleBar.MouseDown += new Utils.UIMethods().Frm_MouseDown;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rdoCalculateMD.Checked)
            {
                calculateMD();
            }
            else
            {
                calculateMF();
            }
        }

        private void calculateMF()
        {
            Decimal EO = nudEO.Value;
            Decimal ED = nudED.Value;
            Decimal MD = nudMFMD.Value;
            Decimal MF = Utils.MathEngine.calculateMF(MD, EO, ED);

            int checkResult = Utils.Results.check(MF, true);

            txtMD.Text = MF.ToString();

            lblResult.Text = Helper.Structure.resultsText[checkResult];
            lblResult.ForeColor = Helper.Structure.resultsColors[checkResult];
        }

        private void calculateMD()
        {
            List<Decimal> APOLsList = new List<Decimal>();
            APOLsList.Add(nudApol1.Value);
            APOLsList.Add(nudApol2.Value);
            APOLsList.Add(nudApol3.Value);
            APOLsList.Add(nudApol4.Value);
            APOLsList.Add(nudApol5.Value);

            Decimal AP = nudAP.Value;
            Decimal PO = nudPO.Value;
            Decimal PD = nudPD.Value;
            Decimal EX = nudEO.Value;


            Decimal MD = Utils.MathEngine.calculateMD(APOLsList, AP, PD, PO);

            txtMD.Text = MD.ToString();

            int checkResult = Utils.Results.check(MD);

            lblResult.Text = Helper.Structure.resultsText[checkResult];
            lblResult.ForeColor = Helper.Structure.resultsColors[checkResult];
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            FrmInfo fInfo = new FrmInfo();
            fInfo.ShowDialog();
        }

        private void rdoCalculateMD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCalculateMD.Checked)
            {
                paneAPOLs.Enabled = true;
                panePOPD.Enabled = true;
                paneAP.Enabled = true;
                panelMF.Enabled = false;
            }
            else
            {
                paneAPOLs.Enabled = false;
                panePOPD.Enabled = false;
                paneAP.Enabled = false;
                panelMF.Enabled = true;
            }
        }
    }
}
