﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRestaurante.Controladores;

namespace SistemaRestaurante
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != "Ingrese  Contraseña")
            {
                if (txtPassword.PasswordChar == '•')
                {
                    txtPassword.PasswordChar = '\0';
                }
                else if (txtPassword.PasswordChar == '\0')
                {
                    txtPassword.PasswordChar = '•';
                }
            }
            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese  Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese  Usuario";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ingrese  Contraseña")
            {
                txtPassword.PasswordChar = '•';
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Ingrese  Contraseña";
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            CUsuario cUsuario = new CUsuario();
            String Nombre = cUsuario.ObtenerNombre(txtUsuario.Text, txtPassword.Text);
            if (cUsuario.verificarLogueo(txtUsuario.Text, txtPassword.Text) == true)
            {
                if (cUsuario.Obtenerrol(txtUsuario.Text, txtPassword.Text).Equals("Administrador"))
                {
                    MessageBox.Show("Bienvenido/a " + Nombre);
                    this.Hide();
                    string user = txtUsuario.Text;
                    Menu menu = new Menu(user);
                    menu.Show();
                }else if (cUsuario.Obtenerrol(txtUsuario.Text, txtPassword.Text).Equals("Usuario"))
                {
                    MessageBox.Show("Bienvenido/a " + Nombre);
                    this.Hide();
                    string user = txtUsuario.Text;
                    MenuUsuario menuU = new MenuUsuario(user);
                    menuU.Show();
                }
            }
            else
            {
                MessageBox.Show("Las Credenciales Ingresadas no son validas");
            }
        }

        private void lklNuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FNuevoUsuario fNuevoUsuario = new FNuevoUsuario();
            fNuevoUsuario.Show();
        }
    }
}
