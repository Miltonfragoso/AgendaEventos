using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.WebAPI.Model
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public String Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lot { get; set; }
    }
}