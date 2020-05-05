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
            this.taxiLag.SuspendLayout();
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
            this.taxiLag.Location = new System.Drawing.Point(638, 383);
            this.taxiLag.Name = "taxiLag";
            this.taxiLag.Size = new System.Drawing.Size(132, 86);
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
            // 
            // HovedVindu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 665);
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
    }
}

