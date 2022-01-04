/**********************************************************************************
 * NOME:            ItemEmprestimo
 * CLASSE:          Representação da entidade ItemEmprestimo 
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
    class ItemEmprestimo
    {
        //(mgomes - 11/09/2019) Metodo de Destruição da Classe
        ~ItemEmprestimo()
        {
        }

        //(mgomes - 11/09/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_ItemEmprestimo = -1;
        private int vcod_Emprestimo = -1;
        private int vcod_Livro = -1;

        //(mgomes - 11/09/2019) Metodos/Ações Publicas

        /***********************************************************************
        * NOME:            COD_ITEMEMPRESTIMO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public int COD_ITEMEMPRESTIMO
        {
            get { return vcod_ItemEmprestimo; }
            set { vcod_ItemEmprestimo = value; }
        }

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
        * NOME:            COD_LIVRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public int COD_LIVRO
        {
            get { return vcod_Livro; }
            set { vcod_Livro = value; }
        }

    }
}
