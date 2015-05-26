using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Libros : Documentos 
    {
        #region "Atributos"

        private int capitulos;
        private int tomos;
        private string nivel;

        #endregion

        #region "Propiedades"

        public int Capitulos
        {
            get { return capitulos; }
            set { capitulos = value; }
        }

        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public int Tomos
        {
            get { return tomos; }
            set { tomos = value; }
        }
        #endregion

        #region "Constructores"
        public Libros()
            : base()
        {
            this.capitulos = 5;
            this.tomos = 5;
            this.nivel = "";
        }

        public Libros(string codigo, string titulo, string idiomas, string autores, int pagina, string editorial, string fecha_publicidad, string genero, string fecha_edicion, int capitulos, int tomos, string nivel) :
            base(codigo, titulo, idiomas, autores, pagina, editorial, fecha_publicidad, genero, fecha_edicion)
        {
            this.capitulos = capitulos;
            this.nivel = nivel;
            this.tomos = tomos;
        }
        #endregion

        #region "Metodos Sobreescritos"

        public override string ToString()
        {
            return base.ToString() + "Capitulos: " + this.capitulos + "\nNivel W: " + this.nivel ;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Libros L = (Libros)obj;
            bool result = false;

            if (base.Equals(L) && this.capitulos == L.capitulos && this.nivel == L.nivel)
                result = true;

            return result;
        }
        #endregion

        #region "Métodos de Clase"

        #endregion
    }
} 