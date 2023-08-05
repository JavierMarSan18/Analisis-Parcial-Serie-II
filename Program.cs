using Serie_II.Implementaciones;
using Serie_II.interfaces;

IVehiculo automovil = new Automovil();
IVehiculo bicicleta = new Bicicleta();

Thread iniciarAutomovilThread = new Thread(automovil.iniciar);
Thread detenerAutomovilThread = new Thread(automovil.detener);

Thread iniciarBicicletaThread = new Thread(bicicleta.iniciar);
Thread detenerBicicletaThread = new Thread(bicicleta.detener);


iniciarAutomovilThread.Start();
detenerAutomovilThread.Start();

iniciarBicicletaThread.Start();
detenerBicicletaThread.Start();
