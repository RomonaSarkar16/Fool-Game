using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fool_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepPink;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hide form 1 
            this.Hide();
            //create an instance of form2
            Form2 form2 = new Form2();
           // form2.Tag = this;
           //show form2
            form2.ShowDialog();//this gonna hault/freeze the click event + dispose form2 instance
            form2 = null;
            this.Show();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            Random x = new Random();
            Point pt = new Point(
                int.Parse(x.Next(400).ToString()),
                int.Parse(x.Next(600).ToString())
                    );
            Button2.Location = pt;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
           
            if(keyData == Keys.Enter)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();
                this.Close();
               
                
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
