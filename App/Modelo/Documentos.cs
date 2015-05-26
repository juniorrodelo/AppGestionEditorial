using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Documentos : IPermisos

    {
        #region "Atributos"

        private string codigo;
        private string titulo;
        private string idiomas;
        private string autores;
        private int nPaginas;
        private string editorial;
        private string fechaPulicacion;
        private string fechaEdicion;
        private string categoria;
        List<Formatos> formatos = new List<Formatos>();
        #endregion

        #region "Propiedades"

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Idiomas
        {
            get { return idiomas; }
            set { idiomas = value; }
        }

        public string Autores
        {
            get { return autores; }
            set { autores = value; }
        }

        public int NPaginas
        {
            get { return nPaginas; }
            set { nPaginas = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public string FechaPulicacion
        {
            get { return fechaPulicacion; }
            set { fechaPulicacion = value; }
        }

        public string Genero
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string FechaEdicion
        {
            get { return fechaEdicion; }
            set { fechaEdicion = value; }
        }
        #endregion

        #region "Constructores"
        public Documentos(){
        
        this.codigo = "Yhajkk45";
        this.titulo = "APOII";
        this.idiomas = "Ingles/Español";
        this.autores = "Alfredo Rodelo";
        this.nPaginas = 54;
        this.editorial = "Norma";
        this.fechaPulicacion = "Noviembre 23 ";
        this.fechaEdicion = "Noviembre 23 ";
        this.categoria = "Terro";
        
      }

        public Documentos(string codigo, string titulo, string idiomas, string autores, int pagina, string editorial, string fecha_publicidad, string genero, string fecha_edicion)
        {
        this.codigo = codigo;
        this.titulo = titulo;
        this.idiomas = idiomas;
        this.autores = autores;
        this.nPaginas = pagina;
        this.editorial = editorial;
        this.fechaPulicacion = fecha_publicidad;
        this.fechaEdicion = fecha_edicion;
        this.categoria = genero;
    }
        #endregion

        #region "Métodos SobreEscritos"

        public override string ToString()
        {
            return "\n_______________________________________" +
                    "\nCodigo: " + this.codigo +
                    "\nTitulo: " + this.titulo +
                    "\nIdiomas: " + this.idiomas +
                    "\nAutores: " + this.autores +
                    "\nPaginas: " + this.nPaginas +
                    "\nEditorial: " + this.editorial +
                    "\nFecha de Pulicacion: " + this.fechaPulicacion +
                    "\nFecha de Edicion: " + this.fechaEdicion +
                    "\nCategoria: " + this.categoria +
                    "\n_______________________________________";
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Documentos o = (Documentos)obj;
            bool result = false;

            if ((this.codigo == o.codigo) &&
                (this.titulo == o.titulo) &&
                (this.idiomas == o.idiomas) &&
                (this.autores == o.autores) &&
                (this.nPaginas == o.nPaginas) &&
                (this.editorial == o.editorial) &&
                (this.fechaPulicacion == o.fechaPulicacion) &&
                (this.fechaEdicion == o.fechaEdicion) &&
                (this.categoria == o.categoria))


                result = true;

            return result;
        }

        #endregion

        #region "Métodos de Clase"

        public string listPermisos
        {
            get
            {
                string salida = "";
                foreach (Formatos value in formatos) {
                    if (value.Leer)
                        salida += "Leer,";
                    if (value.Guardar)
                        salida += " Guardar,";
                    if (value.Imprimir)
                        salida += " imprimir,";
                    if (value.Editar)
                        salida += " Editar,";
                    if (value.Escuchar)
                        salida += " Escuchar,";
                    if (value.Visualizar)
                        salida += " Visualizar,";
                }
                   

                return salida;
            }
        }

        public void addFormato(Formatos formato)
        {
            this.formatos.Add(formato);
        }

        public string NFormato
        {
            get
            {
                string salida = "";
                foreach (Formatos value in formatos)
                    salida += value.NombreFormato + ",";

                return salida;
            }
        }
        #endregion

    }
        
        
}