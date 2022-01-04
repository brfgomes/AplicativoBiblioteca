/**********************************************************************************
 * NOME:            Genero
 * CLASSE:          Representação da entidade Genero 
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
    class Genero
    {
        //(mgomes - 11/09/2019) Metodo de Destruição da Classe
        ~Genero()
        {
        }

        //(mgomes - 11/09/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_Genero = -1;
        private string vrtl_Genero = null;
        private string vdcs_Genero = null;

        //(mgomes - 11/09/2019) Metodos/Ações Publicas

        /***********************************************************************
        * NOME:            COD_GENERO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public int COD_GENERO
        {
            get { return vcod_Genero; }
            set { vcod_Genero = value; }
        }

        /***********************************************************************
        * NOME:            RTL_GENERO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string vrtl
        {
            get { return vrtl_Genero; }
            set { vrtl_Genero = value; }
        }

        /***********************************************************************
        * NOME:            DCS_GENERO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string DCS_GENERO
        {
            get { return vdcs_Genero; }
            set { vdcs_Genero = value; }
        }

    }
}
