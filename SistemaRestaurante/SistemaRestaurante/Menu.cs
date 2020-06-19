﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRestaurante.Formularios;

namespace SistemaRestaurante
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
        public static Logueo logueo = new Logueo();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea cerrar sesion?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                logueo.Show();
            }
        }
        public static frmProductosVenta fProductos = new frmProductosVenta();
        private void productosVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProductos.MdiParent = this;
            fProductos.Show();
        }
        public static frmProveedores fProveedores = new frmProveedores();
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProveedores.MdiParent = this;
            fProveedores.Show();
        }
        public static frmProductosCompra fProductosC = new frmProductosCompra();
        private void productosCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProductosC.MdiParent = this;
            fProductosC.Show();
        }

        public static frmNuevaOrden fNuevaOrden = new frmNuevaOrden();
        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNuevaOrden.MdiParent = this;
            fNuevaOrden.Show();
        }

        public static frmNuevaVenta fNuevaVenta = new frmNuevaVenta();
        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNuevaVenta.MdiParent = this;
            fNuevaVenta.Show();
        }
    }
}