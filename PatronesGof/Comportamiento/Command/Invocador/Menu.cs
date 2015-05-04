using System.Collections.Generic;
using DesignPatterns.Behavioral.Command;

namespace DesignPatterns.Comportamiento.Command.Invocador
{
    //Invocador
    public class Menu
    {
        Stack<Comando> comandosEjecutados;

        public Menu()
        {
            comandosEjecutados = new Stack<Comando>();            
        }

        public void Ejecutar(Comando comando)
        {
            comando.Ejecutar();

            //Se agrega a la pila de comandos ejecutados para poder hacer Deshacer() del último
            comandosEjecutados.Push(comando);
        }

        /// <summary>
        /// Recorre la lista de comandos ejecutados y ejecuta Deshacer() para el último ejecutado
        /// </summary>
        public void Deshacer()
        {
            Comando ultimoComando;

            if (comandosEjecutados.Count > 0)
            {
                ultimoComando = comandosEjecutados.Pop();

                ultimoComando.Deshacer();
            }
        }
    }
}
