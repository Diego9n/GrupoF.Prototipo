﻿using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;


namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{
    public partial class CrearOrdenDeSeleccion_form : Form
    {
        private Datos_model Datos_model = new Datos_model();

        public CrearOrdenDeSeleccion_form()
        {
            var listview = Datos_model.OrdenesDePreparacion.Where(x => x.Id_EstadoOP == 2).ToList();

            InitializeComponent();
            CargarOrdenesDePreparacion(listview);
        }

        private void button_Crear_Orden_Click(object sender, EventArgs e)
        {
            var items = Items_OS_listView2.Items.Count;

            if(items < 1)
            {
                MessageBox.Show("Seleccione al menos 1 item para la orden de seleccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Items_OS_listView2.Focus();
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

        private void Agregar_button1_Click(object sender, EventArgs e)
        {
            int cantidad = Items_OS_listView2.Items.Count;

            var i = 1;

            foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
            {
                if (item.Checked)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {

                        item.SubItems[0].Text, //1
                        item.SubItems[3].Text,//2


                        item.SubItems[1].Text, //3
                        item.SubItems[2].Text, //4

                    }, -1);

                    Items_OS_listView2.Items.Add(listViewItem);

                    OrdenesDePreparacion_ListView.Items.Remove(item);

                    i++;
                }
            }
        }

        private void Remover_button_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Items_OS_listView2.Items)
            {
                if (item.Checked)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {

                        item.SubItems[0].Text, //0
                        item.SubItems[2].Text, //1
                        item.SubItems[3].Text, //2
                        item.SubItems[1].Text, //3

                    }, -1);

                    OrdenesDePreparacion_ListView.Items.Add(listViewItem);

                    Items_OS_listView2.Items.Remove(item);
                }
            }
        }

        private void Ver_button_Click(object sender, EventArgs e)
        {
            var cantidad = 0;

            foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
            {
                if (item.Checked)
                {
                    cantidad++;
                }
            }

            if (cantidad < 1)
            {
                MessageBox.Show("Debe seleccionar una Orden de preparacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cantidad > 1)
            {
                MessageBox.Show("No debe seleccionar mas de una Orden de preparacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
                {
                    if (item.Checked)
                    {
                        CargarItemsOrdenesDePreparacion(int.Parse(item.SubItems[0].Text));
                        break;
                    }
                }             
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var listview = Datos_model.OrdenesDePreparacion.Where(x => x.Id_EstadoOP == 2).ToList();

            if (comboBox1.SelectedIndex == 1)
            {
                listview = listview.OrderBy(x => x.Id_OrdenDePreparacion).ToList();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                listview = listview.OrderByDescending(x => x.Prioridad_OrdenDePreparacion).ToList();
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                listview = listview.OrderBy(x => x.Emision_OrdenDePreparacion).ToList();
            }

            if (comboBox1.SelectedIndex == 4)
            {
                var nombres = new List<(string, string, string, string)>();

                foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
                {
                    var nombre = item.SubItems[3].Text;

                    nombres.Add((item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text));
                }

                nombres = nombres.OrderBy(nombre => nombre.Item4).ToList();

                OrdenesDePreparacion_ListView.Items.Clear();

                foreach (var orden in nombres)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {

                        orden.Item1.ToString(),
                        orden.Item2.ToString(),
                        orden.Item3.ToString(),
                        orden.Item4.ToString(),

                }, -1);

                    OrdenesDePreparacion_ListView.Items.Add(listViewItem);
                }
            }

            if (comboBox1.SelectedIndex != 4)
            {
                CargarOrdenesDePreparacion(listview);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
