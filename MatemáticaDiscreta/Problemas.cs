using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MatemáticaDiscreta
{
    public partial class Problemas : MetroForm
    {
        public Problemas()
        {
            InitializeComponent();
        }

        private void Problemas_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MatemáticaDiscreta.Controller.Atualizador.ValueN = 10;
            MatemáticaDiscreta.Controller.Atualizador.ValueM = 2;
            MatemáticaDiscreta.Controller.Atualizador.Box1 = true;
            MatemáticaDiscreta.Controller.Atualizador.Box2 = false;
            MatemáticaDiscreta.Controller.Atualizador.stats = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MatemáticaDiscreta.Controller.Atualizador.ValueN = 8;
            MatemáticaDiscreta.Controller.Atualizador.ValueM = 2;
            MatemáticaDiscreta.Controller.Atualizador.Box1 = true;
            MatemáticaDiscreta.Controller.Atualizador.Box2 = false;
            MatemáticaDiscreta.Controller.Atualizador.stats = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MatemáticaDiscreta.Controller.Atualizador.ValueN = 2;
            MatemáticaDiscreta.Controller.Atualizador.ValueM = 10;
            MatemáticaDiscreta.Controller.Atualizador.Box1 = true;
            MatemáticaDiscreta.Controller.Atualizador.Box2 = true;
            MatemáticaDiscreta.Controller.Atualizador.stats = 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MatemáticaDiscreta.Controller.Atualizador.ValueN = 4;
            MatemáticaDiscreta.Controller.Atualizador.ValueM = 3;
            MatemáticaDiscreta.Controller.Atualizador.Box1 = true;
            MatemáticaDiscreta.Controller.Atualizador.Box2 = false;
            MatemáticaDiscreta.Controller.Atualizador.stats = 1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MatemáticaDiscreta.Controller.Atualizador.ValueN = 6;
            MatemáticaDiscreta.Controller.Atualizador.ValueM = 2;
            MatemáticaDiscreta.Controller.Atualizador.Box1 = true;
            MatemáticaDiscreta.Controller.Atualizador.Box2 = false;
            MatemáticaDiscreta.Controller.Atualizador.stats = 1;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MatemáticaDiscreta.Controller.Atualizador.ValueN = 5;
            MatemáticaDiscreta.Controller.Atualizador.ValueM = 3;
            MatemáticaDiscreta.Controller.Atualizador.Box1 = false;
            MatemáticaDiscreta.Controller.Atualizador.Box2 = false;
            MatemáticaDiscreta.Controller.Atualizador.stats = 1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            MatemáticaDiscreta.Controller.Atualizador.ValueN = 6;
            MatemáticaDiscreta.Controller.Atualizador.ValueM = 6;
            MatemáticaDiscreta.Controller.Atualizador.Box1 = true;
            MatemáticaDiscreta.Controller.Atualizador.Box2 = false;
            MatemáticaDiscreta.Controller.Atualizador.stats = 1;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            MatemáticaDiscreta.Controller.Atualizador.ValueN = 4;
            MatemáticaDiscreta.Controller.Atualizador.ValueM = 8;
            MatemáticaDiscreta.Controller.Atualizador.Box1 = false;
            MatemáticaDiscreta.Controller.Atualizador.Box2 = true;
            MatemáticaDiscreta.Controller.Atualizador.stats = 1;
        }
    }
}
