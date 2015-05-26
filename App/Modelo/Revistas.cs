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
        #endregion

        #region "Propiedades"
        public int Volumen
        {
            get { return volumen; }
            set { volumen = value; }
        }
        #endregion

        #region "Constructores"

        public Revistas()
            : base()
        {
            this.volumen = 5;
        }

        public Revistas(string codigo, string titulo, string idiomas, string autores, int pagina, string editorial, string fecha_publicidad, string genero, string fecha_edicion, int volumen) :
            base(codigo, titulo, idiomas, autores, pagina, editorial, fecha_publicidad, genero, fecha_edicion)
        {
            this.volumen = volumen;
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