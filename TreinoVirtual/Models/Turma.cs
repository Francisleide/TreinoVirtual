using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinoVirtual.Models
{
    public class Turma
    {
        public Turma()
        {
            QuantParticipantes = 0;
        }
        public int TurmaId { get; set; }
        public string Nome { get; set; }
        public string Horario { get; set; }
        public int QuantParticipantes { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}