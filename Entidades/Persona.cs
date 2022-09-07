using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private int dni;
        private DateTime fechaNacimiento;
        public Persona()
        {
        }
        public Persona(string Nombre, int DNI, DateTime FechaNacimiento)
        {
            this.nombre = Nombre;
            this.dni = DNI;
            this.fechaNacimiento = FechaNacimiento;
        }

        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public int DNI
        {
            set { this.dni = value; }
            get { return this.dni; }
        }

        public DateTime FechaNacimiento
        {
            set { this.fechaNacimiento = value; }
            get { return this.fechaNacimiento; }
        }

        public double DevolucionEdad()
        {
            TimeSpan TiempoDiferencia = DateTime.Now.Subtract(this.FechaNacimiento);

            double años = Math.Floor(TiempoDiferencia.TotalDays / 365);

            return años;
        }
    }
}
