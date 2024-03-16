using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Empleado:Usuario
    {
        public double Sueldo {  get; set; }
        public Empleado(string nombre, double saldo, double sueldo):base(nombre, saldo)
        {
            Sueldo = sueldo;
        }
        public virtual void MostrarInformacion() 
        {
            Console.WriteLine(Sueldo);
        }
    }
}
