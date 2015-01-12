using System;

using DesignPatterns.Structural.Proxy.RealSubject;
using DesignPatterns.Structural.Proxy.Subject;

namespace DesignPatterns.Structural.Proxy.Proxy
{
    public class ProxyForo: IForo
    {
        public Comentario PostearComentario(string texto)
        {
            return new Comentario("Mi comentario");
        }

        /// <summary>
        /// El Proxy proporciona la misma interfaz que el objeto real pero puede incluir funcionalidades extras, como por ejemplo restringir permisos.
        /// </summary>
        public void AprobarComentario(Comentario comentario)
        {
            if (this.UsuarioAutenticado())
            {
                comentario.Aprobado = true;
            }
            else
            {
                throw new Exception("El usuario no tiene permisos para aprobar un comentario");
            }
        }

        private bool UsuarioAutenticado()
        {
            return false;
        }
    }
}
