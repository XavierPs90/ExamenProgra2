using System;

namespace ExamenPractico2.Clases
{
    class Paciente
    {
        private String cedula, nombre, edad, riesgo;
        
        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Riesgo
        {
            get { return riesgo; }
            set { riesgo = value; }
        }
    }
}
