using System;

namespace DesignPatterns.Structural.Decorator.Componente
{
    public abstract class Personaje
    {
        public virtual string EjecutarHabilidad()
        {
            throw new Exception("No implementado");
        }
    }
}
