using System;

namespace DesignPatterns.Structural.Proxy.RealSubject
{
    public class Comentario
    {
        public string Texto { get; set; }
        public DateTime Fecha { get; set;  }
        public bool Aprobado { get; set; }

        public Comentario(string texto)
        {
            this.Texto = texto;
            this.Fecha = DateTime.Now;
            this.Aprobado = false;
        }
    }
}
