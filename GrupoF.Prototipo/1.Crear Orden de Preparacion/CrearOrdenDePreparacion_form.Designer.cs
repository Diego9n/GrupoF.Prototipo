﻿namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    partial class CrearOrdenDePreparacion_form
    {
        private CrearOrdnesDePreparacion_model CrearOrdnesDePreparacion_model = new CrearOrdnesDePreparacion_model();

        private void CargarDepositos()
        {
            // Limpiamos el ComboBox por si ya tiene elementos cargados
            DescripcionDeposito_Combobox.Items.Clear();

            // Iteramos sobre la lista de depósitos y agregamos los nombres al ComboBox
            foreach (var deposito in CrearOrdnesDePreparacion_model.Depositos)
            {
                DescripcionDeposito_Combobox.Items.Add(deposito.Nombre_Deposito);
            }

            // Si lo deseas, puedes seleccionar el primer elemento como predeterminado
            if (DescripcionDeposito_Combobox.Items.Count > 0)
            {
                DescripcionDeposito_Combobox.SelectedIndex = 0;
            }
        }

        private void CargarMercaderias()
        {
            // Limpiamos el ComboBox por si ya tiene elementos cargados
            DescripcionMercaderia_ComboBox.Items.Clear();

            // Iteramos sobre la lista de depósitos y agregamos los nombres al ComboBox
            foreach (var mercaderia in CrearOrdnesDePreparacion_model.Mercaderias)
            {
                DescripcionMercaderia_ComboBox.Items.Add(mercaderia.Descripcion_Mercaderia);
            }

            // Si lo deseas, puedes seleccionar el primer elemento como predeterminado
            if (DescripcionMercaderia_ComboBox.Items.Count > 0)
            {
                DescripcionMercaderia_ComboBox.SelectedIndex = 0;
            }
        }


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            IdCliente_textbox = new TextBox();
            Cantidad_textbox = new TextBox();
            NombreApellido_TextBox = new TextBox();
            Dni_textbox = new TextBox();
            DescripcionMercaderia_ComboBox = new ComboBox();
            DescripcionDeposito_Combobox = new ComboBox();
            Aceptar_button = new Button();
            DatosTransportistas_groupbox = new GroupBox();
            NombreApellido_label = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            DatosGenerales_groupBox = new GroupBox();
            Deposito_label = new Label();
            IdCliente_label = new Label();
            DatosMercaderias_groupBox = new GroupBox();
            Cantidad_label = new Label();
            Descripcion_label = new Label();
            VolverAlMenu_button = new Button();
            DatosTransportistas_groupbox.SuspendLayout();
            DatosGenerales_groupBox.SuspendLayout();
            DatosMercaderias_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // IdCliente_textbox
            // 
            IdCliente_textbox.Location = new Point(39, 55);
            IdCliente_textbox.Name = "IdCliente_textbox";
            IdCliente_textbox.ReadOnly = true;
            IdCliente_textbox.Size = new Size(100, 23);
            IdCliente_textbox.TabIndex = 0;
            IdCliente_textbox.Text = "1";
            // 
            // Cantidad_textbox
            // 
            Cantidad_textbox.Location = new Point(303, 55);
            Cantidad_textbox.Name = "Cantidad_textbox";
            Cantidad_textbox.Size = new Size(100, 23);
            Cantidad_textbox.TabIndex = 1;
            // 
            // NombreApellido_TextBox
            // 
            NombreApellido_TextBox.Location = new Point(303, 56);
            NombreApellido_TextBox.Name = "NombreApellido_TextBox";
            NombreApellido_TextBox.Size = new Size(100, 23);
            NombreApellido_TextBox.TabIndex = 2;
            // 
            // Dni_textbox
            // 
            Dni_textbox.Location = new Point(43, 56);
            Dni_textbox.Name = "Dni_textbox";
            Dni_textbox.Size = new Size(100, 23);
            Dni_textbox.TabIndex = 3;
            // 
            // DescripcionMercaderia_ComboBox
            // 
            DescripcionMercaderia_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DescripcionMercaderia_ComboBox.FormattingEnabled = true;
            DescripcionMercaderia_ComboBox.Location = new Point(43, 55);
            DescripcionMercaderia_ComboBox.Name = "DescripcionMercaderia_ComboBox";
            DescripcionMercaderia_ComboBox.Size = new Size(121, 23);
            DescripcionMercaderia_ComboBox.TabIndex = 4;
            // 
            // DescripcionDeposito_Combobox
            // 
            DescripcionDeposito_Combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            DescripcionDeposito_Combobox.FormattingEnabled = true;
            DescripcionDeposito_Combobox.Location = new Point(299, 55);
            DescripcionDeposito_Combobox.Name = "DescripcionDeposito_Combobox";
            DescripcionDeposito_Combobox.Size = new Size(121, 23);
            DescripcionDeposito_Combobox.TabIndex = 5;
            // 
            // Aceptar_button
            // 
            Aceptar_button.Location = new Point(306, 402);
            Aceptar_button.Name = "Aceptar_button";
            Aceptar_button.Size = new Size(75, 23);
            Aceptar_button.TabIndex = 6;
            Aceptar_button.Text = "Aceptar";
            Aceptar_button.UseVisualStyleBackColor = true;
            Aceptar_button.Click += button_aceptar_click;
            // 
            // DatosTransportistas_groupbox
            // 
            DatosTransportistas_groupbox.Controls.Add(NombreApellido_label);
            DatosTransportistas_groupbox.Controls.Add(label5);
            DatosTransportistas_groupbox.Controls.Add(NombreApellido_TextBox);
            DatosTransportistas_groupbox.Controls.Add(Dni_textbox);
            DatosTransportistas_groupbox.Location = new Point(44, 236);
            DatosTransportistas_groupbox.Name = "DatosTransportistas_groupbox";
            DatosTransportistas_groupbox.Size = new Size(445, 100);
            DatosTransportistas_groupbox.TabIndex = 8;
            DatosTransportistas_groupbox.TabStop = false;
            DatosTransportistas_groupbox.Text = "Datos Transportistas";
            // 
            // NombreApellido_label
            // 
            NombreApellido_label.AutoSize = true;
            NombreApellido_label.Location = new Point(303, 38);
            NombreApellido_label.Name = "NombreApellido_label";
            NombreApellido_label.Size = new Size(107, 15);
            NombreApellido_label.TabIndex = 5;
            NombreApellido_label.Text = "Nombre y Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 38);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 4;
            label5.Text = "DNI";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(0, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(441, 85);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // DatosGenerales_groupBox
            // 
            DatosGenerales_groupBox.Controls.Add(Deposito_label);
            DatosGenerales_groupBox.Controls.Add(IdCliente_label);
            DatosGenerales_groupBox.Controls.Add(DescripcionDeposito_Combobox);
            DatosGenerales_groupBox.Controls.Add(groupBox2);
            DatosGenerales_groupBox.Controls.Add(IdCliente_textbox);
            DatosGenerales_groupBox.Location = new Point(48, 23);
            DatosGenerales_groupBox.Name = "DatosGenerales_groupBox";
            DatosGenerales_groupBox.Size = new Size(441, 100);
            DatosGenerales_groupBox.TabIndex = 10;
            DatosGenerales_groupBox.TabStop = false;
            DatosGenerales_groupBox.Text = "Datos Generales";
            // 
            // Deposito_label
            // 
            Deposito_label.AutoSize = true;
            Deposito_label.Location = new Point(299, 37);
            Deposito_label.Name = "Deposito_label";
            Deposito_label.Size = new Size(54, 15);
            Deposito_label.TabIndex = 11;
            Deposito_label.Text = "Deposito";
            // 
            // IdCliente_label
            // 
            IdCliente_label.AutoSize = true;
            IdCliente_label.Location = new Point(39, 37);
            IdCliente_label.Name = "IdCliente_label";
            IdCliente_label.Size = new Size(57, 15);
            IdCliente_label.TabIndex = 10;
            IdCliente_label.Text = "Id Cliente";
            // 
            // DatosMercaderias_groupBox
            // 
            DatosMercaderias_groupBox.Controls.Add(Cantidad_label);
            DatosMercaderias_groupBox.Controls.Add(Descripcion_label);
            DatosMercaderias_groupBox.Controls.Add(DescripcionMercaderia_ComboBox);
            DatosMercaderias_groupBox.Controls.Add(Cantidad_textbox);
            DatosMercaderias_groupBox.Location = new Point(44, 130);
            DatosMercaderias_groupBox.Name = "DatosMercaderias_groupBox";
            DatosMercaderias_groupBox.Size = new Size(445, 100);
            DatosMercaderias_groupBox.TabIndex = 11;
            DatosMercaderias_groupBox.TabStop = false;
            DatosMercaderias_groupBox.Text = "Datos Mercaderias";
            // 
            // Cantidad_label
            // 
            Cantidad_label.AutoSize = true;
            Cantidad_label.Location = new Point(303, 37);
            Cantidad_label.Name = "Cantidad_label";
            Cantidad_label.Size = new Size(55, 15);
            Cantidad_label.TabIndex = 6;
            Cantidad_label.Text = "Cantidad";
            // 
            // Descripcion_label
            // 
            Descripcion_label.AutoSize = true;
            Descripcion_label.Location = new Point(43, 37);
            Descripcion_label.Name = "Descripcion_label";
            Descripcion_label.Size = new Size(69, 15);
            Descripcion_label.TabIndex = 5;
            Descripcion_label.Text = "Descripcion";
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(387, 402);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(102, 23);
            VolverAlMenu_button.TabIndex = 12;
            VolverAlMenu_button.Text = "Volver al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // CrearOrdenDePreparacion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 437);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(DatosMercaderias_groupBox);
            Controls.Add(DatosGenerales_groupBox);
            Controls.Add(DatosTransportistas_groupbox);
            Controls.Add(Aceptar_button);
            Name = "CrearOrdenDePreparacion_form";
            Text = "Generar Orden de Preparacion";
            DatosTransportistas_groupbox.ResumeLayout(false);
            DatosTransportistas_groupbox.PerformLayout();
            DatosGenerales_groupBox.ResumeLayout(false);
            DatosGenerales_groupBox.PerformLayout();
            DatosMercaderias_groupBox.ResumeLayout(false);
            DatosMercaderias_groupBox.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TextBox IdCliente_textbox;
        private TextBox Cantidad_textbox;
        private TextBox NombreApellido_TextBox;
        private TextBox Dni_textbox;
        private ComboBox DescripcionMercaderia_ComboBox;
        private ComboBox DescripcionDeposito_Combobox;
        private Button Aceptar_button;
        private GroupBox DatosTransportistas_groupbox;
        private GroupBox groupBox2;
        private GroupBox DatosGenerales_groupBox;
        private GroupBox DatosMercaderias_groupBox;
        private Label NombreApellido_label;
        private Label label5;
        private Label Deposito_label;
        private Label IdCliente_label;
        private Label Cantidad_label;
        private Label Descripcion_label;
        private Button VolverAlMenu_button;
    }
}