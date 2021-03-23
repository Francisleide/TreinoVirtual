using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinoVirtual.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public string Objetivo { get; set; }
        public int TurmaId { get; set; }
        public virtual Turma Turma { get; set; }

    }
}