using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TomarCamp.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            ListaDeObjetosDeConcretizacao = new HashSet<Concretizacao>();


        }

        public int ID { get; set; }

        public string Nome { get; set; }

        public string Foto { get; set; }



        public virtual ICollection<Concretizacao> ListaDeObjetosDeConcretizacao { get; set; }
    }
}