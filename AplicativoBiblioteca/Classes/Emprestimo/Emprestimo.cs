
 /**********************************************************************************
 * NOME:            Emprestimo
 * CLASSE:          Representação da entidade Emprestimo 
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
        class Emprestimo
        {
            //(mgomes - 11/09/2019) Metodo de Destruição da Classe
            ~Emprestimo()
            {
            }

            //(mgomes - 11/09/2019) Atributos/Propriedades Privadas Encapsuladas
            private int vcod_Emprestimo = -1;
            private int vcod_Autor = -1;
            private DateTime vini_Emprestimo = DateTime.MinValue;
            private DateTime vfim_Emprestimo = DateTime.MinValue;

            //(mgomes - 11/09/2019) Metodos/Ações Publicas

            /***********************************************************************
            * NOME:            COD_EMPRESTIMO       
            * METODO:          Representação do atributo Código com os métodos 
            *                  Get e Set          
            * DT CRIAÇÃO:      11/09/2019    
            * DT ALTERAÇÃO:    -
            * ESCRITA POR:     mgomes 
            **********************************************************************/
            public int COD_EMPRESTIMO
            {
                get { return vcod_Emprestimo; }
                set { vcod_Emprestimo = value; }
            }

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
        * NOME:            INI_EMPRESTIMO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public DateTime INI_EMPRESTIMO
            {
                get { return vini_Emprestimo; }
                set { vini_Emprestimo = value; }
            }

            /***********************************************************************
            * NOME:            FIM_EMPRESTIMO       
            * METODO:          Representação do atributo Código com os métodos 
            *                  Get e Set          
            * DT CRIAÇÃO:      11/09/2019    
            * DT ALTERAÇÃO:    -
            * ESCRITA POR:     mgomes 
            **********************************************************************/
            public DateTime FIM_EMPRESTIMO
            {
                get { return vfim_Emprestimo; }
                set { vfim_Emprestimo = value; }
            }
        
        }
    }


