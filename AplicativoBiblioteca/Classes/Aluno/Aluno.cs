/**********************************************************************************
 * NOME:            Aluno
 * CLASSE:          Representação da entidade Aluno 
 * DT CRIAÇÃO:      11/09/2019
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     mgomes
 * OBSERVAÇÕES:     Atributos privados com métodos Get e Set públicos
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    class Aluno
    {
        //(mgomes - 11/09/2019) Metodo de Destruição da Classe
        ~Aluno()
        {
        }

        //(mgomes - 11/09/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_Aluno = -1;
        private string vnm_Aluno = null;
        private string vende_Aluno = null;
        private string vbai_Aluno = null;
        private string vcid_Aluno = null;
        private string vuf_Aluno = null;
        private string vcep_Aluno = null;
        private string vrg_Aluno = null;
        private string vcel_Aluno = null;
        private string vemail_Aluno = null;
        private DateTime vnasc_Aluno = DateTime.MinValue;

        //(mgomes - 11/09/2019) Metodos/Ações Publicas

        /***********************************************************************
        * NOME:            COD_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public int COD_ALUNO
        {
            get { return vcod_Aluno; }
            set { vcod_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            NM_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string NM_ALUNO
        {
            get { return vnm_Aluno; }
            set { vnm_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            ENDE_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string ENDE_ALUNO
        {
            get { return vende_Aluno; }
            set { vende_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            BAI_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string BAI_ALUNO
        {
            get { return vbai_Aluno; }
            set { vbai_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            CID_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string CID_ALUNO
        {
            get { return vcid_Aluno; }
            set { vcid_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            UF_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string UF_ALUNO
        {
            get { return vuf_Aluno; }
            set { vuf_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            CEP_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string CEP_ALUNO
        {
            get { return vcep_Aluno; }
            set { vcep_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            RG_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string RG_ALUNO
        {
            get { return vuf_Aluno; }
            set { vuf_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            CEL_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string CEL_ALUNO
        {
            get { return vcel_Aluno; }
            set { vcel_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            EMAIL_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string EMAIL_ALUNO
        {
            get { return vemail_Aluno; }
            set { vemail_Aluno = value; }
        }

        /***********************************************************************
        * NOME:            NASC_ALUNO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public DateTime NASC_ALUNO
        {
            get { return vnasc_Aluno; }
            set { vnasc_Aluno = value; }
        }

    }
}
