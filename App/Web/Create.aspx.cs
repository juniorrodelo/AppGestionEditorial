using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Modelo;
using App.Datos;

namespace App.Web
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string nFormato = formatodoc.SelectedItem.Value;

            Formatos formato = new Formatos("000", nFormato, chLeer.Checked, chGuardar.Checked, chImprimir.Checked,
                chEditar.Checked, chEscuchar.Checked, chVisualizar.Checked);


            Documentos p = new Documentos(
                                        txtCodigo.Text,
                                        txtTitulo.Text,
                                        txtIdiomas.Text,
                                        txtAutores.Text,
                                        int.Parse(txtNpaginas.Text),
                                        txtEditorial.Text,
                                        txtFechaP.Text,
                                        txtGenero.Text,
                                        txtFechaP.Text
                                       );

            p.addFormato(formato);

            DocumentosRepositories data = new DocumentosRepositories();

            data.add(p);


        }
    }
}