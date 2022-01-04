/**********************************************************************************
 * NOME:            Livro
 * CLASSE:          Representação da entidade Livro 
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
    class Livro
    {
        //(mgomes - 11/09/2019) Metodo de Destruição da Classe
        ~Livro()
        {
        }

        //(mgomes - 11/09/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_Livro = -1;
        private int vcod_Autor = -1;
        private int vcod_Genero = -1;
        private int vcod_Editora = -1;
        private string vtit_Livro = null;
        private string vpgs_Livro = null;
        private string visbn_Livro = null;

        //(mgomes - 11/09/2019) Metodos/Ações Publicas

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
        * NOME:            TIT_LIVRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string TIT_LIVRO
        {
            get { return vtit_Livro; }
            set { vtit_Livro = value; }
        }

        /***********************************************************************
        * NOME:            PGS_LIVRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string PGS_LIVRO
        {
            get { return vpgs_Livro; }
            set { vpgs_Livro = value; }
        }

        /***********************************************************************
        * NOME:            ISBN_LIVRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      11/09/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     mgomes 
        **********************************************************************/
        public string ISBN_LIVRO
        {
            get { return visbn_Livro; }
            set { visbn_Livro = value; }
        }

    }
}
