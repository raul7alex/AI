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
    public partial class Form2 : Form
    {
       
        public Form2(int val_w)
        {
            InitializeComponent();

            int count = panel1.Controls.Count;


                int n = count / 2;

                for (int i = n; i < val_w; i++)
                {
                    count = panel1.Controls.Count;


                    Label lab_W = new Label();
                    lab_W.Text = "W" + (i+1).ToString();
                    lab_W.Location = new Point(90, count * 12);


                    NumericUpDown val_W = new NumericUpDown();
                    val_W.Increment = (decimal)0.01;
                    val_W.Width = 50;
                    val_W.DecimalPlaces = 2;
                    val_W.Location = new Point(120, count * 12);
                    val_W.Minimum = -10;
                    val_W.Maximum = 10;


                    panel1.Controls.Add(val_W);
                    panel1.Controls.Add(lab_W);

                }
            
            Refresh();


        }
    }
}
