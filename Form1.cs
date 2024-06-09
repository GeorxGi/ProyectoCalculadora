using ProyectoCalculadora.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCalculadora
{
    public partial class Form1 : Form
    {
        //https://coolors.co/e3e5e4-1e2c39-243441-ed802e-707e89-ebebeb
        //https://i.pinimg.com/originals/62/0f/ea/620fea3a0644cea4b3599374aeb72255.jpg
        //tamaño anterior : 280; 421

        //Hay que arreglar el manejo de porcentajes

        private ManejoInterfaz manInt = new ManejoInterfaz();
        private Calculadora calc = new Calculadora();
        public Form1()
        {
            InitializeComponent();
            manInt.f = this;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void estándarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Calculadora Estándar";
            manInt.InterfazConversion(panel8.Enabled, panelEstandar);
            //Size = new Size(panelEstandar.Width+5, panelCientifica.Height+54);
            panelEstandar.Visible    = true;      estándarToolStripMenuItem.Checked = true;
            panelCientifica.Visible  = false;   cientificaToolStripMenuItem.Checked = false;
            panelProgramador.Visible = false; programadorToolStripMenuItem1.Checked = false;
            panelEstadistica.Visible = false;  estadísticaToolStripMenuItem.Checked = false;
            
        }
        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Calculadora Científica";
            manInt.InterfazConversion(panel8.Enabled, panelCientifica);
            //Size = new Size(panelCientifica.Width+5, panelCientifica.Height+54);
            panelEstandar.Visible    = false;     estándarToolStripMenuItem.Checked = false;
            panelCientifica.Visible  = true;    cientificaToolStripMenuItem.Checked = true;
            panelProgramador.Visible = false; programadorToolStripMenuItem1.Checked = false;
            panelEstadistica.Visible = false;  estadísticaToolStripMenuItem.Checked = false;
        }

        private void programadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Text = "Calculadora Programador";
            manInt.InterfazConversion(panel8.Enabled, panelProgramador);
            //Size = new Size(panelProgramador.Width+5, panelProgramador.Height+54);
            panelEstandar.Visible    = false;    estándarToolStripMenuItem.Checked = false;
            panelCientifica.Visible  = false;  cientificaToolStripMenuItem.Checked = false;
            panelProgramador.Visible = true; programadorToolStripMenuItem1.Checked = true;
            panelEstadistica.Visible = false; estadísticaToolStripMenuItem.Checked = false;
        }

        private void estadísticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Calculadora Estadística";
            manInt.InterfazConversion(panel8.Enabled, panelEstadistica);
            //Size = new Size(panelEstadistica.Width+5, panelEstadistica.Height+54);
            panelEstandar.Visible    = false;     estándarToolStripMenuItem.Checked = false;
            panelCientifica.Visible  = false;   cientificaToolStripMenuItem.Checked = false;
            panelProgramador.Visible = false; programadorToolStripMenuItem1.Checked = false;
            panelEstadistica.Visible = true;   estadísticaToolStripMenuItem.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "5";
            else label1.Text += '5';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            manInt.Calcular('=');
        }

        private void modoOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manInt.CambioTema();
        }

        private void sobreLaCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculadora creada por: Georges Chakour\ncomo parte de un pequeño proyecto\npara la materia Lenguajes de Programación", "Información");
        }

        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda", "Ayuda");

        }

        private void básicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            List<Button> activar = new List<Button>
            {
                button119, button115
            };
            List<Button> desactivar = new List<Button>
            {
                button118, button117, button124, button123, button122, button111, button110, button109, button106, button101, button96, button91, button86, button125, button107, button120, button114, button82
            };
            foreach (Button b in activar)
            {
                manInt.ActivarDesactivar(true, b);
            }
            foreach (Button b in desactivar)
            {
                manInt.ActivarDesactivar(false, b);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            List<Button> activar = new List<Button>
            {
                button106, button101, button96, button91, button86, button82, button118, button117, button124, button123, button122, button111, button119, button115, button110, button109, button111
            };
            foreach (Button b in activar)
            {
                manInt.ActivarDesactivar(true, b);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            List<Button> activar = new List<Button>
            {
                button118, button117, button124, button123, button122, button111, button119, button115
            };
            List<Button> desactivar = new List<Button>
            {
                button106, button91, button96, button86, button110, button109, button125, button107, button120, button114, button82
            };
            foreach(Button b in activar)
            {
                manInt.ActivarDesactivar(true, b);
            }
            foreach(Button b in desactivar)
            {
                manInt.ActivarDesactivar(false, b);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            List<Button> activar = new List<Button>
            {
                button118, button117, button124, button123, button122, button111, button119, button115, button110, button109, button111
            };
            List<Button> desactivar = new List<Button>
            {
                button106, button101, button96, button91, button86, button125, button107, button120, button114, button82
            };
            foreach(Button b in activar)
            {
                manInt.ActivarDesactivar(true, b);
            }
            foreach(Button b in desactivar)
            {
                manInt.ActivarDesactivar(false, b);
            }
        }

        private void panelCientifica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button77_Click(object sender, EventArgs e)
        {

        }

        private void button78_Click(object sender, EventArgs e)
        {

        }

        private void button79_Click(object sender, EventArgs e)
        {

        }

        private void button80_Click(object sender, EventArgs e)
        {

        }

        private void button81_Click(object sender, EventArgs e)
        {

        }

        private void button72_Click(object sender, EventArgs e)
        {

        }

        private void button73_Click(object sender, EventArgs e)
        {

        }

        private void button74_Click(object sender, EventArgs e)
        {

        }

        private void button75_Click(object sender, EventArgs e)
        {

        }

        private void button76_Click(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {

        }

        private void button68_Click(object sender, EventArgs e)
        {

        }

        private void button69_Click(object sender, EventArgs e)
        {

        }

        private void button70_Click(object sender, EventArgs e)
        {

        }

        private void button71_Click(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button64_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {

        }

        private void button66_Click(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            manInt.IngresoNumeros(1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            manInt.IngresoNumeros(2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            manInt.IngresoNumeros(3);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            manInt.IngresoNumeros(4);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            manInt.IngresoNumeros(6);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            manInt.IngresoNumeros(7);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            manInt.IngresoNumeros(8);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            manInt.IngresoNumeros(9);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!(label1.Text == "0")) label1.Text += '0';
        }

        private void button22_Click(object sender, EventArgs e)
        {
            manInt.SimboloMat('+');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            manInt.SimboloMat('-');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            manInt.SimboloMat('*');
        }

        private void button25_Click(object sender, EventArgs e)
        {
            manInt.SimboloMat('/');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text.StartsWith("-")) label1.Text = label1.Text.Remove(0, 1);
            else label1.Text = '-' + label1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "0"; label2.Text = " "; label3.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manInt.Calcular('√');
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if(!label1.Text.Contains(',')) label1.Text += ",";
        }

        private void conversiónDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel8.Enabled = !panel8.Enabled;
            conversiónDeUnidadesToolStripMenuItem.Checked = panel8.Enabled;
            foreach(Panel p in Controls.OfType<Panel>())
            {
                //revisa entre todos los paneles (sin contar los utilizados como cuadro gris de las calculadoras)
                //y utiliza el que esté actualmente visible para el tamaño de la ventana
                if (p != panel5 && p != panel6 && p != panel7 && p.Visible == true)
                {
                    manInt.InterfazConversion(panel8.Enabled, p);
                    break;
                }
            }
            //manInt.InterfazConversion(panel8.Enabled);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            manInt.Delete();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            manInt.Calcular('⅟');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            manInt.Calcular('%');
        }
    }
}