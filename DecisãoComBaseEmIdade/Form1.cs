using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisãoComBaseEmIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

   

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty)
               
            {

                MessageBox.Show("Todos os dados devem ser informados.", "Ateção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                TimeSpan tsQuantidadeDias = DateTime.Now.Date - DataNascimento.Value;
                int idade = (tsQuantidadeDias.Days / 365);

                    if (idade > 17)
                {
                    categoria.Text = "Adulto";

                }else if(idade > 13)
                {
                    categoria.Text = "Juvenil B";

                }else if(idade > 10)
                {
                    categoria.Text = "Juvenil A";
                
                }else if(idade > 7)
                {
                    categoria.Text = "Infantil B";

                }else if(idade >= 5)
                {
                    categoria.Text = "Infantil A";

                }
                else
                {
                    categoria.Text = "Não existe categoria";
                }



                
            }
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Hoje.Text = "Hoje é " + DateTime.Now.ToShortDateString();

        }

       
    }

}