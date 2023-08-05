using System;
using Serie_II.interfaces;

namespace Serie_II.Implementaciones
{
	public class Bicicleta : IVehiculo
	{
		public Bicicleta()
		{
		}

        public void detener()
        {
            Task.Delay(1000);
            Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId} - Detener Bicicleta");
        }

        public void iniciar()
        {
            Task.Delay(1100);
            Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId} - Iniciar Bicicleta");
        }
    }
}

