using System;

namespace vehiculos
{
    class Program
    {
        class Vehiculo
        {
            private string _Marca;
            public string Marca
            {
                get { return _Marca; }
                set { _Marca = value; }
            }
            private string _Modelo;
            public string Modelo
            {
                get { return _Modelo; }
                set { _Modelo = value; }
            }
            private int _Año;
            public int Año
            {
                get { return _Año; }
                set { _Año = value; }
            }

            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAño: {Año}");
            }
        }

        class Bicicleta : Vehiculo 
        {
            private int _NumeroMarchas; 
            public int NumeroMarchas
            {
                get { return _NumeroMarchas; }
                set { _NumeroMarchas = value; }
            }

            public Bicicleta(string marca, string modelo, int año, int numeroMarchas) : base(marca, modelo, año)
            {
                NumeroMarchas = numeroMarchas;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Bicicleta \nmarchas: {NumeroMarchas}");
            }
        }

        class Avion : Vehiculo
        {
            private string _TipoMotor;
            public string TipoMotor
            {
                get { return _TipoMotor; }
                set { _TipoMotor = value; }
            }

            private int _CapacidadPasajeros; 
            public int CapacidadPasajeros
            {
                get { return _CapacidadPasajeros; }
                set { _CapacidadPasajeros = value; }
            }

            public Avion(string marca, string modelo, int año, string tipoMotor, int capacidadPasajeros) : base(marca, modelo, año)
            {
                TipoMotor = tipoMotor;
                CapacidadPasajeros = capacidadPasajeros;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Avión \nTipo de motor: {TipoMotor} \nCapacidad de pasajeros: {CapacidadPasajeros}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------VEHICULOS--------");
            Vehiculo vehi = new Vehiculo("Toyota", "Corolla", 2020); 
            Vehiculo vehi2 = new Vehiculo("chery", "tigo 8", 2022); 
            vehi.MostrarInformacion();
            Console.WriteLine("-----------------");
            vehi2.MostrarInformacion();
            Bicicleta bic = new Bicicleta("BMX", "Gorila", 2024, 1); 
            Console.WriteLine("-----------------");
            bic.MostrarInformacion();
            Console.WriteLine("-----------------");
            Console.WriteLine("--------AVION---------");
            Avion avi = new Avion("Boeing", "747-8", 2022, "Turbofan CFM56-7B", 500); 
            avi.MostrarInformacion();
        }
    }
}

