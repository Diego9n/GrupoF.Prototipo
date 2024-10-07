﻿using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    public partial class CrearOrdenDePreparacion_form : Form
    {
        public CrearOrdenDePreparacion_form()
        {
            InitializeComponent();
            CargarDepositos();
            CargarMercaderias();
        }


        private void button_aceptar_click(object sender, EventArgs e)
        {
            string Id_Cliente = TextBox_Id_Cliente.Text.Trim();
            string Cantidad = TextBox_Cantidad.Text.Trim();
            string NombreApellido = TextBox_NombreApellido.Text.Trim();
            string Dni = TextBox_Dni.Text.Trim();

            string? depositoSeleccionado = ComboBox_Descripcion_Deposito.SelectedItem?.ToString();
            string? mercaderiaSeleccionada = ComboBox_Descripcion_Mercaderia.SelectedItem?.ToString();


            if (depositoSeleccionado == "---")
            {
                MessageBox.Show("Debes seleccionar un depósito valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboBox_Descripcion_Deposito.Focus();
                return;
            }


            if (mercaderiaSeleccionada == "---")
            {
                MessageBox.Show("Debes seleccionar una mercadería valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboBox_Descripcion_Mercaderia.Focus();
                return;
            }


            if (string.IsNullOrEmpty(Cantidad))
            {
                MessageBox.Show("El campo Cantidad no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Cantidad.Focus();
                return;
            }

            if (!Cantidad.All(char.IsDigit))
            {
                MessageBox.Show("El campo Cantidad solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Cantidad.Focus();
                return;
            }


            int dni;

            if (!int.TryParse(Dni, out dni))
            {
                MessageBox.Show("El campo Dni debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Cantidad.Focus();
                return;
            }

            if (Dni.Length != 8)
            {
                MessageBox.Show("El campo Dni debe ser tener 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Cantidad.Focus();
                return;
            }

            if (!Dni.All(char.IsDigit))
            {
                MessageBox.Show("El campo Dni solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Cantidad.Focus();
                return;
            }

            if (!Cantidad.All(char.IsDigit))
            {
                MessageBox.Show("El campo Cantidad debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Cantidad.Focus();
                return;
            }

            if (string.IsNullOrEmpty(NombreApellido))
            {
                MessageBox.Show("El campo Nombre y Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_NombreApellido.Focus();
                return;
            }

            if (NombreApellido.Any(char.IsDigit))
            {
                MessageBox.Show("El campo Nombre y Apellido no puede contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Cantidad.Focus();
                return;
            }

            if (string.IsNullOrEmpty(NombreApellido))
            {
                MessageBox.Show("El campo Nombre y Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_NombreApellido.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Dni))
            {
                MessageBox.Show("El campo Dni no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Dni.Focus();
                return;
            }


            MessageBox.Show("Se creo la orden de preparacion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Menu_form nuevaForma = new Menu_form();
            nuevaForma.Show();

        }

        private void button_salir_click(object sender, EventArgs e)
        {
            

        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }
    }
}
