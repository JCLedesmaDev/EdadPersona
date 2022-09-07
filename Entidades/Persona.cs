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
            set { nombre = value; }
            get { return nombre; }
        }
        public int DNI
        {
            set { dni = value; }
            get { return dni; }
        }

        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public double DevolucionEdad()
        {
            TimeSpan TiempoDiferencia = DateTime.Now.Subtract(FechaNacimiento);

            double años = Math.Floor(TiempoDiferencia.TotalDays / 365);

            return años;
        }
    }
}
