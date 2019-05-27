using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TomarCamp.Models
{
    public class Concretizacao
    {
        public Concretizacao()
        {
            ListaDeObjetosDeFuncionario = new HashSet<Funcionario>();
            ListaDeObjetosDePlanoDeAtividades = new HashSet<PlanoDeAtividades>();

        }

        public int Id { get; set; }

        public DateTime dataInicioConcretizacao { get; set; }

        public DateTime dataFimConcretizacao { get; set; }

        public string local { get; set; }


        [ForeignKey("Atividade")]
        public int AtividadeFK { get; set; }
        public Atividades Atividade { get; set; }

        public virtual ICollection<Funcionario> ListaDeObjetosDeFuncionario { get; set; }

        public virtual ICollection<PlanoDeAtividades> ListaDeObjetosDePlanoDeAtividades { get; set; }
    }
}