using DesignPatterns.Structural.Proxy.RealSubject;

namespace DesignPatterns.Structural.Proxy.Subject
{
    public interface IForo
    {
        Comentario PostearComentario(string texto);

        void AprobarComentario(Comentario comentario);
    }
}
