using DesignPatterns.Estructurales.Decorator.Componente;

namespace DesignPatterns.Estructurales.Decorator.Decorador
{
    public class PersonajeNormal: Personaje
    {
        public override string EjecutarHabilidad()
        { 
            //Un personaje normal puede solamente caminar
            return "Caminar";
        }      
    }
}
