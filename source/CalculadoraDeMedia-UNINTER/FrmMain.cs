using CalculadoraDeMedias_UNINTER.Base.Calculator;
using CalculadoraDeMedias_UNINTER.Functional.Calculator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculadoraDeMedias_UNINTER
{
    public partial class FrmMain : Form
    {
        public SubjectUtils.Subject sub { get; set; } = SubjectUtils.Subject.EAD_SUP_POLITECNICA;

        public FrmMain()
        {
            InitializeComponent();
            initializeProgram();
        }

        private void initializeProgram()
        {
            cleanFields();
            
            cmbSubjects.SelectedIndex = 3;

            Base.Program.GlobalEvents uiMethods = new Base.Program.GlobalEvents(this);
            
            btnMin.Click += uiMethods.btnMin_Click;
            btnClose.Click += uiMethods.btnClose_Click;
            paneTitleBar.MouseDown += uiMethods.frm_MouseDown;
            paneTitleBar.MouseMove += uiMethods.frm_MouseMove;
        }

        private void cleanFields()
        {
            txtMD.Text = "";
            lblResult.Text = "";
            nudApol1.Value = 0;
            nudApol2.Value = 0;
            nudApol3.Value = 0;
            nudApol4.Value = 0;
            nudApol5.Value = 0;
            nudAP.Value = 0;
            nudPF.Value = 0;
            nudPO.Value = 0;
            nudPD.Value = 0;
            nudEO.Value = 0;
            nudED.Value = 0;
            nudMD.Value = 0;
          
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
            Decimal MD = nudMD.Value;
            Decimal MF = MathEngine.calculateMF(MD, EO, ED, sub);

            return MF;
        }

        private Decimal calculateMD()
        {
            Decimal MD = 0M;
        
            if(sub == Base.Calculator.SubjectUtils.Subject.EAD_SUP_GESTAO_COMUNICACAO_NEGOCIOS || sub == Base.Calculator.SubjectUtils.Subject.EAD_SUP_POLITECNICA)
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

                MD = MathEngine.calculateMD(APOLsList, AP, PD, PO, sub);
            }else if(sub == SubjectUtils.Subject.EAD_SUP_EDU || sub == SubjectUtils.Subject.EAD_SUP_SAUDE_BIOCIENCIA_MEIOAMBIENTE_SOCIEDADE_SOCIO)
            {
                Decimal APOL = nudApol1.Value;
                Decimal PF = nudPF.Value;
                Decimal PO = nudPO.Value;
                Decimal PD = nudPD.Value;

                MD = MathEngine.calculateMD(APOL, PF, PD, PO, sub);
            }else if(sub == SubjectUtils.Subject.EAD_SUP_GESTAO_PUBLICA_POLITICA_JURIDICA_SEGURANCA || sub == SubjectUtils.Subject.EAD_SUP_SAUDE_BIOCIENCIA_MEIOAMBIENTE_SOCIEDADE)
            {
                Decimal APOL = nudApol1.Value;
                Decimal PO = nudPO.Value;
                Decimal PD = nudPD.Value;

                MD = MathEngine.calculateMD(APOL, 0M, PD, PO, sub);
            }
            
            return MD;
        }

        private void showResultsToUser(Decimal userResult, bool isMF = false)
        {
            txtMD.Text = userResult.ToString();

            int checkResult = Result.check(userResult, isMF);

            txtMD.Text = userResult.ToString();

            lblResult.Text = ResultUtils.resultsText[checkResult];
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
                panelAP.Enabled = true;
                panelMF.Enabled = false;
            }
            else
            {
                paneAPOLs.Enabled = false;
                panePOPD.Enabled = false;
                panelAP.Enabled = false;
                panelMF.Enabled = true;
            }
        }



        private void prepareUIBasedOnSubject(Base.Calculator.SubjectUtils.Subject subject)
        {
            cleanFields();
            sub = subject;

            switch (subject)
            {
                case SubjectUtils.Subject.EAD_SUP_EDU:

                    panelAPOLs.Visible = false;
                    panelPF.Visible = true;
                    panelAP.Visible = false;
                    rdoCalculateMF.Visible = true;
                    break;
                case SubjectUtils.Subject.EAD_SUP_GESTAO_COMUNICACAO_NEGOCIOS:
                    panelAPOLs.Visible = true;
                    panelPF.Visible = false;
                    panelAP.Visible = false;
                    rdoCalculateMF.Visible = true;
                    break;
                case SubjectUtils.Subject.EAD_SUP_GESTAO_PUBLICA_POLITICA_JURIDICA_SEGURANCA:
                    panelAPOLs.Visible = false;
                    panelPF.Visible = false;
                    panelAP.Visible = false;
                    rdoCalculateMF.Visible = true;
                    break;
                case SubjectUtils.Subject.EAD_SUP_POLITECNICA:
                    panelAPOLs.Visible = true;
                    panelPF.Visible = false;
                    panelAP.Visible = true;
                    rdoCalculateMF.Visible = true;
                    break;
                case SubjectUtils.Subject.EAD_SUP_SAUDE_BIOCIENCIA_MEIOAMBIENTE_SOCIEDADE:
                    panelAPOLs.Visible = false;
                    panelPF.Visible = false;
                    panelAP.Visible = false;
                    rdoCalculateMF.Visible = false;
                    break;
                case SubjectUtils.Subject.EAD_SUP_SAUDE_BIOCIENCIA_MEIOAMBIENTE_SOCIEDADE_SOCIO:
                    panelAPOLs.Visible = false;
                    panelPF.Visible = true;
                    panelAP.Visible = false;
                    rdoCalculateMF.Visible = true;
                    break;
                default:
                    break;
            }
        }


        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSubjects.SelectedIndex == 0) //edu
            {
                prepareUIBasedOnSubject(Base.Calculator.SubjectUtils.Subject.EAD_SUP_EDU);
            }
            else if (cmbSubjects.SelectedIndex == 1) //gesComu
            {
                prepareUIBasedOnSubject(Base.Calculator.SubjectUtils.Subject.EAD_SUP_GESTAO_COMUNICACAO_NEGOCIOS);
            }
            else if (cmbSubjects.SelectedIndex == 2) //gesPub
            {
                prepareUIBasedOnSubject(Base.Calculator.SubjectUtils.Subject.EAD_SUP_GESTAO_PUBLICA_POLITICA_JURIDICA_SEGURANCA);
            }
            else if (cmbSubjects.SelectedIndex == 3) //poli
            {
                prepareUIBasedOnSubject(Base.Calculator.SubjectUtils.Subject.EAD_SUP_POLITECNICA);
            }
            else if (cmbSubjects.SelectedIndex == 4) //bio
            {
                prepareUIBasedOnSubject(Base.Calculator.SubjectUtils.Subject.EAD_SUP_SAUDE_BIOCIENCIA_MEIOAMBIENTE_SOCIEDADE);
            }
            else if (cmbSubjects.SelectedIndex == 5) //Socio
            {
                prepareUIBasedOnSubject(Base.Calculator.SubjectUtils.Subject.EAD_SUP_SAUDE_BIOCIENCIA_MEIOAMBIENTE_SOCIEDADE_SOCIO);
            }
        }
    }
}
/*
 EAD - Educação
EAD - Gestão, Comunicação e Negócios
EAD - Gestão Pública, Política, Jurídica e de Segurança
EAD - Politécnica
EAD - Saúde, Biociência, Meio Ambiente e Sociedade (Serviço social)
     */
