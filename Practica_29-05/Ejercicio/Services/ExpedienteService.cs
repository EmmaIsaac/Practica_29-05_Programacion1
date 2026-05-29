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
            if (contadorIntegrados<100 && contadorIntegrados>=0 )
            {
                nombres[contadorIntegrados] = nombre;
                DNI[contadorIntegrados]= dni;
                montos[contadorIntegrados]= monto;
            }
            contadorIntegrados++;
        }

        public double CalcularTotal() 
        {
            double total = 0;   
            for (int i = 0; i < contadorIntegrados; i++) 
            {
                total += montos[i];
            }
            return total;
        }

        public double VerMayor() 
        {
            double mayor = 0;

            for (int i = 0; i < contadorIntegrados; i++)
            {
                if (mayor < montos[i])
                {
                    mayor = montos[i];
                }
            }
            return mayor;
        }

        public int VerCantidadIntegrados() 
        {
            return contadorIntegrados;
        }

        //Tp tutorias 
        //https://docs.google.com/document/d/1S9Pg6wytZ_ehAv6qIRk0aTdE-4tgkOoz/edit
    }
}
