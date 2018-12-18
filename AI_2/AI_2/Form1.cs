using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] val_w = new int[8];//Nr tariilor sinaptice din form 2
        int x; // modificarea valorii pentru fiecare strat
        int aux; //auxiliar pentru numararea conexiuniilor

        public void Intrari_ValueChanged(object sender, EventArgs e)
        {
            int nr_conex = (int)Intrari.Value;
            int count = panel_intrare.Controls.Count;

            bool var;

            if (aux > nr_conex)
            {
                var = false;
            }
            else
            {
                var = true;
                aux = nr_conex;
            }

            if (var == true)
            {
                int n = count / 2;

                for (int i = n; i < nr_conex; i++)
                {

                    Label lab_x = new Label();
                    lab_x.Text = "X" + Intrari.Value.ToString();
                    lab_x.Location = new Point(10, count * 16);

                    NumericUpDown val_x = new NumericUpDown();
                    val_x.Increment = (decimal)0.01;
                    val_x.Width = 50;
                    val_x.DecimalPlaces = 2;
                    val_x.Location = new Point(35, count * 16);
                    val_x.Minimum = -10;
                    val_x.Maximum = 10;

                    panel_intrare.Controls.Add(val_x);
                    panel_intrare.Controls.Add(lab_x);

                }
            }

            else
            {
                for (int i = aux; i > nr_conex; i--)
                {
                    int aux_count = panel_intrare.Controls.Count;
                    panel_intrare.Controls.Remove(panel_intrare.Controls[aux_count - 1]);
                    panel_intrare.Controls.Remove(panel_intrare.Controls[aux_count - 2]);
                }

                aux = nr_conex;
            }

            Refresh();

        }
        /// <summary>
        /// 
        /// </summary>

        int aux1;

        private void Strat1NuD_ValueChanged(object sender, EventArgs e)
        {
            int nr_conex = (int)Strat1NuD.Value;
            int count = panel_1.Controls.Count;

            bool var;

            if (aux1 > nr_conex)
            {
                var = false;
            }
            else
            {
                var = true;
                aux1 = nr_conex;
            }

            if (var == true)
            {
                int n = count / 2;

                for (int i = n; i < nr_conex; i++)
                {

                    Label lab_x = new Label();
                    lab_x.Text = "X" + Strat1NuD.Value.ToString();
                    lab_x.Location = new Point(10, count * 16);

                    TextBox val_x = new TextBox();
                    val_x.Width = 50;
                    val_x.Location = new Point(35, count * 16);
                    val_x.ReadOnly = true;
                    val_x.DoubleClick += new System.EventHandler(this.TextBox_MouseDoubleClick);

                    panel_1.Controls.Add(val_x);
                    panel_1.Controls.Add(lab_x);

                }
            }

            else
            {
                for (int i = aux1; i > nr_conex; i--)
                {

                    int aux_count2 = panel_1.Controls.Count;
                    panel_1.Controls.Remove(panel_1.Controls[aux_count2 - 1]);
                    panel_1.Controls.Remove(panel_1.Controls[aux_count2 - 2]);
                }

                aux1 = nr_conex;
            }
            
            Refresh();
            x = 1;
            val_w[x] = (int)Intrari.Value;
        }

        /// <summary>

        /// </summary>
        int aux2;

        private void Strat2NuD_ValueChanged(object sender, EventArgs e)
        {
            int nr_conex = (int)Strat2NuD.Value;
            int count = panel_2.Controls.Count;

            x = 2;
            val_w[x] = (int)Strat1NuD.Value;

            bool var;

            if (aux2 > nr_conex)
            {
                var = false;
            }
            else
            {
                var = true;
                aux2 = nr_conex;
            }

            if (var == true)
            {
                int n = count / 2;

                for (int i = n; i < nr_conex; i++)
                {

                    Label lab_x = new Label();
                    lab_x.Text = "X" + Strat2NuD.Value.ToString();
                    lab_x.Location = new Point(10, count * 16);

                    TextBox val_x = new TextBox();
                    val_x.Width = 50;
                    val_x.Location = new Point(35, count * 16);
                    val_x.ReadOnly = true;
                    val_x.DoubleClick += new System.EventHandler(this.TextBox_MouseDoubleClick);

                    panel_2.Controls.Add(val_x);
                    panel_2.Controls.Add(lab_x);

                }
            }

            else
            {
                for (int i = aux2; i > nr_conex; i--)
                {
                    int aux_count3 = panel_2.Controls.Count;
                    panel_2.Controls.Remove(panel_2.Controls[aux_count3 - 1]);
                    panel_2.Controls.Remove(panel_2.Controls[aux_count3 - 2]);
                }

                aux2 = nr_conex;
            }

            Refresh();
        }

        /// <summary>

        /// </summary>
        int aux3;

        private void Strat3NuD_ValueChanged(object sender, EventArgs e)
        {
            int nr_conex = (int)Strat3NuD.Value;   ///schimb
            int count = panel_3.Controls.Count;    ///schimb

            x = 3;
            val_w[x] = (int)Strat2NuD.Value;

            bool var;

            if (aux3 > nr_conex)
            {
                var = false;
            }
            else
            {
                var = true;
                aux3 = nr_conex;  ///schimb
            }

            if (var == true)
            {
                int n = count / 2;

                for (int i = n; i < nr_conex; i++)
                {

                    Label lab_x = new Label();
                    lab_x.Text = "X" + Strat3NuD.Value.ToString();  ///schimb
                    lab_x.Location = new Point(10, count * 16);

                    TextBox val_x = new TextBox();
                    val_x.Width = 50;
                    val_x.Location = new Point(35, count * 16);
                    val_x.ReadOnly = true;
                    val_x.DoubleClick += new System.EventHandler(this.TextBox_MouseDoubleClick);

                    panel_3.Controls.Add(val_x);    ///schimb
                    panel_3.Controls.Add(lab_x);   ///schimb

                }
            }

            else
            {
                for (int i = aux3; i > nr_conex; i--)   ///schimb
                {
                    int aux_count = panel_3.Controls.Count;
                    panel_3.Controls.Remove(panel_3.Controls[aux_count - 1]);  ///schimb
                    panel_3.Controls.Remove(panel_3.Controls[aux_count - 2]);   ///schimb
                }

                aux3 = nr_conex;   ///schimb
            }

            Refresh();

        }

        int aux4;

        private void Strat4NuD_ValueChanged(object sender, EventArgs e)
        {
            int nr_conex = (int)Strat4NuD.Value;   ///schimb
            int count = panel_4.Controls.Count;    ///schimb

            bool var;

            if (aux4 > nr_conex)
            {
                var = false;
            }
            else
            {
                var = true;
                aux4 = nr_conex;  ///schimb
            }

            if (var == true)
            {
                int n = count / 2;

                for (int i = n; i < nr_conex; i++)
                {

                    Label lab_x = new Label();
                    lab_x.Text = "X" + Strat4NuD.Value.ToString();  ///schimb
                    lab_x.Location = new Point(10, count * 16);

                    TextBox val_x = new TextBox();
                    val_x.Width = 50;
                    val_x.Location = new Point(35, count * 16);
                    val_x.ReadOnly = true;
                    val_x.DoubleClick += new System.EventHandler(this.TextBox_MouseDoubleClick);

                    panel_4.Controls.Add(val_x);    ///schimb
                    panel_4.Controls.Add(lab_x);   ///schimb

                }
            }

            else
            {
                for (int i = aux4; i > nr_conex; i--)   ///schimb
                {
                    int aux_count = panel_4.Controls.Count;  ///schimb
                    panel_4.Controls.Remove(panel_4.Controls[aux_count - 1]);  ///schimb
                    panel_4.Controls.Remove(panel_4.Controls[aux_count - 2]);   ///schimb
                }

                aux4 = nr_conex;   ///schimb
            }

            Refresh();
            x = 4;
            val_w[x] = (int)Strat3NuD.Value;
        }

        int aux5;

        private void Strat5NuD_ValueChanged(object sender, EventArgs e)
        {
            int nr_conex = (int)Strat5NuD.Value;   ///schimb
            int count = panel_5.Controls.Count;    ///schimb

            bool var;

            if (aux5 > nr_conex)
            {
                var = false;
            }
            else
            {
                var = true;
                aux5 = nr_conex;  ///schimb
            }

            if (var == true)
            {
                int n = count / 2;

                for (int i = n; i < nr_conex; i++)
                {

                    Label lab_x = new Label();
                    lab_x.Text = "X" + Strat5NuD.Value.ToString();  ///schimb
                    lab_x.Location = new Point(10, count * 16);

                    TextBox val_x = new TextBox();
                    val_x.Width = 50;
                    val_x.Location = new Point(35, count * 16);
                    val_x.ReadOnly = true;
                    val_x.DoubleClick += new System.EventHandler(this.TextBox_MouseDoubleClick);

                    panel_5.Controls.Add(val_x);    ///schimb
                    panel_5.Controls.Add(lab_x);   ///schimb

                }
            }

            else
            {
                for (int i = aux5; i > nr_conex; i--)   ///schimb
                {
                    int aux_count = panel_5.Controls.Count;  ///schimb
                    panel_5.Controls.Remove(panel_5.Controls[aux_count - 1]);  ///schimb
                    panel_5.Controls.Remove(panel_5.Controls[aux_count - 2]);   ///schimb
                }

                aux5 = nr_conex;   ///schimb
            }

            Refresh();
            x = 5;
            val_w[x] = (int)Strat4NuD.Value;
        }

        int aux6;

        private void Strat6NuD_ValueChanged(object sender, EventArgs e)
        {
            int nr_conex = (int)Strat6NuD.Value;   ///schimb
            int count = panel_6.Controls.Count;    ///schimb

            bool var;

            if (aux6 > nr_conex)
            {
                var = false;
            }
            else
            {
                var = true;
                aux6 = nr_conex;  ///schimb
            }

            if (var == true)
            {
                int n = count / 2;

                for (int i = n; i < nr_conex; i++)
                {

                    Label lab_x = new Label();
                    lab_x.Text = "X" + Strat6NuD.Value.ToString();  ///schimb
                    lab_x.Location = new Point(10, count * 16);

                    TextBox val_x = new TextBox();
                    val_x.Width = 50;
                    val_x.Location = new Point(35, count * 16);
                    val_x.ReadOnly = true;
                    val_x.DoubleClick += new System.EventHandler(this.TextBox_MouseDoubleClick);

                    panel_6.Controls.Add(val_x);    ///schimb
                    panel_6.Controls.Add(lab_x);   ///schimb

                }
            }

            else
            {
                for (int i = aux6; i > nr_conex; i--)   ///schimb
                {
                    int aux_count = panel_6.Controls.Count;  ///schimb
                    panel_6.Controls.Remove(panel_6.Controls[aux_count - 1]);  ///schimb
                    panel_6.Controls.Remove(panel_6.Controls[aux_count - 2]);   ///schimb
                }

                aux6 = nr_conex;   ///schimb
            }

            Refresh();
            x = 6;
            val_w[x] = (int)Strat5NuD.Value;
        }

        int aux_i;

        private void Iesire_ValueChanged(object sender, EventArgs e)
        {
            int nr_conex = (int)Iesire.Value;   ///schimb
            int count = panel_iesire.Controls.Count;    ///schimb

            bool var;

            if (aux_i > nr_conex)
            {
                var = false;
            }
            else
            {
                var = true;
                aux_i = nr_conex;  ///schimb
            }

            if (var == true)
            {
                int n = count / 2;

                for (int i = n; i < nr_conex; i++)
                {

                    Label lab_x = new Label();
                    lab_x.Text = "X" + Iesire.Value.ToString();  ///schimb
                    lab_x.Location = new Point(10, count * 16);

                    TextBox val_x = new TextBox();
                    val_x.Width = 50;
                    val_x.Location = new Point(35, count * 16);
                    val_x.ReadOnly = true;
                    val_x.DoubleClick += new System.EventHandler(this.TextBox_MouseDoubleClick);

                    panel_iesire.Controls.Add(val_x);    ///schimb
                    panel_iesire.Controls.Add(lab_x);   ///schimb

                }
            }

            else
            {
                for (int i = aux_i; i > nr_conex; i--)   ///schimb
                {
                    int aux_count = panel_iesire.Controls.Count;  ///schimb
                    panel_iesire.Controls.Remove(panel_iesire.Controls[aux_count - 1]);  ///schimb
                    panel_iesire.Controls.Remove(panel_iesire.Controls[aux_count - 2]);   ///schimb
                }

                aux_i = nr_conex;   ///schimb
            }

            Refresh();
            if ((int)Straturi.Value > 0) val_w[7] = val_w[(int)Straturi.Value]; //caz general
            else val_w[7] = (int)Intrari.Value;

        }

        private void Straturi_ValueChanged(object sender, EventArgs e)
        {
            if ((int)Straturi.Value >= 1)  H1.Visible = false; 
            else if ((int)Straturi.Value < 1) H1.Visible = true;
            if ((int)Straturi.Value >= 2) H2.Visible = false;
            else if ((int)Straturi.Value < 2) H2.Visible = true;
            if ((int)Straturi.Value >= 3) H3.Visible = false;
            else if ((int)Straturi.Value < 3) H3.Visible = true;
            if ((int)Straturi.Value >= 4) H4.Visible = false;
            else if ((int)Straturi.Value < 4) H4.Visible = true;
            if ((int)Straturi.Value >= 5) H5.Visible = false;
            else if ((int)Straturi.Value < 5) H5.Visible = true;
            if ((int)Straturi.Value >= 6) H6.Visible = false;
            else if ((int)Straturi.Value < 6) H6.Visible = true;

        }



        /// <summary>
        /// 
        /// </summary>

        void TextBox_MouseDoubleClick(object sender, EventArgs e)
        {
            TextBox texb = sender as TextBox;
            var myForm = new Form2(val_w[7]);
            myForm.Show();
        }


    }
}
