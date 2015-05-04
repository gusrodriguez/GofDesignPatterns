using System;

namespace DesignPatterns.Estructurales.Decorator.Componente
{
    public abstract class Personaje
    {
        public virtual string EjecutarHabilidad()
        {
            throw new Exception("No implementado");
        }
    }
}
