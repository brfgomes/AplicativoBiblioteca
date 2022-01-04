/**********************************************************************************
 * NOME:            Editora
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
    class Editora
    {
        //(mgomes - 11/09/2019) Metodo de Destruição da Classe
        ~Editora()
        {
        }

        //(mgomes - 11/09/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_Editora = -1;
        private string vnm_Editora = null;
        private string vende_Editora = null;
        private string vbai_Editora = null;
        private string vcid_Editora = null;
        private string vuf_Editora = null;
        private string vcep_Editora = null;
        private string vcnpj_Editora = null;
        private string vtel_Editora = null;
        private string vsite_Editora = null;
        private string vemail_Editora = null;

        //(mgomes - 11/09/2019) Metodos/Ações Publicas

        /***********************************************************************
        * NOME:            COD_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public int COD_EDITORA
        {
            get { return vcod_Editora; }
            set { vcod_Editora = value; }
        }

        /***********************************************************************
        * NOME:            NM_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string NM_EDITORA
        {
            get { return vnm_Editora; }
            set { vnm_Editora = value; }
        }

        /***********************************************************************
        * NOME:            ENDE_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string ENDE_EDITORA
        {
            get { return vende_Editora; }
            set { vende_Editora = value; }
        }

        /***********************************************************************
        * NOME:            BAI_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string BAI_EDITORA
        {
            get { return vbai_Editora; }
            set { vbai_Editora = value; }
        }

        /***********************************************************************
        * NOME:            CID_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string CID_EDITORA
        {
            get { return vcid_Editora; }
            set { vcid_Editora = value; }
        }

        /***********************************************************************
        * NOME:            UF_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string UF_EDITORA
        {
            get { return vuf_Editora; }
            set { vuf_Editora = value; }
        }

        /***********************************************************************
        * NOME:            CEP_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string CEP_EDITORA
        {
            get { return vcep_Editora; }
            set { vcep_Editora = value; }
        }

        /***********************************************************************
        * NOME:            CNPJ_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string CNPJ_EDITORA
        {
            get { return vuf_Editora; }
            set { vuf_Editora = value; }
        }

        /***********************************************************************
        * NOME:            CEL_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string CEL_EDITORA
        {
            get { return vtel_Editora; }
            set { vtel_Editora = value; }
        }

        /***********************************************************************
        * NOME:            SITE_EDITORA       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string SITE_EDITORA
        {
            get { return vsite_Editora; }
            set { vsite_Editora = value; }
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
            get { return vemail_Editora; }
            set { vemail_Editora = value; }
        }

    }
}
