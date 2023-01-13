using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPExcepcion
{
    public class Alumno
    {
        private string nombre { get; set; }
     
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("Un nombre no puede tener solo un caracter.");
                }
                else if (value.Trim().Length > 50)
                {
                    throw new ArgumentException("El nombre debe tener entre 1 y 50 caracteres.");
                }

                nombre = value;
            }


        }
        public Alumno(string Nombre)
        {
            this.Nombre = Nombre;
        }

    }
}
