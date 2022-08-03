using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginAndRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButtom_Click(object sender, EventArgs e)
        {
            homePanel.Visible=false;
            loginPanel.Visible = true;
        }

        private void returnOne_Click(object sender, EventArgs e)
        {
            textBoxUserLogin.Text = "";
            textBoxPassLogin.Text = "";
            mensajeLogin.Text = "";
            homePanel.Visible = true;
            loginPanel.Visible = false;
        }

        private void regisButtom_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            regisPanel.Visible = true;
        }

        private void returnTwo_Click(object sender, EventArgs e)
        {
            mensajeRegis.Text = "";
            textBoxUserRegis.Text = "";
            textBoxPassRegis.Text = "";
            textBoxPassRegisTwo.Text = "";

            homePanel.Visible = true;
            regisPanel.Visible = false;
        }

        private void singUpButtom_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUserRegis.Text,
                pass = textBoxPassRegis.Text,
                rpass = textBoxPassRegisTwo.Text,
                passCrip = "";

            if(usuario != "" && pass != "" && rpass != "")
            {
                if (pass == rpass)
                {
                    if (verificarCuenta(usuario) == false)
                    {
                        for (int i = pass.Length - 1; i >= 0; i--)
                        {
                            passCrip += pass[i];
                            passCrip += "XYJ";
                        }

                        using (TextWriter ArchivoUser = new StreamWriter("Cuentas.txt", true))
                        {
                            ArchivoUser.WriteLine(usuario + "," + passCrip.ToUpper());
                        }

                        mensajeLogin.ForeColor = Color.Green;
                        mensajeLogin.Text = "Te registraste correctamente";

                        textBoxUserRegis.Text = "";
                        textBoxPassRegis.Text = "";
                        textBoxPassRegisTwo.Text = "";
                        mensajeRegis.Text = "";

                        regisPanel.Visible = false;
                        loginPanel.Visible = true;
                    }
                    else 
                    {
                        mensajeRegis.ForeColor = Color.Red;
                        mensajeRegis.Text = "El nombre de usuario ya esta utilizado";
                    }
                }
                else
                {
                    mensajeRegis.ForeColor = Color.Red;
                    mensajeRegis.Text = "Las contraseñas no son iguales";
                }
            }
            else
            {
                mensajeRegis.ForeColor = Color.Red;
                mensajeRegis.Text = "Por Favor complete los campos";
            }
        }

        private bool verificarCuenta(string usuario)
        {
            StreamReader lectura;
            string cadena;
            bool encontrado = false;
            string[] campo = new string[2];
            char[] separador = { ',' };

            lectura = File.OpenText("Cuentas.txt");
            cadena = lectura.ReadLine();

            while (cadena != null && encontrado == false)
            {
                campo = cadena.Split(separador);
                if (campo[0].Trim().Equals(usuario))
                {
                    lectura.Close();
                    encontrado = true;
                }
                else
                {
                    cadena = lectura.ReadLine();
                }
            }
            if (encontrado == false)
            {
                lectura.Close();
                return false;
            }
            else 
            {
                return true;
            }
        }

        private void loginButtomTwo_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUserLogin.Text,
                pass = textBoxPassLogin.Text,
                passCrip = "";

            if (textBoxUserLogin.Text != "" && textBoxPassLogin.Text != "") 
            {
                for (int i = pass.Length - 1; i >= 0; i--)
                {
                    passCrip += pass[i];
                    passCrip += "XYJ";
                }

                if (verificarCuenta(usuario) && verificarPass(passCrip.ToUpperInvariant())) 
                {
                    textBoxUserLogin.Text = "";
                    textBoxPassLogin.Text = "";
                    mensajeLogin.Text = "";

                    loginPanel.Visible = false;
                    inicioPanel.Visible = true;
                }
                else 
                {
                    mensajeLogin.ForeColor = Color.Red;
                    mensajeLogin.Text = "La contraseña o usuario no son correctos";
                }
            }
            else 
            {
                mensajeLogin.ForeColor = Color.Red;
                mensajeLogin.Text = "Por favor completa los campos";
            }
        }

        private bool verificarPass(string pass)
        {
            StreamReader lectura;
            string cadena;
            bool encontrado = false;
            string[] campo = new string[2];
            char[] separador = { ',' };

            lectura = File.OpenText("Cuentas.txt");
            cadena = lectura.ReadLine();

            while (cadena != null && encontrado == false)
            {
                campo = cadena.Split(separador);
                if (campo[1].Trim().Equals(pass))
                {
                    lectura.Close();
                    encontrado = true;
                }
                else
                {
                    cadena = lectura.ReadLine();
                }
            }
            if (encontrado == false)
            {
                lectura.Close();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicioPanel.Visible = false;
            homePanel.Visible = true;
        }
    }
}
