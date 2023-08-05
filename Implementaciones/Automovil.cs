using System;
using Serie_II.interfaces;

namespace Serie_II.Implementaciones
{
	public class Automovil : IVehiculo
	{
		public Automovil()
		{
		}

        public void detener()
        {
            Task.Delay(4000);
            Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId} - Detener Automovil");
        }

        public void iniciar()
        {
            Task.Delay(2000);
            Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId} - Iniciar Automovil");
        }
    }
}

