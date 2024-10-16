﻿using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GrupoF.Prototipo._5.Crear_Remito
{
    public partial class Crearremito_form : Form
    {
        private Datos_model Datos_model = new Datos_model();

        public Crearremito_form(int id = 0)
        {
            InitializeComponent();
            CargarDatos(id);
        }

        private void CargarDatos(int id)
        {
            var orden = Datos_model.OrdenesDePreparacion.Where(x => x.Id_OrdenDePreparacion == id).FirstOrDefault();
            var transpotistas = Datos_model.Transportistas.Where(x => x.Id_Transportista == id).FirstOrDefault();

            if (orden != null)
            {
                var cliente = Datos_model.Clientes.Where(x => x.Id_Cliente == id).FirstOrDefault();
                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == id).FirstOrDefault();

                NombreCliente_textBox.Text = cliente?.NombreApellido ?? "";
                DescripcionMercaderia_textBox.Text = mercaderia?.Descripcion_Mercaderia ?? "";
                CondicionFrenteAlIva_textbox.Text = cliente?.CondIva ?? "";
                CUIT_textBox.Text = cliente?.Cuit.ToString();
                Cantidad_textBox.Text = orden.Cantidad_OrdenDePreparacion.ToString();
                Domicilio_textBox.Text = cliente?.Domicilio ?? "";
                DNI_textBox.Text = transpotistas.Dni_Transportista.ToString();
                NombreApellido_textBox.Text = transpotistas.NombreApellido_Transportista;
            }
        }


        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void Ingresar_button_Click(object sender, EventArgs e)
        {
            string Id_Orden = IngresarIDOP_textBox.Text;

            if (Id_Orden == "")
            {
                MessageBox.Show("Id no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IngresarIDOP_textBox.Focus();
                return;
            }

            if (!Id_Orden.All(char.IsDigit))
            {
                MessageBox.Show("Id debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IngresarIDOP_textBox.Focus();
                return;
            }


            if (!Datos_model.OrdenesDePreparacion.Any(o => o.Id_OrdenDePreparacion == int.Parse(Id_Orden)))
            {
                MessageBox.Show("Debes seleccionar una orden valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IngresarIDOP_textBox.Focus();
                return;
            }

            this.Hide();
            Crearremito_form nuevaForma = new Crearremito_form(int.Parse(Id_Orden));
            nuevaForma.Show();
        }

        private void button_Emitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se creo el remito con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Menu_form nuevaForma = new Menu_form();
            nuevaForma.Show();
        }

        private void CrearOrdenDeEntrega_form_Load(object sender, EventArgs e)
        {

        }
    }
}
