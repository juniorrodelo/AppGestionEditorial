﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Modelo;
using App.Datos;

namespace App.Web
{
    public partial class Crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Clientes p = new Clientes(
                                        txtId.Text, 
                                        txtNombres.Text,
                                        txtApellidos.Text,
                                        txtEmail.Text,
                                        txtTelefono.Text
                                       );

            ClientesRepositories data = new ClientesRepositories();

            data.add(p);
          

        }
    }
}