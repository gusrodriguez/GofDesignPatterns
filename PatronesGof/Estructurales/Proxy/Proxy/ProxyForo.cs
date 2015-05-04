using System;
using DesignPatterns.Estructurales.Proxy.RealSubject;
using DesignPatterns.Estructurales.Proxy.Subject;

namespace DesignPatterns.Estructurales.Proxy.Proxy
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
