using System.Collections;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Mensaje
    {
        //Método plantilla
        public ArrayList Enviar()
        {
            ArrayList pasos = new ArrayList();
            
            pasos.Add(EncenderDispositivo());
            pasos.Add(EscribirMensaje());
            pasos.Add(EnviarMensaje());

            return pasos;        
        }

        //Algoritmo en común
        public abstract string EncenderDispositivo();
        public abstract string EscribirMensaje();
        public abstract string EnviarMensaje();
    }
}
