﻿using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
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

namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{
    public partial class CrearOrdenDeSeleccion_form : Form
    {
        private CrearOrdenDeSeleccion_model _ordenesDeSeleccion_model = new CrearOrdenDeSeleccion_model();

        public CrearOrdenDeSeleccion_form()
        {
            InitializeComponent(); 
            CargarOrdenesDePreparacion();
        }

        private void button_Crear_Orden_Click(object sender, EventArgs e)
        {
            string Id_Orden = IdOrden_textBox.Text.Trim();

            if(Id_Orden == "")
            {
                MessageBox.Show("Id no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrden_textBox.Focus();
                return;
            }

            if (!Id_Orden.All(char.IsDigit))
            {
                MessageBox.Show("Id debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrden_textBox.Focus();
                return;
            }

            if (!_ordenesDeSeleccion_model.OrdenesDePreparacion.Any(o => o.Id_OrdenDePreparacion == int.Parse(Id_Orden)))
            {
                MessageBox.Show("Debes seleccionar una orden valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrden_textBox.Focus();
                return;
            }

            MessageBox.Show("Se creo la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Menu_form nuevaForma = new Menu_form();
            nuevaForma.Show();
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }
    }
}
