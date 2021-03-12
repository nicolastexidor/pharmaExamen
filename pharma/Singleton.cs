using System;

namespace Library
{
    /// <summary>
    /// El patrón singleton, en este caso genérico, permite que una única instancia de la clase deseada sea creada.
    /// En este caso esta clase serviria para que solo exista una instancia de cliente ya que no es necesario que haya mas de una instancia y puede generar problemas si lo hubiese
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> where T : new ()
    {
        private static T instance;

        private Singleton() { }

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }

    }
}