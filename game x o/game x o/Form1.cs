using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_x_o
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool h = true;
        int h_cnt = 0;
        private void click(object sender , EventArgs e)
        {
            Button but = (Button)sender;
            if (h)
                but.Text = "X";
            else
                but.Text = "O";
            h = !h;


            but.Enabled = false;
            h_cnt++;
            winner();
        }
        private void winner()
        {
            bool i = false;
            if((k1.Text==k2.Text)&&(k2.Text==k3.Text)&&(!k1.Enabled))
            {
                i = true;
            }
            else if ((l1.Text == l2.Text) && (l2.Text == l3.Text) && (!l1.Enabled))
            {
                i = true;
            }
            else if ((m1.Text == m2.Text) && (m2.Text == m3.Text) && (!m1.Enabled))
            {
                i = true;
            }
            else if ((k1.Text == l1.Text) && (l1.Text == m1.Text) && (!k1.Enabled))
            {
                i = true;
            }
            else if ((k2.Text == l2.Text) && (l2.Text == m2.Text) && (!k2.Enabled))
            {
                i = true;
            }
            else if ((k3.Text == l3.Text) && (l3.Text == m3.Text) && (!k3.Enabled))
            {
                i = true;
            }
            else if((k1.Text==l2.Text)&&(l2.Text==m3.Text)&&(!k1.Enabled))
            {
                i = true;
            }
            else if ((k3.Text == l2.Text) && (l2.Text == m1.Text) && (!k3.Enabled))
            {
                i = true;
            }
            if(i)
            {
                string str;
              if(h)
              {
                    int a = int.Parse(O.Text);
                    a++;
                    O.Text = a.ToString();
                    str = player_2.Text;
                    enblebut();
              }
              else
              {
                    int a = int.Parse(X.Text);
                    a++;
                    X.Text = a.ToString();
                    str = player_1.Text;
                    enblebut();
              }
                MessageBox.Show(str + " WIN ");
                h_cnt = 0;
            }
            if(h_cnt==9)
            {
                MessageBox.Show("DRAW");
                h_cnt = 0;
                enblebut();
                int a = Convert.ToInt32(drow.Text);
                a++;
                drow.Text = a.ToString();
            }
        }
        private void enblebut()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void O_Click(object sender, EventArgs e)
        {

        }
    }
}
