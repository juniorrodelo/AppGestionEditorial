using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Factura
    {
        #region "Atributos"
        private int id;
        private string fecha;
        private List<Libros> items = new List<Libros>();
        private string socursal;
        private string estado;
        #endregion

        #region "Propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public List<Libros> Items
        {
            get { return items; }
            set { items = value; }
        }

        public string Socursal
        {
            get { return socursal; }
            set { socursal = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion

        #region "Constructores"
        public Factura()
        {
            this.id = 00;
            this.fecha = "si fecha";
            this.socursal = "Apellidos";
            this.estado = "eamilpersonal@dominio.com";

        }


        public Factura(int id, string fecha, string socursal, string estado)
        {
            this.id = id;
            this.fecha = fecha;
            this.socursal = socursal;
            this.estado = estado;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "\n_______________________________________" +
                    "\nNumero de Factura: " + this.id +
                    "\nFecha: " + this.fecha +
                    "\nSocursal: " + this.socursal +
                    "\nEstado: " + this.estado +
                    "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Factura o = (Factura)obj;
            bool result = false;

            if ((this.id == o.id) &&
                (this.fecha == o.fecha) &&
                (this.socursal == o.socursal) &&
                (this.estado == o.estado))

                result = true;

            return result;
        }

        #endregion
    }
}