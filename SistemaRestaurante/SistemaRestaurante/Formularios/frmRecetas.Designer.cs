﻿namespace SistemaRestaurante.Formularios
{
    partial class frmRecetas
    {
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idProductoVLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cantidadEstimadaLabel;
            System.Windows.Forms.Label idProductoCLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.productosVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.recetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productosCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadEstimadaTextBox = new System.Windows.Forms.TextBox();
            this.recetasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idProductoCComboBox = new System.Windows.Forms.ComboBox();
            this.productosCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idProductoVTextBox = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            idProductoVLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            cantidadEstimadaLabel = new System.Windows.Forms.Label();
            idProductoCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productosVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idProductoVLabel
            // 
            idProductoVLabel.AutoSize = true;
            idProductoVLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProductoVLabel.ForeColor = System.Drawing.Color.White;
            idProductoVLabel.Location = new System.Drawing.Point(106, 74);
            idProductoVLabel.Name = "idProductoVLabel";
            idProductoVLabel.Size = new System.Drawing.Size(31, 25);
            idProductoVLabel.TabIndex = 2;
            idProductoVLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(300, 74);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(79, 25);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // cantidadEstimadaLabel
            // 
            cantidadEstimadaLabel.AutoSize = true;
            cantidadEstimadaLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadEstimadaLabel.ForeColor = System.Drawing.Color.White;
            cantidadEstimadaLabel.Location = new System.Drawing.Point(291, 143);
            cantidadEstimadaLabel.Name = "cantidadEstimadaLabel";
            cantidadEstimadaLabel.Size = new System.Drawing.Size(88, 25);
            cantidadEstimadaLabel.TabIndex = 23;
            cantidadEstimadaLabel.Text = "Cantidad:";
            // 
            // idProductoCLabel
            // 
            idProductoCLabel.AutoSize = true;
            idProductoCLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProductoCLabel.ForeColor = System.Drawing.Color.White;
            idProductoCLabel.Location = new System.Drawing.Point(49, 146);
            idProductoCLabel.Name = "idProductoCLabel";
            idProductoCLabel.Size = new System.Drawing.Size(88, 25);
            idProductoCLabel.TabIndex = 25;
            idProductoCLabel.Text = "Producto:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BackColor = System.Drawing.Color.Black;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosVentaBindingSource, "nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.ForeColor = System.Drawing.Color.White;
            this.nombreTextBox.Location = new System.Drawing.Point(385, 76);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(162, 26);
            this.nombreTextBox.TabIndex = 5;
            // 
            // productosVentaBindingSource
            // 
            this.productosVentaBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.ProductosVenta);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(635, 71);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 34);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(688, 262);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 34);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(688, 211);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 34);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(635, 134);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 34);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // recetasBindingSource
            // 
            this.recetasBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.Recetas);
            // 
            // recetasDataGridView
            // 
            this.recetasDataGridView.AutoGenerateColumns = false;
            this.recetasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recetasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.recetasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recetasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.recetasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recetasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.recetasDataGridView.DataSource = this.recetasBindingSource;
            this.recetasDataGridView.EnableHeadersVisualStyles = false;
            this.recetasDataGridView.Location = new System.Drawing.Point(52, 211);
            this.recetasDataGridView.Name = "recetasDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recetasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.recetasDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.recetasDataGridView.Size = new System.Drawing.Size(610, 319);
            this.recetasDataGridView.TabIndex = 23;
            this.recetasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recetasDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idProductoC";
            this.dataGridViewTextBoxColumn3.DataSource = this.productosCompraBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "nombre";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.FillWeight = 60.9137F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ingredientes";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "idProductoC";
            // 
            // productosCompraBindingSource
            // 
            this.productosCompraBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.ProductosCompra);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidadEstimada";
            this.dataGridViewTextBoxColumn4.FillWeight = 139.0863F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad de Productos por Ingrediente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // cantidadEstimadaTextBox
            // 
            this.cantidadEstimadaTextBox.BackColor = System.Drawing.Color.Black;
            this.cantidadEstimadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetasBindingSource1, "cantidadEstimada", true));
            this.cantidadEstimadaTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadEstimadaTextBox.ForeColor = System.Drawing.Color.White;
            this.cantidadEstimadaTextBox.Location = new System.Drawing.Point(385, 146);
            this.cantidadEstimadaTextBox.Name = "cantidadEstimadaTextBox";
            this.cantidadEstimadaTextBox.Size = new System.Drawing.Size(158, 26);
            this.cantidadEstimadaTextBox.TabIndex = 24;
            // 
            // recetasBindingSource1
            // 
            this.recetasBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.Recetas);
            // 
            // idProductoCComboBox
            // 
            this.idProductoCComboBox.BackColor = System.Drawing.Color.Black;
            this.idProductoCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.recetasBindingSource1, "idProductoC", true));
            this.idProductoCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetasBindingSource, "idProductoC", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.idProductoCComboBox.DataSource = this.productosCompraBindingSource1;
            this.idProductoCComboBox.DisplayMember = "nombre";
            this.idProductoCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProductoCComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.idProductoCComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProductoCComboBox.ForeColor = System.Drawing.Color.White;
            this.idProductoCComboBox.FormattingEnabled = true;
            this.idProductoCComboBox.Location = new System.Drawing.Point(161, 144);
            this.idProductoCComboBox.Name = "idProductoCComboBox";
            this.idProductoCComboBox.Size = new System.Drawing.Size(121, 28);
            this.idProductoCComboBox.TabIndex = 26;
            this.idProductoCComboBox.ValueMember = "idProductoC";
            // 
            // productosCompraBindingSource1
            // 
            this.productosCompraBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.ProductosCompra);
            // 
            // idProductoVTextBox
            // 
            this.idProductoVTextBox.BackColor = System.Drawing.Color.Black;
            this.idProductoVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosVentaBindingSource, "idProductoV", true));
            this.idProductoVTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProductoVTextBox.ForeColor = System.Drawing.Color.White;
            this.idProductoVTextBox.Location = new System.Drawing.Point(161, 76);
            this.idProductoVTextBox.Name = "idProductoVTextBox";
            this.idProductoVTextBox.Size = new System.Drawing.Size(121, 26);
            this.idProductoVTextBox.TabIndex = 27;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::SistemaRestaurante.Properties.Resources._61155;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(766, -2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.idProductoVTextBox);
            this.Controls.Add(cantidadEstimadaLabel);
            this.Controls.Add(this.cantidadEstimadaTextBox);
            this.Controls.Add(idProductoCLabel);
            this.Controls.Add(this.idProductoCComboBox);
            this.Controls.Add(this.recetasDataGridView);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(idProductoVLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "frmRecetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productosVentaBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource recetasBindingSource;
        private System.Windows.Forms.DataGridView recetasDataGridView;
        private System.Windows.Forms.BindingSource productosCompraBindingSource;
        private System.Windows.Forms.TextBox cantidadEstimadaTextBox;
        private System.Windows.Forms.BindingSource recetasBindingSource1;
        private System.Windows.Forms.ComboBox idProductoCComboBox;
        private System.Windows.Forms.BindingSource productosCompraBindingSource1;
        private System.Windows.Forms.TextBox idProductoVTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnCerrar;
    }
}