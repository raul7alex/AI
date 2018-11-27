using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int aux; //auxiliar pentru numararea conexiuniilor

        private void Intrari_ValueChanged(object sender, EventArgs e)
        {
            int nr_conex = (int)Intrari.Value;
            int count = panel1.Controls.Count;

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
                int n = count / 4;

                for (int i = n; i < nr_conex; i++)
                {
                    count = panel1.Controls.Count;

                    Label lab_x = new Label();
                    lab_x.Text = "X" + Intrari.Value.ToString();
                    lab_x.Location = new Point(10, count * 6);

                    Label lab_w = new Label();
                    lab_w.Text = "W" + Intrari.Value.ToString();
                    lab_w.Location = new Point(90, count * 6);

                    NumericUpDown val_x = new NumericUpDown();
                    val_x.Increment = (decimal)0.01;
                    val_x.Width = 50;
                    val_x.DecimalPlaces = 2;
                    val_x.Location = new Point(35, count * 6);
                    val_x.Minimum = -10;
                    val_x.Maximum = 10;
                    

                    NumericUpDown val_w = new NumericUpDown();
                    val_w.Increment = (decimal)0.01;
                    val_w.Width = 50;
                    val_w.DecimalPlaces = 2;
                    val_w.Location = new Point(120, count * 6);
                    val_w.Minimum = -10;
                    val_w.Maximum = 10;
                    

                    panel1.Controls.Add(val_w);
                    panel1.Controls.Add(lab_w);
                    panel1.Controls.Add(val_x);
                    panel1.Controls.Add(lab_x);

                }
            }

            else
            {
                for (int i = aux; i > nr_conex; i--)
                {
                    int aux_count = panel1.Controls.Count;
                    panel1.Controls.Remove(panel1.Controls[aux_count - 1]);
                    panel1.Controls.Remove(panel1.Controls[aux_count - 2]);
                    panel1.Controls.Remove(panel1.Controls[aux_count - 3]);
                    panel1.Controls.Remove(panel1.Controls[aux_count - 4]);
                }

                aux = nr_conex;
            }

            Refresh();

        }



        private double Suma(List<double> list)
        {
            double S = 0;
            for (int i = 0; i < list.Count; i++)
            {
                S += list[i];
            }
            return S;
        }

        private double Produs(List<double> list)
        {
            double P = 1;
            for (int i = 0; i < list.Count; i++)
            {
                P *= list[i];
            }
            return P;
        }

        private double Minim(List<double> list)
        {
            double min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (min > list[i])
                {
                    min = list[i];
                }
            }
            return min;
        }

        private double Maxim(List<double> list)
        {
            double max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (max < list[i])
                {
                    max = list[i];
                }
            }
            return max;
        }



        private double Sigmoidala(double rez)  
        {
            double prag = (double)prag_val.Value;
            double g = (double)g_val.Value;

            double X = -g * (rez - prag);
            return (double)(1 / (1 + Math.Pow(Math.E, X)));
        }

        private double TanH(double rez)
        {
            double prag = (double)prag_val.Value;
            double g = (double)g_val.Value;

            double P = g * (rez - prag);
            double N = -g * (rez - prag);

            return (Math.Pow(Math.E, P) - Math.Pow(Math.E, N)) /
                   (Math.Pow(Math.E, P) + Math.Pow(Math.E, P));
        }

        private double Treapta(double rez)  
        {
            double prag = (double)prag_val.Value;

            if (rez >= prag)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        private double Semn(double rez)  
        {
            double prag = (double)prag_val.Value;

            if (rez >= prag)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }

        private double Rampa(double rez)
        {
            double g = (double)g_val.Value;
            if (rez>=g)
            {
                return 1;
            }
            if(rez<g*-1)
            {
                return -1;
            }
            else
            {
                return rez / g;
            }
        }


        double x;
        double w;

        public List<double> calcul() //w*x
        {
            List<double> list = new List<double>();
            var numericUpDowns = panel1.Controls.OfType<NumericUpDown>();
            bool var = false;
            foreach (NumericUpDown nr in numericUpDowns)
            {
                if (var == false)
                {
                    x = (double)nr.Value;
                    var = true;
                }
                else
                {
                    w = (double)nr.Value;
                    var = false;
                    list.Add(w * x);
                }

            }

            return list;
        }



        double rezultat;

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<double> val = new List<double>();
            val = calcul();

            if (tip_intrare.Text == "Suma") rezultat = Suma(val);
            if (tip_intrare.Text == "Produs") rezultat = Produs(val);
            if (tip_intrare.Text == "Minim") rezultat = Minim(val);
            if (tip_intrare.Text == "Maxim") rezultat = Maxim(val);


            rez_intrare.Text = rezultat.ToString();


            if (tip_functie.Text == "Sigmoidala") rez_activare.Text = Sigmoidala(rezultat).ToString();
            else if (tip_functie.Text == "TanH") rez_activare.Text = TanH(rezultat).ToString();
            else if (tip_functie.Text == "Treapta") rez_activare.Text = Treapta(rezultat).ToString();
            else if (tip_functie.Text == "Semn") rez_activare.Text = Semn(rezultat).ToString();
            else if (tip_functie.Text == "Rampa") rez_activare.Text = Rampa(rezultat).ToString();


            rez_iesire.Text = rez_activare.Text;


            if (Binar.Checked == true)
            {
                if (tip_functie.Text == "Sigmoidala")
                {
                    if (Double.Parse(rez_iesire.Text) >= 0.5)
                    {
                        Iesire.Text = "1";
                    }
                    else
                    {
                        Iesire.Text = "0";
                    }
                }

                if (tip_functie.Text == "TanH")
                {
                    if (Double.Parse(rez_iesire.Text) >= 0)
                    {
                        Iesire.Text = "1";
                    }
                    else
                    {
                        Iesire.Text = "-1";
                    }
                }
                if (tip_functie.Text == "Semn")
                {
                    if (Double.Parse(rez_iesire.Text) >= 0)
                    {
                        Iesire.Text = "1";
                    }
                    else
                    {
                        Iesire.Text = "0";
                    }
                }
                if (tip_functie.Text == "Treapta")
                {
                    Iesire.Text = rez_iesire.Text;
                }
                if (tip_functie.Text=="Rampa")
                {
                    if (Double.Parse(rez_iesire.Text) <= 0)
                    {
                        Iesire.Text = "1";
                    }
                    else
                    {
                        Iesire.Text = "0";
                    }
                }
            }
            else
            {
                Iesire.Text = rez_iesire.Text;
            }
        }
    }

}
