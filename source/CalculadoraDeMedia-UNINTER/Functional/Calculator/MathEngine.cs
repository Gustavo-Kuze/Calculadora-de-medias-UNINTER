using System;
using System.Collections.Generic;
using System.Linq;
using CalculadoraDeMedias_UNINTER.Base.Calculator;


namespace CalculadoraDeMedias_UNINTER.Functional.Calculator
{
    public class MathEngine
    {
        
        public static Decimal calculateMD(List<Decimal> APOLs, Decimal AP, Decimal PD, Decimal PO, SubjectUtils.Subject subject)
        {
            Decimal MD = 0M;

            switch (subject)
            {
                case SubjectUtils.Subject.EAD_SUP_GESTAO_COMUNICACAO_NEGOCIOS:
                    MD = calcMDGesComu(APOLs, PO, PD);
                    break;
                case SubjectUtils.Subject.EAD_SUP_POLITECNICA:
                    MD = calculateMDPoli(APOLs, AP, PD, PO);
                    break;
                default:
                    MD = 101M; //error
                    break;
            }
            return MD;
        }

        public static Decimal calculateMD(Decimal APOL, Decimal APOrPF, Decimal PD, Decimal PO, SubjectUtils.Subject subject)
        {

            Decimal MD = 0M;

            switch (subject)
            {
                case SubjectUtils.Subject.EAD_SUP_EDU:
                    MD = calcMDEdu(APOL, APOrPF, PO, PD);
                    break;
                case SubjectUtils.Subject.EAD_SUP_GESTAO_PUBLICA_POLITICA_JURIDICA_SEGURANCA:
                    MD = calcMDGesPub(APOL, PO, PD);
                    break;
                case SubjectUtils.Subject.EAD_SUP_SAUDE_BIOCIENCIA_MEIOAMBIENTE_SOCIEDADE:
                    MD = calcMDBio(APOL, PO, PD);
                    break;
                case SubjectUtils.Subject.EAD_SUP_SAUDE_BIOCIENCIA_MEIOAMBIENTE_SOCIEDADE_SOCIO:
                    MD = calcMDSocio(APOL, APOrPF, PO, PD);
                    break;
                default:
                    MD = 101M; //error
                    break;
            }
            return MD;
        }
        
        public static Decimal calculateMF(Decimal MD, Decimal EO, Decimal ED, SubjectUtils.Subject subject)
        {
            Decimal MF = 0M;

            switch (subject)
            {
                case SubjectUtils.Subject.EAD_SUP_EDU:
                    MF = calcEXEdu(MD, EO, ED);
                    break;
                case SubjectUtils.Subject.EAD_SUP_GESTAO_COMUNICACAO_NEGOCIOS:
                    MF = calcEXGesComu(EO, ED);
                    break;
                case SubjectUtils.Subject.EAD_SUP_GESTAO_PUBLICA_POLITICA_JURIDICA_SEGURANCA:
                    MF = calcEXGesPu(MD, EO, ED);
                    break;
                case SubjectUtils.Subject.EAD_SUP_POLITECNICA:
                    MF = calculateEXPoli(MD, EO, ED);
                    break;
                case SubjectUtils.Subject.EAD_SUP_SAUDE_BIOCIENCIA_MEIOAMBIENTE_SOCIEDADE_SOCIO:
                    MF = calcEXSocio(MD, EO, ED);
                    break;
                default:
                    MF = 101M;   
                    break;
            }

            return MF;
        }
        
        //Edu

        private static Decimal calcMDEdu(Decimal APOL, Decimal PF, Decimal PO, Decimal PD)
        {
            Decimal MD = (APOL + PF + (PO * 3) + (PD * 5)) / 10;
            return MD;
        }

        private static Decimal calcEXEdu(Decimal MD, Decimal PO, Decimal PD)
        {
            Decimal EX = (MD + (PO * 4) + ((PD * 6) / 10)) / 2;
            return EX;
        }


        //Gestão comunicação

        private static Decimal calcMDGesComu(List<Decimal> APOLs, Decimal PO, Decimal PD)
        {
            Decimal MD = ( ((APOLs.Sum() / 5) * 2) + (PO * 3) + (PD * 5)) / 10;
            return MD;
        }

        private static Decimal calcEXGesComu(Decimal PO, Decimal PD)
        {
            Decimal EX = ((PO * 4) + (PD * 60) / 10) / 2;
            return EX;
        }


        //Gestão publica

        private static Decimal calcMDGesPub(Decimal APOL, Decimal PO, Decimal PD)
        {
            Decimal MD = ((APOL * 2) + (PO * 3) + (PD * 5)) / 10;
            return MD;
        }

        private static Decimal calcEXGesPu(Decimal MD, Decimal PO, Decimal PD)
        {
            Decimal EX = ((PO * 4) + (PD * 6) / 10) / 2;
            return EX;
        }



        //Biociencia

        private static Decimal calcMDBio(Decimal APOL, Decimal PO, Decimal PD)
        {
            Decimal MD = ((APOL * 2) + (PO * 3) + (PD * 5)) / 10;
            return MD;
        }


        //social mesma coisa que edu
        private static Decimal calcMDSocio(Decimal APOL, Decimal PF, Decimal PO, Decimal PD)
        {
            //
            Decimal MD = (APOL + PF + (PO * 3) + (PD * 5)) / 10;
            return MD;
        }

        private static Decimal calcEXSocio(Decimal MD, Decimal PO, Decimal PD)
        {
            Decimal EX = (MD + (PO * 4) + ((PD * 6) / 10)) / 2;
            return EX;
        }


        //poli
        private static Decimal calculateMDPoli(List<Decimal> APOLs, Decimal AP, Decimal PD, Decimal PO)
        {
            Decimal n3 = ((APOLs.Sum()) / 5);
            Decimal n4 = (((AP * 4) + (PD * 6))) / 10;
            Decimal MD = ((PO * 30) + (n3 * 20) + (n4 * 50)) / 100;


            return MD;
        }

        private static Decimal calculateEXPoli(Decimal MD, Decimal EO, Decimal ED)
        {
            Decimal ME = ((EO * 4) + (ED * 6)) / 10;
            Decimal MF = (ME + MD) / 2;
            return MF;
        }

    }
}
