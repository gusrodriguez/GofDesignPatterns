using System;
using DesignPatterns.Estructurales.Bridge.Implementador;

namespace DesignPatterns.Structural.Bridge
{
    public class ReproductorVideoImplementador: ReproductorMultimediaImplementador
    {      
        public override string IniciarControlador()
        {
            return "Iniciando controlador de video...";
        }

        public override string IniciarResolucion()
        {
            return "Iniciando resolución de pantalla...";
        }

        public override string Reproducir()
        {
            //Representa la lógica real del método
            string resultado = string.Empty;
            
            resultado += IniciarControlador();
            resultado += Environment.NewLine;
            resultado += IniciarResolucion();
            resultado += Environment.NewLine;
                       
            resultado += "Reproduciendo Video...";                
            
            return resultado;
        }
    }
}
