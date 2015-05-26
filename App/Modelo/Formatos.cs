using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Formatos
    {
        #region "Atributos"
        private string codigo;
        private string nombreFormato;
        private bool leer;
        private bool guardar;
        private bool imprimir;
        private bool editar;
        private bool escuchar;
        private bool visualizar;
        #endregion

        #region "Propiedades"
        public string NombreFormato
        {
            get { return nombreFormato; }
            set { nombreFormato = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public bool Leer
        {
            get { return leer; }
            set { leer = value; }
        }

        public bool Guardar
        {
            get { return guardar; }
            set { guardar = value; }
        }

        public bool Imprimir
        {
            get { return imprimir; }
            set { imprimir = value; }
        }

        public bool Editar
        {
            get { return editar; }
            set { editar = value; }
        }

        public bool Escuchar
        {
            get { return escuchar; }
            set { escuchar = value; }
        }

        public bool Visualizar
        {
            get { return visualizar; }
            set { visualizar = value; }
        }
        #endregion

        #region "construsctores"
        public Formatos()
        {
            this.codigo = "ISBN";
            this.nombreFormato = "Sin formatos";
            this.leer = false;
            this.guardar = false;
            this.imprimir = false;
            this.editar = false;
            this.escuchar = false;
            this.visualizar = false;
        }

        public Formatos(string codigo, string nombre, bool leer, bool guardar, bool imprimir, bool editar, bool escuchar, bool visualizar)
        {
            this.codigo = codigo;
            this.nombreFormato = nombre;
            this.leer = leer;
            this.guardar = guardar;
            this.imprimir = imprimir;
            this.editar = editar;
            this.escuchar = escuchar;
            this.visualizar = visualizar;

        }
        #endregion

        #region "Métodods SobreEscritos"

        public override string ToString()
        {
            return  "\nCodigo: " + this.codigo +
                    "\nFormato: " + this.nombreFormato +
                    "\nPermiso Leer: " + this.leer +
                    "\nPermiso guardar: " + this.guardar +
                    "\nPermiso imprimir: " + this.imprimir +
                    "\nPermiso editar: " + this.editar +
                    "\nPermiso escuchar: " + this.escuchar +
                    "\nPermiso visualizar: " + this.visualizar;
        }
        #endregion

    }
}