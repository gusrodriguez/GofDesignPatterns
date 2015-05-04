using DesignPatterns.Estructurales.Proxy.RealSubject;

namespace DesignPatterns.Estructurales.Proxy.Subject
{
    public interface IForo
    {
        Comentario PostearComentario(string texto);

        void AprobarComentario(Comentario comentario);
    }
}
