using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TomarCamp.Models
{
    public class Pais
    {
        public Pais()
        {
            ListaDeObjetosDeCriancas = new HashSet<Criancas>();


        }

        public int ID { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string NumCC { get; set; }

        public string NIF { get; set; }

        public string Telemovel { get; set; }

        public string Email { get; set; }


        public virtual ICollection<Criancas> ListaDeObjetosDeCriancas { get; set; }
    }
}