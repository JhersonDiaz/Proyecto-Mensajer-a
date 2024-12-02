using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proycto_Mensajeria.Clases
{
    public class Cola<T>
    {
        private int capacidadMaxima;
        private Queue<T> cola = new Queue<T>();
        private object lockObject = new object();

        public Cola(int capaciadad)
        {
            capacidadMaxima = capaciadad;
        }
        public void Agregar(T item)
        {
            lock (lockObject)//Bloqueó
            {
                while (cola.Count >= capacidadMaxima)
                {
                    Monitor.Wait(lockObject);
                }
                cola.Enqueue(item);//añade un elemento a su cola
                Monitor.Pulse(lockObject);
            }
        }

        public T Extraer()
        {
            lock (lockObject) //Bloqueó
            {
                while (cola.Count == 0)
                {
                    Monitor.Wait(lockObject);
                }
                T item = cola.Dequeue();
                Monitor.Pulse(lockObject);
                return item;
            }
        }
    }
}
