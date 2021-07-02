namespace MyFirstApp.Interfaces
{
    interface IVehiculo
    {
        void Acelerar(int km);
        void Frenar();
        void Girar(int angulos);
        void Despegar();
        void Aterrizar();
    }
}
