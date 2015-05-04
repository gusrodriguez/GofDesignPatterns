using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class SeñalDeHumo: Mensaje
    {
        public override string EncenderDispositivo()
        {
            return "Prendiendo el fuego...";
        }

        public override string EscribirMensaje()
        {
            return "Poniendo la manta sobre el fuego...";
        }

        public override string EnviarMensaje()
        {
            return "Sacando la manta del fuego...";
        }
    }
}
