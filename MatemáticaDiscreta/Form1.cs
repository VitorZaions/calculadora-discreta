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
    public partial class DiscretaM : MetroForm
    {

        double fat(double numero)
        {

            if (numero == 1 || numero == 0)
                return 1;

            double aux;
            aux = numero;
            while (numero > 1)
            {
                aux = aux * (numero - 1);
                numero--;
            }
            return (aux);
        }


        public DiscretaM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MatemáticaDiscreta.Controller.Atualizador.stats = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        void calcular()
        {           
            double result = 0;

            double N = Convert.ToInt32(NValue.Value);
            double M = Convert.ToInt32(MValue.Value);

            if (Box1.Checked == true && Box2.Checked == false)
            {
                result = fat(N) / fat(N - M);
                PictureForm.Image = MatemáticaDiscreta.Properties.Resources.FormulaUm;
            }

            if (Box1.Checked == true && Box2.Checked == true)
            {
                result = Math.Pow(N, M);
                PictureForm.Image = MatemáticaDiscreta.Properties.Resources.FormulaDois;
            }


            if (Box1.Checked == false && Box2.Checked == false)
            {
                result = fat(N) / (((fat(N - M)) * fat(M)));
                PictureForm.Image = MatemáticaDiscreta.Properties.Resources.FormulaTrees;
            }


            if (Box1.Checked == false && Box2.Checked == true)
            {
                result = fat(N + M - 1) / (fat(N - 1) * fat(M));
                PictureForm.Image = MatemáticaDiscreta.Properties.Resources.FormulaFour;
            }
            
            ResultadoBox.Text = result + "";            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            calcular();
        }

        void limpar()
        {
            PictureForm.Image = null;
            ResultadoBox.Clear();
            NValue.Value = 1;
            MValue.Value = 1;
            Box1.Checked = false;
            Box2.Checked = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Problemas form = new Problemas();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(MatemáticaDiscreta.Controller.Atualizador.stats == 1)
            {
                limpar();

                NValue.Value = Convert.ToDecimal(MatemáticaDiscreta.Controller.Atualizador.ValueN);
                MValue.Value = Convert.ToDecimal(MatemáticaDiscreta.Controller.Atualizador.ValueM);

                Box1.Checked = MatemáticaDiscreta.Controller.Atualizador.Box1;
                Box2.Checked = MatemáticaDiscreta.Controller.Atualizador.Box2;

                calcular();


            }
        }
    }
}
