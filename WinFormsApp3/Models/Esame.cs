using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Models
{
    public class Esame
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Materia { get; set; }
        public int Voto { get; set; }
        public Docente Docente { get; set; }

        public string GetMateriaEVoto()
        {
            return $"{Materia}: {Voto}";
        }
    }

    public class Docente
    {
        public string  Nome { get; set; }
        public string  Cognome { get; set; }
    }
}
