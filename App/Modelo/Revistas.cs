using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Revistas : Documentos
    {
        #region "Atributos"
        private int volumen;
        private int articulos;
        #endregion

        #region "Propiedades"
        public int Volumen
        {
            get { return volumen; }
            set { volumen = value; }
        }

        public int Articulos
        {
            get { return articulos; }
            set { articulos = value; }
        }
        #endregion

        #region "Constructores"

        public Revistas()
            : base()
        {
            this.volumen = 5;
            this.articulos = 5;
        }

        public Revistas(string codigo, string titulo, string idiomas, string autores, int pagina, string editorial, string fecha_publicidad, string genero, string fecha_edicion, int volumen, int articulos) :
            base(codigo, titulo, idiomas, autores, pagina, editorial, fecha_publicidad, genero, fecha_edicion)
        {
            this.volumen = volumen;
            this.articulos = articulos;
        }

        #endregion

        #region "Métodos Sobreescritos"
        public override string ToString()
        {
            return base.ToString() + "Volumen: " + this.volumen;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Revistas L = (Revistas)obj;
            bool result = false;

            if (base.Equals(L) && this.volumen == L.volumen)
                result = true;

            return result;
        }
        #endregion
    }
}