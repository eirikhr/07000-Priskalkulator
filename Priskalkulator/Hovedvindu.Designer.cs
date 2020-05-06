namespace Priskalkulator
{
    partial class HovedVindu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HovedVindu));
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.radioMandal = new System.Windows.Forms.RadioButton();
            this.radioVennesla = new System.Windows.Forms.RadioButton();
            this.radioAgder = new System.Windows.Forms.RadioButton();
            this.taxiLag = new System.Windows.Forms.GroupBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.paxBox = new System.Windows.Forms.GroupBox();
            this.radioLiten = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioStor = new System.Windows.Forms.RadioButton();
            this.tidAgder = new System.Windows.Forms.GroupBox();
            this.tidMandal = new System.Windows.Forms.GroupBox();
            this.tidVennesla = new System.Windows.Forms.GroupBox();
            this.radioVtHoly = new System.Windows.Forms.RadioButton();
            this.radioVtDag = new System.Windows.Forms.RadioButton();
            this.radioVtKveld = new System.Windows.Forms.RadioButton();
            this.radioVtHelg = new System.Windows.Forms.RadioButton();
            this.radioMtHoly = new System.Windows.Forms.RadioButton();
            this.radioMtHelg = new System.Windows.Forms.RadioButton();
            this.radioMtDag = new System.Windows.Forms.RadioButton();
            this.radioMtKveld = new System.Windows.Forms.RadioButton();
            this.radioMtLørdag = new System.Windows.Forms.RadioButton();
            this.radioAtDag = new System.Windows.Forms.RadioButton();
            this.radioAtKveld = new System.Windows.Forms.RadioButton();
            this.radioAtHoly = new System.Windows.Forms.RadioButton();
            this.taxiLag.SuspendLayout();
            this.paxBox.SuspendLayout();
            this.tidAgder.SuspendLayout();
            this.tidMandal.SuspendLayout();
            this.tidVennesla.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.calculateButton.Location = new System.Drawing.Point(644, 567);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 86);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Kalkulèr";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculate_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.resetButton.Location = new System.Drawing.Point(644, 475);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(126, 86);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Nullstill";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.reset_Click);
            // 
            // radioMandal
            // 
            this.radioMandal.AutoSize = true;
            this.radioMandal.Location = new System.Drawing.Point(6, 65);
            this.radioMandal.Name = "radioMandal";
            this.radioMandal.Size = new System.Drawing.Size(116, 17);
            this.radioMandal.TabIndex = 1;
            this.radioMandal.TabStop = true;
            this.radioMandal.Text = "07000 Mandal Taxi";
            this.radioMandal.UseVisualStyleBackColor = true;
            this.radioMandal.CheckedChanged += new System.EventHandler(this.radioMandal_CheckedChanged);
            // 
            // radioVennesla
            // 
            this.radioVennesla.AutoSize = true;
            this.radioVennesla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioVennesla.Location = new System.Drawing.Point(6, 42);
            this.radioVennesla.Name = "radioVennesla";
            this.radioVennesla.Size = new System.Drawing.Size(125, 17);
            this.radioVennesla.TabIndex = 1;
            this.radioVennesla.TabStop = true;
            this.radioVennesla.Text = "07000 Vennesla Taxi";
            this.radioVennesla.UseVisualStyleBackColor = true;
            this.radioVennesla.CheckedChanged += new System.EventHandler(this.radioVennesla_CheckedChanged);
            // 
            // radioAgder
            // 
            this.radioAgder.AutoSize = true;
            this.radioAgder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioAgder.Location = new System.Drawing.Point(6, 19);
            this.radioAgder.Name = "radioAgder";
            this.radioAgder.Size = new System.Drawing.Size(109, 17);
            this.radioAgder.TabIndex = 1;
            this.radioAgder.TabStop = true;
            this.radioAgder.Text = "07000 Agder Taxi";
            this.radioAgder.UseVisualStyleBackColor = true;
            this.radioAgder.CheckedChanged += new System.EventHandler(this.radioAgder_CheckedChanged);
            // 
            // taxiLag
            // 
            this.taxiLag.Controls.Add(this.radioAgder);
            this.taxiLag.Controls.Add(this.radioVennesla);
            this.taxiLag.Controls.Add(this.radioMandal);
            this.taxiLag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxiLag.Location = new System.Drawing.Point(602, 12);
            this.taxiLag.Name = "taxiLag";
            this.taxiLag.Size = new System.Drawing.Size(168, 86);
            this.taxiLag.TabIndex = 3;
            this.taxiLag.TabStop = false;
            this.taxiLag.Text = "Taxilag:";
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(464, 606);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(143, 47);
            this.resultBox.TabIndex = 4;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(73, 154);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // paxBox
            // 
            this.paxBox.Controls.Add(this.radioLiten);
            this.paxBox.Controls.Add(this.radioMedium);
            this.paxBox.Controls.Add(this.radioStor);
            this.paxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paxBox.Location = new System.Drawing.Point(602, 104);
            this.paxBox.Name = "paxBox";
            this.paxBox.Size = new System.Drawing.Size(168, 86);
            this.paxBox.TabIndex = 7;
            this.paxBox.TabStop = false;
            this.paxBox.Text = "Passasjerer:";
            // 
            // radioLiten
            // 
            this.radioLiten.AutoSize = true;
            this.radioLiten.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioLiten.Location = new System.Drawing.Point(6, 19);
            this.radioLiten.Name = "radioLiten";
            this.radioLiten.Size = new System.Drawing.Size(63, 17);
            this.radioLiten.TabIndex = 1;
            this.radioLiten.TabStop = true;
            this.radioLiten.Text = "1-4 pax.";
            this.radioLiten.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioMedium.Location = new System.Drawing.Point(6, 42);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(63, 17);
            this.radioMedium.TabIndex = 1;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "5-8 pax.";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioStor
            // 
            this.radioStor.AutoSize = true;
            this.radioStor.Location = new System.Drawing.Point(6, 65);
            this.radioStor.Name = "radioStor";
            this.radioStor.Size = new System.Drawing.Size(69, 17);
            this.radioStor.TabIndex = 1;
            this.radioStor.TabStop = true;
            this.radioStor.Text = "9-16 pax.";
            this.radioStor.UseVisualStyleBackColor = true;
            // 
            // tidAgder
            // 
            this.tidAgder.Controls.Add(this.radioAtDag);
            this.tidAgder.Controls.Add(this.radioAtKveld);
            this.tidAgder.Controls.Add(this.radioAtHoly);
            this.tidAgder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidAgder.Location = new System.Drawing.Point(602, 196);
            this.tidAgder.Name = "tidAgder";
            this.tidAgder.Size = new System.Drawing.Size(168, 86);
            this.tidAgder.TabIndex = 8;
            this.tidAgder.TabStop = false;
            this.tidAgder.Text = "Tidspunkt";
            this.tidAgder.Visible = false;
            // 
            // tidMandal
            // 
            this.tidMandal.Controls.Add(this.radioMtHoly);
            this.tidMandal.Controls.Add(this.radioMtHelg);
            this.tidMandal.Controls.Add(this.radioMtDag);
            this.tidMandal.Controls.Add(this.radioMtKveld);
            this.tidMandal.Controls.Add(this.radioMtLørdag);
            this.tidMandal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidMandal.Location = new System.Drawing.Point(602, 196);
            this.tidMandal.Name = "tidMandal";
            this.tidMandal.Size = new System.Drawing.Size(168, 136);
            this.tidMandal.TabIndex = 10;
            this.tidMandal.TabStop = false;
            this.tidMandal.Text = "Tidspunkt";
            this.tidMandal.Visible = false;
            // 
            // tidVennesla
            // 
            this.tidVennesla.Controls.Add(this.radioVtHoly);
            this.tidVennesla.Controls.Add(this.radioVtDag);
            this.tidVennesla.Controls.Add(this.radioVtKveld);
            this.tidVennesla.Controls.Add(this.radioVtHelg);
            this.tidVennesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidVennesla.Location = new System.Drawing.Point(602, 196);
            this.tidVennesla.Name = "tidVennesla";
            this.tidVennesla.Size = new System.Drawing.Size(168, 108);
            this.tidVennesla.TabIndex = 9;
            this.tidVennesla.TabStop = false;
            this.tidVennesla.Text = "Tidspunkt";
            this.tidVennesla.Visible = false;
            // 
            // radioVtHoly
            // 
            this.radioVtHoly.AutoSize = true;
            this.radioVtHoly.Location = new System.Drawing.Point(6, 88);
            this.radioVtHoly.Name = "radioVtHoly";
            this.radioVtHoly.Size = new System.Drawing.Size(69, 17);
            this.radioVtHoly.TabIndex = 2;
            this.radioVtHoly.TabStop = true;
            this.radioVtHoly.Text = "Helligdag";
            this.radioVtHoly.UseVisualStyleBackColor = true;
            // 
            // radioVtDag
            // 
            this.radioVtDag.AutoSize = true;
            this.radioVtDag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioVtDag.Location = new System.Drawing.Point(6, 19);
            this.radioVtDag.Name = "radioVtDag";
            this.radioVtDag.Size = new System.Drawing.Size(56, 17);
            this.radioVtDag.TabIndex = 1;
            this.radioVtDag.TabStop = true;
            this.radioVtDag.Text = "Dagtid";
            this.radioVtDag.UseVisualStyleBackColor = true;
            // 
            // radioVtKveld
            // 
            this.radioVtKveld.AutoSize = true;
            this.radioVtKveld.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioVtKveld.Location = new System.Drawing.Point(6, 42);
            this.radioVtKveld.Name = "radioVtKveld";
            this.radioVtKveld.Size = new System.Drawing.Size(160, 17);
            this.radioVtKveld.TabIndex = 1;
            this.radioVtKveld.TabStop = true;
            this.radioVtKveld.Text = "Kveld (hverdag) / Dag (helg)";
            this.radioVtKveld.UseVisualStyleBackColor = true;
            // 
            // radioVtHelg
            // 
            this.radioVtHelg.AutoSize = true;
            this.radioVtHelg.Location = new System.Drawing.Point(6, 65);
            this.radioVtHelg.Name = "radioVtHelg";
            this.radioVtHelg.Size = new System.Drawing.Size(81, 17);
            this.radioVtHelg.TabIndex = 1;
            this.radioVtHelg.TabStop = true;
            this.radioVtHelg.Text = "Kveld (helg)";
            this.radioVtHelg.UseVisualStyleBackColor = true;
            // 
            // radioMtHoly
            // 
            this.radioMtHoly.AutoSize = true;
            this.radioMtHoly.Location = new System.Drawing.Point(6, 111);
            this.radioMtHoly.Name = "radioMtHoly";
            this.radioMtHoly.Size = new System.Drawing.Size(69, 17);
            this.radioMtHoly.TabIndex = 3;
            this.radioMtHoly.TabStop = true;
            this.radioMtHoly.Text = "Helligdag";
            this.radioMtHoly.UseVisualStyleBackColor = true;
            // 
            // radioMtHelg
            // 
            this.radioMtHelg.AutoSize = true;
            this.radioMtHelg.Location = new System.Drawing.Point(6, 88);
            this.radioMtHelg.Name = "radioMtHelg";
            this.radioMtHelg.Size = new System.Drawing.Size(72, 17);
            this.radioMtHelg.TabIndex = 2;
            this.radioMtHelg.TabStop = true;
            this.radioMtHelg.Text = "Helg/Natt";
            this.radioMtHelg.UseVisualStyleBackColor = true;
            // 
            // radioMtDag
            // 
            this.radioMtDag.AutoSize = true;
            this.radioMtDag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioMtDag.Location = new System.Drawing.Point(6, 19);
            this.radioMtDag.Name = "radioMtDag";
            this.radioMtDag.Size = new System.Drawing.Size(56, 17);
            this.radioMtDag.TabIndex = 1;
            this.radioMtDag.TabStop = true;
            this.radioMtDag.Text = "Dagtid";
            this.radioMtDag.UseVisualStyleBackColor = true;
            // 
            // radioMtKveld
            // 
            this.radioMtKveld.AutoSize = true;
            this.radioMtKveld.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioMtKveld.Location = new System.Drawing.Point(6, 42);
            this.radioMtKveld.Name = "radioMtKveld";
            this.radioMtKveld.Size = new System.Drawing.Size(52, 17);
            this.radioMtKveld.TabIndex = 1;
            this.radioMtKveld.TabStop = true;
            this.radioMtKveld.Text = "Kveld";
            this.radioMtKveld.UseVisualStyleBackColor = true;
            // 
            // radioMtLørdag
            // 
            this.radioMtLørdag.AutoSize = true;
            this.radioMtLørdag.Location = new System.Drawing.Point(6, 65);
            this.radioMtLørdag.Name = "radioMtLørdag";
            this.radioMtLørdag.Size = new System.Drawing.Size(58, 17);
            this.radioMtLørdag.TabIndex = 1;
            this.radioMtLørdag.TabStop = true;
            this.radioMtLørdag.Text = "Lørdag";
            this.radioMtLørdag.UseVisualStyleBackColor = true;
            // 
            // radioAtDag
            // 
            this.radioAtDag.AutoSize = true;
            this.radioAtDag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioAtDag.Location = new System.Drawing.Point(6, 19);
            this.radioAtDag.Name = "radioAtDag";
            this.radioAtDag.Size = new System.Drawing.Size(56, 17);
            this.radioAtDag.TabIndex = 1;
            this.radioAtDag.TabStop = true;
            this.radioAtDag.Text = "Dagtid";
            this.radioAtDag.UseVisualStyleBackColor = true;
            // 
            // radioAtKveld
            // 
            this.radioAtKveld.AutoSize = true;
            this.radioAtKveld.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioAtKveld.Location = new System.Drawing.Point(6, 42);
            this.radioAtKveld.Name = "radioAtKveld";
            this.radioAtKveld.Size = new System.Drawing.Size(79, 17);
            this.radioAtKveld.TabIndex = 1;
            this.radioAtKveld.TabStop = true;
            this.radioAtKveld.Text = "Kveld/Helg";
            this.radioAtKveld.UseVisualStyleBackColor = true;
            // 
            // radioAtHoly
            // 
            this.radioAtHoly.AutoSize = true;
            this.radioAtHoly.Location = new System.Drawing.Point(6, 65);
            this.radioAtHoly.Name = "radioAtHoly";
            this.radioAtHoly.Size = new System.Drawing.Size(69, 17);
            this.radioAtHoly.TabIndex = 1;
            this.radioAtHoly.TabStop = true;
            this.radioAtHoly.Text = "Helligdag";
            this.radioAtHoly.UseVisualStyleBackColor = true;
            // 
            // HovedVindu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 665);
            this.Controls.Add(this.tidMandal);
            this.Controls.Add(this.tidVennesla);
            this.Controls.Add(this.tidAgder);
            this.Controls.Add(this.paxBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.taxiLag);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HovedVindu";
            this.Text = "07000 Priskalkulator";
            this.taxiLag.ResumeLayout(false);
            this.taxiLag.PerformLayout();
            this.paxBox.ResumeLayout(false);
            this.paxBox.PerformLayout();
            this.tidAgder.ResumeLayout(false);
            this.tidAgder.PerformLayout();
            this.tidMandal.ResumeLayout(false);
            this.tidMandal.PerformLayout();
            this.tidVennesla.ResumeLayout(false);
            this.tidVennesla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RadioButton radioMandal;
        private System.Windows.Forms.RadioButton radioVennesla;
        public System.Windows.Forms.RadioButton radioAgder;
        private System.Windows.Forms.GroupBox taxiLag;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox paxBox;
        public System.Windows.Forms.RadioButton radioLiten;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioStor;
        private System.Windows.Forms.GroupBox tidAgder;
        public System.Windows.Forms.RadioButton radioAtDag;
        private System.Windows.Forms.RadioButton radioAtKveld;
        private System.Windows.Forms.RadioButton radioAtHoly;
        private System.Windows.Forms.GroupBox tidVennesla;
        private System.Windows.Forms.RadioButton radioVtHoly;
        public System.Windows.Forms.RadioButton radioVtDag;
        private System.Windows.Forms.RadioButton radioVtKveld;
        private System.Windows.Forms.RadioButton radioVtHelg;
        private System.Windows.Forms.GroupBox tidMandal;
        private System.Windows.Forms.RadioButton radioMtHelg;
        public System.Windows.Forms.RadioButton radioMtDag;
        private System.Windows.Forms.RadioButton radioMtKveld;
        private System.Windows.Forms.RadioButton radioMtLørdag;
        private System.Windows.Forms.RadioButton radioMtHoly;
    }
}

