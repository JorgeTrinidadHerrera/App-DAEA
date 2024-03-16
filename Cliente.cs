using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cliente: Usuario
    {
        public double LitrosCargados {  get; set; }
        
        public Cliente(string nombre, double saldo, double litroscargados):base(nombre,saldo)
        {
            LitrosCargados = litroscargados;
        }
        public  void MostrarInformacion()
        {
            Console.WriteLine(LitrosCargados);
        }
    }
}