using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra6Assents_JozefMA.Models
{
    internal class AskPost
    {

        public long PreguntaID { get; set; }

        public DateTime Fecha { get; set; }

        public string Pregunta { get; set; } = null!;

        public int IdUsuario { get; set; }

        public int IDEstadoPregunta { get; set; }

        public bool? EsHuelga { get; set; }

        public string? URLImagen { get; set; }

        public string? PreguntarDetalles { get; set; }

    }
}
