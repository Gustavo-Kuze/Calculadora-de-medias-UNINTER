using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculadoraDeMedias_UNINTER
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
            initializeProgram();
        }

        private void initializeProgram()
        {
            txtMD.Text = "";
            lblResult.Text = "";

            Base.Program.GlobalEvents uiMethods = new Base.Program.GlobalEvents(this);

            btnMin.Click += uiMethods.btnMin_Click;
            btnClose.Click += uiMethods.btnClose_Click;
            paneTitleBar.MouseDown += uiMethods.frm_MouseDown;
            paneTitleBar.MouseMove += uiMethods.frm_MouseMove;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rdoCalculateMD.Checked)
            {
                Decimal mD = calculateMD();
                showResultsToUser(mD);
            }
            else
            {
                Decimal mF = calculateMF();
                showResultsToUser(mF, true);
            }
        }

        private Decimal calculateMF()
        {
            Decimal EO = nudEO.Value;
            Decimal ED = nudED.Value;
            Decimal MD = nudMFMD.Value;
            Decimal MF = Functional.Calculator.MathEngine.calculateMF(MD, EO, ED);

            return MF;
        }

        private Decimal calculateMD()
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

          Decimal MD = Functional.Calculator.MathEngine.calculateMD(APOLsList, AP, PD, PO);

            return MD;
        }

        private void showResultsToUser(Decimal userResult, bool isMF = false)
        {
            txtMD.Text = userResult.ToString();

            int checkResult = Functional.Calculator.Result.check(userResult, isMF);

            txtMD.Text = userResult.ToString();

            lblResult.Text = Base.Calculator.ResultUtils.resultsText[checkResult];
            lblResult.ForeColor = Base.Calculator.ResultUtils.resultsColors[checkResult];

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
