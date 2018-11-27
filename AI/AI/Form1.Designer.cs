namespace AI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rez_intrare = new System.Windows.Forms.TextBox();
            this.tip_intrare = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prag_val = new System.Windows.Forms.NumericUpDown();
            this.g_val = new System.Windows.Forms.NumericUpDown();
            this.tip_functie = new System.Windows.Forms.ComboBox();
            this.rez_activare = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Binar = new System.Windows.Forms.CheckBox();
            this.rez_iesire = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Iesire = new System.Windows.Forms.TextBox();
            this.Intrari = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prag_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_val)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intrari)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rez_intrare);
            this.groupBox2.Controls.Add(this.tip_intrare);
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functia de intrare:";
            // 
            // rez_intrare
            // 
            this.rez_intrare.Location = new System.Drawing.Point(15, 22);
            this.rez_intrare.Name = "rez_intrare";
            this.rez_intrare.ReadOnly = true;
            this.rez_intrare.Size = new System.Drawing.Size(121, 20);
            this.rez_intrare.TabIndex = 1;
            // 
            // tip_intrare
            // 
            this.tip_intrare.FormattingEnabled = true;
            this.tip_intrare.Items.AddRange(new object[] {
            "Suma",
            "Produs",
            "Minim",
            "Maxim"});
            this.tip_intrare.Location = new System.Drawing.Point(15, 48);
            this.tip_intrare.Name = "tip_intrare";
            this.tip_intrare.Size = new System.Drawing.Size(121, 21);
            this.tip_intrare.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.prag_val);
            this.groupBox3.Controls.Add(this.g_val);
            this.groupBox3.Controls.Add(this.tip_functie);
            this.groupBox3.Controls.Add(this.rez_activare);
            this.groupBox3.Location = new System.Drawing.Point(213, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 140);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Functia de activare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "g:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prag:";
            // 
            // prag_val
            // 
            this.prag_val.Location = new System.Drawing.Point(84, 98);
            this.prag_val.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.prag_val.Name = "prag_val";
            this.prag_val.Size = new System.Drawing.Size(52, 20);
            this.prag_val.TabIndex = 5;
            // 
            // g_val
            // 
            this.g_val.DecimalPlaces = 2;
            this.g_val.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.g_val.Location = new System.Drawing.Point(84, 72);
            this.g_val.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.g_val.Name = "g_val";
            this.g_val.Size = new System.Drawing.Size(52, 20);
            this.g_val.TabIndex = 2;
            // 
            // tip_functie
            // 
            this.tip_functie.FormattingEnabled = true;
            this.tip_functie.Items.AddRange(new object[] {
            "Sigmoidala",
            "TanH",
            "Treapta",
            "Semn",
            "Rampa"});
            this.tip_functie.Location = new System.Drawing.Point(15, 45);
            this.tip_functie.Name = "tip_functie";
            this.tip_functie.Size = new System.Drawing.Size(121, 21);
            this.tip_functie.TabIndex = 1;
            // 
            // rez_activare
            // 
            this.rez_activare.Location = new System.Drawing.Point(15, 19);
            this.rez_activare.Name = "rez_activare";
            this.rez_activare.ReadOnly = true;
            this.rez_activare.Size = new System.Drawing.Size(121, 20);
            this.rez_activare.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Binar);
            this.groupBox4.Controls.Add(this.rez_iesire);
            this.groupBox4.Location = new System.Drawing.Point(213, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 71);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Functia de iesire:";
            // 
            // Binar
            // 
            this.Binar.AutoSize = true;
            this.Binar.Location = new System.Drawing.Point(46, 46);
            this.Binar.Name = "Binar";
            this.Binar.Size = new System.Drawing.Size(50, 17);
            this.Binar.TabIndex = 1;
            this.Binar.Text = "Binar";
            this.Binar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Binar.UseVisualStyleBackColor = true;
            // 
            // rez_iesire
            // 
            this.rez_iesire.Location = new System.Drawing.Point(6, 19);
            this.rez_iesire.Name = "rez_iesire";
            this.rez_iesire.ReadOnly = true;
            this.rez_iesire.Size = new System.Drawing.Size(121, 20);
            this.rez_iesire.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Iesire);
            this.groupBox5.Location = new System.Drawing.Point(369, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(142, 78);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Iesire";
            // 
            // Iesire
            // 
            this.Iesire.Location = new System.Drawing.Point(6, 22);
            this.Iesire.Name = "Iesire";
            this.Iesire.ReadOnly = true;
            this.Iesire.Size = new System.Drawing.Size(121, 20);
            this.Iesire.TabIndex = 0;
            // 
            // Intrari
            // 
            this.Intrari.Location = new System.Drawing.Point(83, 0);
            this.Intrari.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Intrari.Name = "Intrari";
            this.Intrari.Size = new System.Drawing.Size(52, 20);
            this.Intrari.TabIndex = 0;
            this.Intrari.ValueChanged += new System.EventHandler(this.Intrari_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Intrari);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 23);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date intrare:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 288);
            this.panel1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(522, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Perceptron";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prag_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_val)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intrari)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox tip_intrare;
        private System.Windows.Forms.TextBox rez_intrare;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox tip_functie;
        private System.Windows.Forms.TextBox rez_activare;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox Binar;
        private System.Windows.Forms.TextBox rez_iesire;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Iesire;
        private System.Windows.Forms.NumericUpDown Intrari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown prag_val;
        private System.Windows.Forms.NumericUpDown g_val;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

