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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HovedVindu));
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.radioMandal = new System.Windows.Forms.RadioButton();
            this.radioVennesla = new System.Windows.Forms.RadioButton();
            this.radioAgder = new System.Windows.Forms.RadioButton();
            this.taxiLagBox = new System.Windows.Forms.GroupBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.kmBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.fremBox = new System.Windows.Forms.TextBox();
            this.tilBox = new System.Windows.Forms.TextBox();
            this.paxBox = new System.Windows.Forms.GroupBox();
            this.radioLiten = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioStor = new System.Windows.Forms.RadioButton();
            this.tidAgder = new System.Windows.Forms.GroupBox();
            this.radioAtDag = new System.Windows.Forms.RadioButton();
            this.radioAtKveld = new System.Windows.Forms.RadioButton();
            this.radioAtHoly = new System.Windows.Forms.RadioButton();
            this.tidMandal = new System.Windows.Forms.GroupBox();
            this.radioMtHoly = new System.Windows.Forms.RadioButton();
            this.radioMtHelg = new System.Windows.Forms.RadioButton();
            this.radioMtDag = new System.Windows.Forms.RadioButton();
            this.radioMtKveld = new System.Windows.Forms.RadioButton();
            this.radioMtLørdag = new System.Windows.Forms.RadioButton();
            this.tidVennesla = new System.Windows.Forms.GroupBox();
            this.radioVtHoly = new System.Windows.Forms.RadioButton();
            this.radioVtDag = new System.Windows.Forms.RadioButton();
            this.radioVtKveld = new System.Windows.Forms.RadioButton();
            this.radioVtHelg = new System.Windows.Forms.RadioButton();
            this.kmLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.fremLabel = new System.Windows.Forms.Label();
            this.tilLabel = new System.Windows.Forms.Label();
            this.toolKveldHelg = new System.Windows.Forms.ToolTip(this.components);
            this.toolDag = new System.Windows.Forms.ToolTip(this.components);
            this.toolKveldHverdag = new System.Windows.Forms.ToolTip(this.components);
            this.toolNattHelg = new System.Windows.Forms.ToolTip(this.components);
            this.toolHoly = new System.Windows.Forms.ToolTip(this.components);
            this.toolKveldMt = new System.Windows.Forms.ToolTip(this.components);
            this.toolLørdag = new System.Windows.Forms.ToolTip(this.components);
            this.toolNattMt = new System.Windows.Forms.ToolTip(this.components);
            this.copyButton = new System.Windows.Forms.Button();
            this.toolCopy = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takstinformasjonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versjonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avsluttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.resultGroupBox1 = new System.Windows.Forms.GroupBox();
            this.takstLabel1 = new System.Windows.Forms.Label();
            this.taxiLagBox.SuspendLayout();
            this.paxBox.SuspendLayout();
            this.tidAgder.SuspendLayout();
            this.tidMandal.SuspendLayout();
            this.tidVennesla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.resultGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(135, 73);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 48);
            this.calculateButton.TabIndex = 20;
            this.calculateButton.Text = "Kalkulèr";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculate_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(135, 17);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 48);
            this.resetButton.TabIndex = 19;
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
            this.radioMandal.TabIndex = 3;
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
            this.radioVennesla.TabIndex = 2;
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
            // taxiLagBox
            // 
            this.taxiLagBox.Controls.Add(this.radioAgder);
            this.taxiLagBox.Controls.Add(this.radioVennesla);
            this.taxiLagBox.Controls.Add(this.radioMandal);
            this.taxiLagBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxiLagBox.Location = new System.Drawing.Point(13, 30);
            this.taxiLagBox.Name = "taxiLagBox";
            this.taxiLagBox.Size = new System.Drawing.Size(168, 86);
            this.taxiLagBox.TabIndex = 3;
            this.taxiLagBox.TabStop = false;
            this.taxiLagBox.Text = "Taxilag:";
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(10, 45);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(119, 47);
            this.resultBox.TabIndex = 17;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // kmBox
            // 
            this.kmBox.Location = new System.Drawing.Point(191, 12);
            this.kmBox.Name = "kmBox";
            this.kmBox.Size = new System.Drawing.Size(39, 20);
            this.kmBox.TabIndex = 13;
            this.kmBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kmBox_KeyPress);
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(191, 38);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(39, 20);
            this.minBox.TabIndex = 14;
            this.minBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minBox_KeyPress);
            // 
            // fremBox
            // 
            this.fremBox.Location = new System.Drawing.Point(191, 64);
            this.fremBox.Name = "fremBox";
            this.fremBox.Size = new System.Drawing.Size(39, 20);
            this.fremBox.TabIndex = 15;
            this.fremBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fremBox_KeyPress);
            // 
            // tilBox
            // 
            this.tilBox.Location = new System.Drawing.Point(191, 90);
            this.tilBox.Name = "tilBox";
            this.tilBox.Size = new System.Drawing.Size(39, 20);
            this.tilBox.TabIndex = 16;
            this.tilBox.TextChanged += new System.EventHandler(this.tilBox_TextChanged);
            this.tilBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tilBox_KeyPress);
            // 
            // paxBox
            // 
            this.paxBox.Controls.Add(this.radioLiten);
            this.paxBox.Controls.Add(this.radioMedium);
            this.paxBox.Controls.Add(this.radioStor);
            this.paxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paxBox.Location = new System.Drawing.Point(13, 122);
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
            this.radioLiten.TabIndex = 4;
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
            this.radioMedium.TabIndex = 5;
            this.radioMedium.Text = "5-8 pax.";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioStor
            // 
            this.radioStor.AutoSize = true;
            this.radioStor.Location = new System.Drawing.Point(6, 65);
            this.radioStor.Name = "radioStor";
            this.radioStor.Size = new System.Drawing.Size(69, 17);
            this.radioStor.TabIndex = 6;
            this.radioStor.Text = "9-16 pax.";
            this.radioStor.UseVisualStyleBackColor = true;
            // 
            // tidAgder
            // 
            this.tidAgder.Controls.Add(this.radioAtDag);
            this.tidAgder.Controls.Add(this.radioAtKveld);
            this.tidAgder.Controls.Add(this.radioAtHoly);
            this.tidAgder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidAgder.Location = new System.Drawing.Point(13, 214);
            this.tidAgder.Name = "tidAgder";
            this.tidAgder.Size = new System.Drawing.Size(168, 86);
            this.tidAgder.TabIndex = 8;
            this.tidAgder.TabStop = false;
            this.tidAgder.Text = "Tidspunkt";
            this.tidAgder.Visible = false;
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
            this.toolDag.SetToolTip(this.radioAtDag, "06:00 - 20:00 alle hverdager.");
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
            this.radioAtKveld.Text = "Kveld/Helg";
            this.toolKveldHelg.SetToolTip(this.radioAtKveld, "Hverdager 20:00-06:00. Fredag kl 2000 til 06:00 mandag morgen.");
            this.radioAtKveld.UseVisualStyleBackColor = true;
            // 
            // radioAtHoly
            // 
            this.radioAtHoly.AutoSize = true;
            this.radioAtHoly.Location = new System.Drawing.Point(6, 65);
            this.radioAtHoly.Name = "radioAtHoly";
            this.radioAtHoly.Size = new System.Drawing.Size(69, 17);
            this.radioAtHoly.TabIndex = 1;
            this.radioAtHoly.Text = "Helligdag";
            this.toolHoly.SetToolTip(this.radioAtHoly, resources.GetString("radioAtHoly.ToolTip"));
            this.radioAtHoly.UseVisualStyleBackColor = true;
            // 
            // tidMandal
            // 
            this.tidMandal.Controls.Add(this.radioMtHoly);
            this.tidMandal.Controls.Add(this.radioMtHelg);
            this.tidMandal.Controls.Add(this.radioMtDag);
            this.tidMandal.Controls.Add(this.radioMtKveld);
            this.tidMandal.Controls.Add(this.radioMtLørdag);
            this.tidMandal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidMandal.Location = new System.Drawing.Point(13, 214);
            this.tidMandal.Name = "tidMandal";
            this.tidMandal.Size = new System.Drawing.Size(168, 136);
            this.tidMandal.TabIndex = 10;
            this.tidMandal.TabStop = false;
            this.tidMandal.Text = "Tidspunkt";
            this.tidMandal.Visible = false;
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
            this.toolHoly.SetToolTip(this.radioMtHoly, resources.GetString("radioMtHoly.ToolTip"));
            this.radioMtHoly.UseVisualStyleBackColor = true;
            // 
            // radioMtHelg
            // 
            this.radioMtHelg.AutoSize = true;
            this.radioMtHelg.Location = new System.Drawing.Point(6, 88);
            this.radioMtHelg.Name = "radioMtHelg";
            this.radioMtHelg.Size = new System.Drawing.Size(72, 17);
            this.radioMtHelg.TabIndex = 2;
            this.radioMtHelg.Text = "Helg/Natt";
            this.toolNattMt.SetToolTip(this.radioMtHelg, "Mandag-Lørdag 00:00-06:00. Lørdag kl 15:00 til mandag kl 06:00.");
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
            this.radioMtDag.Text = "Dagtid";
            this.toolDag.SetToolTip(this.radioMtDag, "06:00 - 18:00 alle hverdager.");
            this.radioMtDag.UseVisualStyleBackColor = true;
            // 
            // radioMtKveld
            // 
            this.radioMtKveld.AutoSize = true;
            this.radioMtKveld.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioMtKveld.Location = new System.Drawing.Point(6, 42);
            this.radioMtKveld.Name = "radioMtKveld";
            this.radioMtKveld.Size = new System.Drawing.Size(100, 17);
            this.radioMtKveld.TabIndex = 1;
            this.radioMtKveld.Text = "Kveld (hverdag)";
            this.toolKveldMt.SetToolTip(this.radioMtKveld, "Mandag-fredag kl 18:00 - 00:00.");
            this.radioMtKveld.UseVisualStyleBackColor = true;
            // 
            // radioMtLørdag
            // 
            this.radioMtLørdag.AutoSize = true;
            this.radioMtLørdag.Location = new System.Drawing.Point(6, 65);
            this.radioMtLørdag.Name = "radioMtLørdag";
            this.radioMtLørdag.Size = new System.Drawing.Size(96, 17);
            this.radioMtLørdag.TabIndex = 1;
            this.radioMtLørdag.Text = "Lørdag (dagtid)";
            this.toolLørdag.SetToolTip(this.radioMtLørdag, "Kl. 06:00 - 15:00");
            this.radioMtLørdag.UseVisualStyleBackColor = true;
            // 
            // tidVennesla
            // 
            this.tidVennesla.Controls.Add(this.radioVtHoly);
            this.tidVennesla.Controls.Add(this.radioVtDag);
            this.tidVennesla.Controls.Add(this.radioVtKveld);
            this.tidVennesla.Controls.Add(this.radioVtHelg);
            this.tidVennesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidVennesla.Location = new System.Drawing.Point(13, 214);
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
            this.toolHoly.SetToolTip(this.radioVtHoly, resources.GetString("radioVtHoly.ToolTip"));
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
            this.toolDag.SetToolTip(this.radioVtDag, "06:00 - 20:00 alle hverdager.");
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
            this.toolKveldHverdag.SetToolTip(this.radioVtKveld, "20:00 - 06:00 mandag-torsdag. Lørdag: 06:00 - 18:00. Fra og med 06:00 søndag.");
            this.radioVtKveld.UseVisualStyleBackColor = true;
            // 
            // radioVtHelg
            // 
            this.radioVtHelg.AutoSize = true;
            this.radioVtHelg.Location = new System.Drawing.Point(6, 65);
            this.radioVtHelg.Name = "radioVtHelg";
            this.radioVtHelg.Size = new System.Drawing.Size(74, 17);
            this.radioVtHelg.TabIndex = 1;
            this.radioVtHelg.TabStop = true;
            this.radioVtHelg.Text = "Natt (helg)";
            this.toolNattHelg.SetToolTip(this.radioVtHelg, "Fredag kl 20:00 - lørdag kl 06:00. Lørdag kl 18:00 - søndag kl 06:00.");
            this.radioVtHelg.UseVisualStyleBackColor = true;
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Location = new System.Drawing.Point(132, 16);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(53, 13);
            this.kmLabel.TabIndex = 11;
            this.kmLabel.Text = "Kilometer:";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(137, 41);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(48, 13);
            this.minLabel.TabIndex = 11;
            this.minLabel.Text = "Minutter:";
            // 
            // fremLabel
            // 
            this.fremLabel.AutoSize = true;
            this.fremLabel.Location = new System.Drawing.Point(121, 67);
            this.fremLabel.Name = "fremLabel";
            this.fremLabel.Size = new System.Drawing.Size(64, 13);
            this.fremLabel.TabIndex = 11;
            this.fremLabel.Text = "Fremkjøring:";
            this.fremLabel.Click += new System.EventHandler(this.fremLabel_Click);
            // 
            // tilLabel
            // 
            this.tilLabel.AutoSize = true;
            this.tilLabel.Location = new System.Drawing.Point(144, 93);
            this.tilLabel.Name = "tilLabel";
            this.tilLabel.Size = new System.Drawing.Size(41, 13);
            this.tilLabel.TabIndex = 11;
            this.tilLabel.Text = "Tillegg:";
            // 
            // toolKveldHelg
            // 
            this.toolKveldHelg.ToolTipTitle = "Kveld/Helg";
            // 
            // toolDag
            // 
            this.toolDag.ToolTipTitle = "Dagtid";
            // 
            // toolKveldHverdag
            // 
            this.toolKveldHverdag.ToolTipTitle = "Kveld hverdag/Dagtid helg";
            // 
            // toolNattHelg
            // 
            this.toolNattHelg.ToolTipTitle = "Natt (helg)";
            // 
            // toolHoly
            // 
            this.toolHoly.ToolTipTitle = "Helligdager";
            // 
            // toolKveldMt
            // 
            this.toolKveldMt.ToolTipTitle = "Kveld hverdag";
            // 
            // toolLørdag
            // 
            this.toolLørdag.ToolTipTitle = "Lørdag";
            // 
            // toolNattMt
            // 
            this.toolNattMt.ToolTipTitle = "Natt og helg";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(54, 96);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 18;
            this.copyButton.Text = "Kopier pris";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // toolCopy
            // 
            this.toolCopy.ToolTipTitle = "Kopiert!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(58, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 28);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takstinformasjonToolStripMenuItem,
            this.versjonToolStripMenuItem,
            this.avsluttToolStripMenuItem});
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.omToolStripMenuItem.Text = "&Fil";
            this.omToolStripMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // takstinformasjonToolStripMenuItem
            // 
            this.takstinformasjonToolStripMenuItem.Name = "takstinformasjonToolStripMenuItem";
            this.takstinformasjonToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.takstinformasjonToolStripMenuItem.Text = "Takstinformasjon";
            this.takstinformasjonToolStripMenuItem.Click += new System.EventHandler(this.takstinformasjonToolStripMenuItem_Click);
            // 
            // versjonToolStripMenuItem
            // 
            this.versjonToolStripMenuItem.Name = "versjonToolStripMenuItem";
            this.versjonToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.versjonToolStripMenuItem.Text = "Versjon";
            this.versjonToolStripMenuItem.Click += new System.EventHandler(this.versjonToolStripMenuItem_Click);
            // 
            // avsluttToolStripMenuItem
            // 
            this.avsluttToolStripMenuItem.Name = "avsluttToolStripMenuItem";
            this.avsluttToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.avsluttToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.avsluttToolStripMenuItem.Text = "&Avslutt";
            this.avsluttToolStripMenuItem.Click += new System.EventHandler(this.avsluttToolStripMenuItem_Click);
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.Location = new System.Drawing.Point(61, 113);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(168, 13);
            this.inputLabel1.TabIndex = 21;
            this.inputLabel1.Text = "NB: Desimaler skilles med komma.";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.kmLabel);
            this.inputGroupBox.Controls.Add(this.inputLabel1);
            this.inputGroupBox.Controls.Add(this.kmBox);
            this.inputGroupBox.Controls.Add(this.minBox);
            this.inputGroupBox.Controls.Add(this.fremBox);
            this.inputGroupBox.Controls.Add(this.tilBox);
            this.inputGroupBox.Controls.Add(this.tilLabel);
            this.inputGroupBox.Controls.Add(this.minLabel);
            this.inputGroupBox.Controls.Add(this.fremLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(187, 95);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(235, 130);
            this.inputGroupBox.TabIndex = 22;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input:";
            // 
            // resultGroupBox1
            // 
            this.resultGroupBox1.Controls.Add(this.resetButton);
            this.resultGroupBox1.Controls.Add(this.calculateButton);
            this.resultGroupBox1.Controls.Add(this.pictureBox1);
            this.resultGroupBox1.Controls.Add(this.resultBox);
            this.resultGroupBox1.Controls.Add(this.copyButton);
            this.resultGroupBox1.Location = new System.Drawing.Point(187, 228);
            this.resultGroupBox1.Name = "resultGroupBox1";
            this.resultGroupBox1.Size = new System.Drawing.Size(235, 122);
            this.resultGroupBox1.TabIndex = 23;
            this.resultGroupBox1.TabStop = false;
            this.resultGroupBox1.Text = "Resultat:";
            // 
            // takstLabel1
            // 
            this.takstLabel1.AutoSize = true;
            this.takstLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takstLabel1.Location = new System.Drawing.Point(194, 39);
            this.takstLabel1.Name = "takstLabel1";
            this.takstLabel1.Size = new System.Drawing.Size(180, 13);
            this.takstLabel1.TabIndex = 24;
            this.takstLabel1.Text = "Takster oppdatert: 19.05.2020";
            // 
            // HovedVindu
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 355);
            this.Controls.Add(this.takstLabel1);
            this.Controls.Add(this.resultGroupBox1);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.tidMandal);
            this.Controls.Add(this.tidVennesla);
            this.Controls.Add(this.tidAgder);
            this.Controls.Add(this.paxBox);
            this.Controls.Add(this.taxiLagBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HovedVindu";
            this.Text = "07000 Priskalkulator";
            this.Load += new System.EventHandler(this.HovedVindu_Load);
            this.taxiLagBox.ResumeLayout(false);
            this.taxiLagBox.PerformLayout();
            this.paxBox.ResumeLayout(false);
            this.paxBox.PerformLayout();
            this.tidAgder.ResumeLayout(false);
            this.tidAgder.PerformLayout();
            this.tidMandal.ResumeLayout(false);
            this.tidMandal.PerformLayout();
            this.tidVennesla.ResumeLayout(false);
            this.tidVennesla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.resultGroupBox1.ResumeLayout(false);
            this.resultGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RadioButton radioMandal;
        private System.Windows.Forms.RadioButton radioVennesla;
        public System.Windows.Forms.RadioButton radioAgder;
        private System.Windows.Forms.GroupBox taxiLagBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox kmBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox fremBox;
        private System.Windows.Forms.TextBox tilBox;
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
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label fremLabel;
        private System.Windows.Forms.Label tilLabel;
        private System.Windows.Forms.ToolTip toolKveldHelg;
        private System.Windows.Forms.ToolTip toolDag;
        private System.Windows.Forms.ToolTip toolKveldHverdag;
        private System.Windows.Forms.ToolTip toolNattHelg;
        private System.Windows.Forms.ToolTip toolHoly;
        private System.Windows.Forms.ToolTip toolNattMt;
        private System.Windows.Forms.ToolTip toolKveldMt;
        private System.Windows.Forms.ToolTip toolLørdag;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ToolTip toolCopy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takstinformasjonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versjonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avsluttToolStripMenuItem;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox resultGroupBox1;
        private System.Windows.Forms.Label takstLabel1;
    }
}

