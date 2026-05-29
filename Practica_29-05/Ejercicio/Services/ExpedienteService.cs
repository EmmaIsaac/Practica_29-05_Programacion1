using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Services
{
    internal class ExpedienteService
    {
        private string[] nombres;
        private string[] DNI;
        private double[] montos;
        private int contadorIntegrados;

        public ExpedienteService() 
        {
            nombres = new string[100];
            DNI = new string[100];
            montos = new double[100];
            contadorIntegrados = 0;
        }

        public void RegistrarExpediente(string nombre, string dni, double monto) 
        {

        }
    }
}
