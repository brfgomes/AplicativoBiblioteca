/**********************************************************************************
 * NOME:            Autor
 * CLASSE:          Representação da entidade Autor 
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
    class Autor
    {
        //(mgomes - 11/09/2019) Metodo de Destruição da Classe
        ~Autor()
        {
        }

        //(mgomes - 11/09/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_Autor = -1;
        private string vnm_Autor = null;
        private string vgen_Autor = null;
        private DateTime vnasc_Autor = DateTime.MinValue;


        //(mgomes - 11/09/2019) Metodos/Ações Publicas

        /***********************************************************************
        * NOME:            COD_AUTOR       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public int COD_AUTOR
        {
            get { return vcod_Autor; }
            set { vcod_Autor = value; }
        }

        /***********************************************************************
        * NOME:            NM_AUTOR       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string NM_AUTOR
        {
            get { return vnm_Autor; }
            set { vnm_Autor = value; }
        }

        /***********************************************************************
        * NOME:            GEN_AUTOR       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string GEN_AUTOR
        {
            get { return vgen_Autor; }
            set { vgen_Autor = value; }
        }

        /***********************************************************************
        * NOME:            BAI_AUTOR       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public DateTime NASC_AUTOR
        {
            get { return vnasc_Autor; }
            set { vnasc_Autor = value; }
        }

    }
}
