using System;

using DesignPatterns.Structural.Bridge.Implementador;

namespace DesignPatterns.Structural.Bridge
{
    public class ReproductorVideoImplementadorMejorado: ReproductorMultimediaImplementador
    {
        public override string IniciarControlador()
        {
            return "Iniciando controlador de video en HD...";
        }

        public override string IniciarResolucion()
        {
            return "Iniciando resolución de pantalla en HD...";
        }

        public override string Reproducir()
        {
            string resultado = string.Empty;
            
            //Reprresenta la lógica real del método
            resultado += IniciarControlador();
            resultado += Environment.NewLine;
            resultado += IniciarResolucion();
            resultado += Environment.NewLine;
                       
            resultado += "Reproduciendo video en HD...";           

            return resultado;
        }
    }



}
