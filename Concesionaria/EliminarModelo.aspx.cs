﻿using Servicio;
using System;

namespace Concesionaria
{
    public partial class EliminarModelo : System.Web.UI.Page
    {
        ModeloService ServicioModelo = new ModeloService();

        int ModeloID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            errorContenedor.Visible = false;

            if (!IsPostBack)
            {
                if (obtenerModeloID())
                {
                    var Modelo = ServicioModelo.ObtenerPorID(ModeloID);
                    lblMensaje.Text = "¿Está seguro que desea eliminar el modelo " + Modelo.Nombre + " ?";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerModeloID();

            try
            {
                ServicioModelo.Eliminar(ModeloID);
                Response.Redirect("Modelos.aspx");
            }
            catch (Exception)
            {
                errorContenedor.Visible = true;
                lblMensajeError.Text = "El modelo seleccionado no puede ser eliminado debido a que se encuentra relacionado a un elemento existente.";
            }            
        }

        private bool obtenerModeloID()
        {
            return int.TryParse(Request.QueryString["modeloid"], out ModeloID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modelos.aspx");
        }
    }
}