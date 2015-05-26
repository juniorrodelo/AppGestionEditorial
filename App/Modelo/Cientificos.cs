using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Cientificos : Documentos
    {
        #region "Atributos"
        private string tipo;
        #endregion

        #region "Propiedades"
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        #endregion

        #region "Constructores"
        public Cientificos()
            : base()
        {
            this.tipo = "Tema Cientifico";
        }

        public Cientificos(string codigo, string titulo, string idiomas, string autores, int pagina, string editorial, string fecha_publicidad, string genero, string fecha_edicion, string tema) :
            base(codigo, titulo, idiomas, autores, pagina, editorial, fecha_publicidad, genero, fecha_edicion)
        {
            this.tipo = tema;
        }
        #endregion

        #region "Métodos Sobreescritos"
        public override string ToString()
        {
            return base.ToString() + "Tema Cientifico: " + this.tipo;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Cientificos L = (Cientificos)obj;
            bool result = false;

            if (base.Equals(L) && this.tipo == L.tipo)
                result = true;

            return result;
        }
        #endregion
    }
}