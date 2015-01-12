using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class Email: Mensaje
    {
        public override string EncenderDispositivo()
        {
            return "Prendiendo la computadora...";
        }

        public override string EscribirMensaje()
        {
            return "Escribiendo el mensaje...";
        }

        public override string EnviarMensaje()
        {
            return "Clickeando en el botón 'Send'...";
        }
    }
}
