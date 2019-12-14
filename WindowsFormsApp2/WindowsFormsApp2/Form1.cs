using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int A = 1;
        public System.Windows.Forms.TextBox AddNewTextBox(int top, int left, int xs, int ys, String s)
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            this.Controls.Add(txt);
            txt.Top = A * top;
            txt.Left = left;
            txt.Text = s;
            txt.Size = new Size(40, 4);
            txt.Location = new Point(xs + 50, ys + 50);
            A = A + 1;
            return txt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        static int num_of_shapes;
        int row1;
        int coulmn1;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            row1 = int.Parse(textBox1.Text);
            if(row1 != 0)
            {
                num_of_shapes++;

            }
            coulmn1 = int.Parse(textBox1.Text);
        }

        int row2;
        int coulmn2;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            row2 = int.Parse(textBox3.Text);
            if (textBox3.Text != null)
            {
                num_of_shapes++;

            }
            coulmn2 = int.Parse(textBox3.Text);


        }
        int row3;
        int column3;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            row3 = int.Parse(textBox5.Text);
            if (textBox5.Text != null)
            {
                num_of_shapes++;

            }
            column3 = int.Parse(textBox5.Text);



        }

        int row4;
        int column4;
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            row4 = int.Parse(textBox7.Text);
            if (textBox7.Text != null)
            {
                num_of_shapes++;

            }
            column4 = int.Parse(textBox7.Text);



        }
        int row5;
        int column5;
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            row5 = int.Parse(textBox9.Text);
            if (textBox9.Text != null)
            {
                num_of_shapes++;

            }
            column5 = int.Parse(textBox9.Text);


        }

        public List<string> button1_Click(object sender, EventArgs e)
        {
            List<string> rowlist = new List<string>();

            int i;
            int j;
            int fs = -50;
            for (i = 0; i < row1 ; i++)
            {
                AddNewTextBox(50, 10, -30, (fs) + 110, "row");
                rowlist.Add(AddNewTextBox(50, 10, -30, (fs) + 110, "row").Text);

                fs = fs + 26;
            }
            return rowlist;



        }
        



        public List<string> button2_Click(object sender, EventArgs e)
        {
            List<string> rowlist = new List<string>();

            int i;
            int j;
            int fs = -50;
            for (i = 0; i < row2; i++)
            {
                AddNewTextBox(50, 10, 176, (fs) + 110, "row");
                rowlist.Add(AddNewTextBox(50, 10, 176, (fs) + 110, "row").Text);


                fs = fs + 26;
            }
            return rowlist;

        }

        public List<string> button3_Click(object sender, EventArgs e)
        {
            List<string> rowlist = new List<string>();

            int i;
            int j;
            int fs = -50;
            for (i = 0; i < row3; i++)
            {
                AddNewTextBox(50, 10, 400, (fs) + 110, "row");
                fs = fs + 26;
                rowlist.Add(AddNewTextBox(50, 10, 400, (fs) + 110, "row").Text);

            }
            return rowlist;
        }

        public List<string> button4_Click(object sender, EventArgs e)
        {
            List<string> rowlist = new List<string>();

            int i;
            int j;
            int fs = -50;
            for (i = 0; i < row4; i++)
            {
                AddNewTextBox(50, 10, 130, (fs) + 310, "row");
                rowlist.Add(AddNewTextBox(50, 10, 130, (fs) + 310, "row").Text);
                fs = fs + 26;
            }
            return rowlist;
        }

        public List<string> button5_Click(object sender, EventArgs e)
        {
            List<string> rowlist = new List<string>();
            int i;
            int j;
            int fs = -50;
            for (i = 0; i < row5; i++)
            {
                AddNewTextBox(50, 10, 350, (fs) + 310, "row");
                rowlist.Add(AddNewTextBox(50, 10, 350, (fs) + 310, "row").Text);

                fs = fs + 26;
            }
            return rowlist;
        }
        

       
    }
}
