using System.Collections.Generic;

using DesignPatterns.Behavioral.Command.Receptor;

namespace DesignPatterns.Behavioral.Command.Invocador
{
    public class Menu
    {
        ContenedorTexto receptor;

        Stack<Comando> comandosEjecutados;

        public Menu(ContenedorTexto contenedorTexto)
        {
            receptor = contenedorTexto;

            comandosEjecutados = new Stack<Comando>();            
        }

        //El invocador es el que fabrica el comando concreto
        public string EjecutarOpcion(Opciones opcion)
        {
            string resultado = string.Empty;

            Comando comando = null;

            switch (opcion)
            {
                case Opciones.Copiar:
                    comando = new ComandoCopiar(this.receptor);
                    break;
                case Opciones.Cortar:
                    comando = new ComandoCortar(this.receptor);
                    break;
                case Opciones.Pegar:
                    comando = new ComandoPegar(this.receptor);
                    break;
            }

            //El comando es tratado indistintamente
            resultado = comando.Ejecutar();

            //Se agrega la pila de comandos ejecutados para poder hacer Undo
            comandosEjecutados.Push(comando);

            return resultado;
        }

        /// <summary>
        /// Recorre la lista de comandos ejecutados y los vuelte a ejecutar hacia atrás
        /// </summary>
        public string Deshacer()
        {
            Comando ultimoComando;

            if (comandosEjecutados.Count > 0)
            {
                ultimoComando = comandosEjecutados.Pop();

                ultimoComando.Deshacer();
            }

            return receptor.Texto;
        }
    }
}
