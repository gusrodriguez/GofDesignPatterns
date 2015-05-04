using DesignPatterns.Estructurales.Proxy.Subject;

namespace DesignPatterns.Estructurales.Proxy.RealSubject
{
    public class Foro: IForo
    {
        public Comentario PostearComentario(string texto)
        {
            return new Comentario("Mi comentario");
        }

        public void AprobarComentario(Comentario comentario)
        {
            comentario.Aprobado = true;            
        }
    }
}
