namespace DesignPatterns.Structural.Proxy.RealSubject
{
    using DesignPatterns.Structural.Proxy.Subject;

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
