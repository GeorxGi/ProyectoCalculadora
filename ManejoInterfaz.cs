using ProyectoCalculadora.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCalculadora
{
    internal class ManejoInterfaz
    {
        public Form1 f;
        public Color tonoOscuro = Color.FromArgb(36, 52, 65);
        public Color tonoClaro = Color.FromArgb(225, 225, 225);
        public bool IsDarkMode = false;
        private static readonly Calculadora calc = new Calculadora();

        public void Calcular(char op)
        {
                if (op == '=' && f.label2.Text != " ")
                {
                    string aux = f.label1.Text;
                    f.label1.Text = calc.Operador(f.label1.Text, f.label2.Text[0], f.label3.Text);
                    f.label3.Text = f.label3.Text + f.label2.Text[0] + aux + "="; f.label2.Text = " ";
                }
                else if(op == '√' || op == '⅟')
                {
                    string aux = f.label1.Text;
                    f.label1.Text = calc.Operador(f.label1.Text, op, "0");
                    f.label3.Text = op + aux + "="; f.label2.Text = " ";
                }
                
                else if(f.label2.Text != " " && op == '%')
                {
                    //Si, manejar una conversión tan jodida como la de abajo es todo menos recomendable, pero
                    //No queria mover mucho lo que ya llevaba, así que, esto fue lo que terminé haciendo
                    //string aux = f.label1.Text;
                    double porc;
                    try
                    {
                        string aux = f.label1.Text;
                        porc = Convert.ToDouble(f.label1.Text) / 100;
                        if (f.label2.Text[0] == '+' || f.label2.Text[0] == '-') f.label1.Text = calc.Operador(f.label3.Text, f.label2.Text[0], Convert.ToString(Convert.ToDouble(f.label1.Text) * porc));
                        else f.label1.Text = calc.Operador(f.label3.Text, f.label2.Text[0], Convert.ToString(porc));
                        f.label3.Text = f.label3.Text + f.label2.Text + aux + "%="; f.label2.Text = " ";
                    }
                    catch(Exception e)
                    {
                        f.label1.Text = "0";
                        MessageBox.Show(e.Message);
                    } 
                }
                
                else if (f.label2.Text != " ")
                {
                    f.label3.Text = calc.Operador(f.label1.Text, f.label2.Text[0], f.label3.Text);
                    f.label1.Text = "0";
                }
        }
        
        public void Delete()
        {
            f.label1.Text = f.label1.Text.Remove(f.label1.Text.Length - 1);
            if (f.label1.Text.Length == 0 || (f.label1.Text[0] == '-' && f.label1.Text.Length == 1)) f.label1.Text = "0";
        }

        public void IngresoNumeros(int num)
        {
            if(f.label1.Text == "0") f.label1.Text = num.ToString();
            else if(f.label1.Text == "-0") f.label1.Text = '-' + num.ToString();
            
            else f.label1.Text += num.ToString();
        }

        //"no se puede transformar de char a string", toma un caracter vacio, funciona y dejame tranquilo
        public void SimboloMat(char op)
        {
            if (f.label2.Text[0] != op && f.label2.Text != " ")
            {
                f.label2.Text = op + "";
            }
            else if (f.label2.Text[0] == op) Calcular(op);
            else
            {
                f.label2.Text = op + "";
                f.label3.Text = f.label1.Text;
                f.label1.Text = "0";
            }
        }


        public void CambioTema()
        {
            IsDarkMode = !IsDarkMode;
            foreach(Panel p in f.Controls.OfType<Panel>())
            {
                foreach(Button c in p.Controls.OfType<Button>())
                {
                    if(c != f.button112 && c != f.button21 && c != f.button34)
                    {
                        if (c.Enabled == true) CambioColor(c);
                        
                        else ActivarDesactivar(c.Enabled, c);
                    }
                }
            }
            f.modoOscuroToolStripMenuItem.Checked = IsDarkMode;

            if (IsDarkMode)
            {
                f.Icon = Resources.IconoOscuro;
                f.BackColor = Color.FromArgb(30, 44, 57);
            }
            else
            {
                f.Icon = Resources.IconoClaro;
                f.BackColor = Color.FromArgb(235, 235, 235);
            }
            CambioColor(f.panel5);
            CambioColor(f.panel6);
            CambioColor(f.panel7);
            CambioColor(f.menuStrip1);
        }

        public void InterfazConversion(bool EstaActiva, Panel panelActual)
        {
            f.panel8.Visible = EstaActiva;
            if (EstaActiva)
            {
                f.panel8.Location = new Point(panelActual.Width + 1, 27);
                f.Size = new Size(panelActual.Width + f.panel8.Width, panelActual.Height + 54);
            }
            else
            {
                f.Size = new Size(panelActual.Width + 5, panelActual.Height + 54);
            }
        }

        public void ActivarDesactivar(bool activar, Button b)
        {
            if(activar)
            {
                b.Enabled = true;
                CambioColor(b);
            }
            else
            {
                b.Enabled = false; 
                CambioColor(b, Color.FromArgb(210, 210, 210), Color.FromArgb(60, 70, 80));
            }
        }

        private void CambioColor(Control b)
        {
            if (IsDarkMode)
            {
                b.BackColor = tonoOscuro;
                b.ForeColor = tonoClaro;
            }
            else
            {
                b.BackColor = tonoClaro;
                b.ForeColor = tonoOscuro;
            }
        }
        private void CambioColor(Control b, Color tonoClaro, Color tonoOscuro)
        {
            if (IsDarkMode)
            {
                b.BackColor = tonoOscuro;
                b.ForeColor = tonoClaro;
            }
            else
            {
                b.BackColor = tonoClaro;
                b.ForeColor = tonoOscuro;
            }
        }
    }
}
