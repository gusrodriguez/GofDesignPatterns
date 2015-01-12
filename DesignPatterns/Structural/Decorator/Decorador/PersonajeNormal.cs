using DesignPatterns.Structural.Decorator.Componente;

namespace DesignPatterns.Structural.Decorator.Decorador
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
