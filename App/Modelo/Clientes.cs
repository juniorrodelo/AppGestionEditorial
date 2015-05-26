using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Clientes
    {
        #region "Atributos"
        private string id;
        private string nombres;
        private string apellidos;
        private string email;
        private string telefono;
        #endregion

        #region "Propiedades"
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        #endregion

        #region "Constructores"
        public Clientes()
        {
            this.id = "XXXXXX";
            this.nombres = "Nombres";
            this.apellidos = "Apellidos";
            this.email = "eamilpersonal@dominio.com";
            this.telefono = "3001234567";
        }


        public Clientes(string id, string nombres, string apellidos, string email, string telefono)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "\n_______________________________________" +
                    "\nIdentificacion: " + this.id +
                    "\nNombres: " + this.nombres +
                    "\nApellidos: " + this.apellidos +
                    "\nEmail P: " + this.email +
                    "\nTelefono W: " + this.telefono +
                    "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Clientes o = (Clientes)obj;
            bool result = false;

            if ((this.id == o.id) &&
                (this.nombres == o.nombres) &&
                (this.apellidos == o.apellidos) &&
                (this.email == o.email) &&
                (this.telefono == o.telefono))

                result = true;

            return result;
        }

        #endregion
    }
}