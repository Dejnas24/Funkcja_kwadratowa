namespace Funkcja_Kwadratowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wykresfunkcji = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txBA = new System.Windows.Forms.TextBox();
            this.txBB = new System.Windows.Forms.TextBox();
            this.txBC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDelta = new System.Windows.Forms.Label();
            this.labelX01 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelxy = new System.Windows.Forms.Label();
            this.btOblicz = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btWyczysc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijProgramToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obliczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.wyczyscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyćObliczeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćWykresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.kolorWykresuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTłaWykresuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.zapiszWykresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btWyczyscwykres = new System.Windows.Forms.Button();
            this.btWyczyscobliczenia = new System.Windows.Forms.Button();
            this.btKolorwykresu = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btKolortla = new System.Windows.Forms.Button();
            this.MenuKontektowe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obliczToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.wyczyśćDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyścDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćWykresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszWykresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.kolorTłaWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.zapiszDaneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajDaneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijProgramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.WczytajopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ZapiszsaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btZapisz = new System.Windows.Forms.Button();
            this.btWczytaj = new System.Windows.Forms.Button();
            this.btZapiszWykres = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ZapiszWykresFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wykresfunkcji)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MenuKontektowe.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wykresfunkcji
            // 
            this.wykresfunkcji.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.wykresfunkcji.BorderlineWidth = 4;
            chartArea3.Name = "ChartArea1";
            this.wykresfunkcji.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.wykresfunkcji.Legends.Add(legend3);
            this.wykresfunkcji.Location = new System.Drawing.Point(16, 24);
            this.wykresfunkcji.Margin = new System.Windows.Forms.Padding(2);
            this.wykresfunkcji.Name = "wykresfunkcji";
            this.wykresfunkcji.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 2;
            series3.MarkerSize = 10;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Wykres funkcji";
            series3.ShadowColor = System.Drawing.Color.Purple;
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.wykresfunkcji.Series.Add(series3);
            this.wykresfunkcji.Size = new System.Drawing.Size(573, 537);
            this.wykresfunkcji.TabIndex = 13;
            this.wykresfunkcji.Text = "Wykres funkcji";
            // 
            // txBA
            // 
            this.txBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txBA.Location = new System.Drawing.Point(50, 89);
            this.txBA.Margin = new System.Windows.Forms.Padding(2);
            this.txBA.Multiline = true;
            this.txBA.Name = "txBA";
            this.txBA.Size = new System.Drawing.Size(55, 35);
            this.txBA.TabIndex = 1;
            // 
            // txBB
            // 
            this.txBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txBB.Location = new System.Drawing.Point(148, 89);
            this.txBB.Margin = new System.Windows.Forms.Padding(2);
            this.txBB.Multiline = true;
            this.txBB.Name = "txBB";
            this.txBB.Size = new System.Drawing.Size(55, 35);
            this.txBB.TabIndex = 2;
            // 
            // txBC
            // 
            this.txBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txBC.Location = new System.Drawing.Point(247, 89);
            this.txBC.Margin = new System.Windows.Forms.Padding(2);
            this.txBC.Multiline = true;
            this.txBC.Name = "txBC";
            this.txBC.Size = new System.Drawing.Size(55, 35);
            this.txBC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "A =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(108, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "B =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(206, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "C =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Podaj funkcję kwadratową:";
            // 
            // labelDelta
            // 
            this.labelDelta.AutoSize = true;
            this.labelDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDelta.Location = new System.Drawing.Point(8, 31);
            this.labelDelta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDelta.Name = "labelDelta";
            this.labelDelta.Size = new System.Drawing.Size(0, 20);
            this.labelDelta.TabIndex = 8;
            // 
            // labelX01
            // 
            this.labelX01.AutoSize = true;
            this.labelX01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelX01.Location = new System.Drawing.Point(8, 103);
            this.labelX01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX01.Name = "labelX01";
            this.labelX01.Size = new System.Drawing.Size(0, 20);
            this.labelX01.TabIndex = 9;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelX2.Location = new System.Drawing.Point(115, 103);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(0, 20);
            this.labelX2.TabIndex = 10;
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdpowiedz.Location = new System.Drawing.Point(8, 68);
            this.labelOdpowiedz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(0, 20);
            this.labelOdpowiedz.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.labelxy);
            this.groupBox1.Controls.Add(this.labelDelta);
            this.groupBox1.Controls.Add(this.labelOdpowiedz);
            this.groupBox1.Controls.Add(this.labelX01);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(13, 228);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(303, 168);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Równanie kwadratowe wyniki:";
            // 
            // labelxy
            // 
            this.labelxy.AutoSize = true;
            this.labelxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelxy.Location = new System.Drawing.Point(8, 137);
            this.labelxy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelxy.Name = "labelxy";
            this.labelxy.Size = new System.Drawing.Size(0, 16);
            this.labelxy.TabIndex = 12;
            // 
            // btOblicz
            // 
            this.btOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOblicz.Location = new System.Drawing.Point(13, 140);
            this.btOblicz.Margin = new System.Windows.Forms.Padding(2);
            this.btOblicz.Name = "btOblicz";
            this.btOblicz.Size = new System.Drawing.Size(288, 63);
            this.btOblicz.TabIndex = 4;
            this.btOblicz.Text = "Oblicz";
            this.btOblicz.UseVisualStyleBackColor = true;
            this.btOblicz.Click += new System.EventHandler(this.btOblicz_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wykresfunkcji);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(332, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(603, 576);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wykres funkcji:";
            // 
            // btWyczysc
            // 
            this.btWyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWyczysc.Location = new System.Drawing.Point(8, 27);
            this.btWyczysc.Margin = new System.Windows.Forms.Padding(2);
            this.btWyczysc.Name = "btWyczysc";
            this.btWyczysc.Size = new System.Drawing.Size(283, 28);
            this.btWyczysc.TabIndex = 5;
            this.btWyczysc.Text = "Wyczyść dane";
            this.btWyczysc.UseVisualStyleBackColor = true;
            this.btWyczysc.Click += new System.EventHandler(this.btWyczysc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem1,
            this.plikToolStripMenuItem,
            this.operacjeToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem1
            // 
            this.plikToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszDaneToolStripMenuItem,
            this.wczytajDaneToolStripMenuItem,
            this.toolStripMenuItem7,
            this.zamknijProgramToolStripMenuItem2});
            this.plikToolStripMenuItem1.Name = "plikToolStripMenuItem1";
            this.plikToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem1.Text = "Plik";
            // 
            // zapiszDaneToolStripMenuItem
            // 
            this.zapiszDaneToolStripMenuItem.Name = "zapiszDaneToolStripMenuItem";
            this.zapiszDaneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszDaneToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.zapiszDaneToolStripMenuItem.Text = "Zapisz dane";
            this.zapiszDaneToolStripMenuItem.Click += new System.EventHandler(this.zapiszDaneToolStripMenuItem_Click);
            // 
            // wczytajDaneToolStripMenuItem
            // 
            this.wczytajDaneToolStripMenuItem.Name = "wczytajDaneToolStripMenuItem";
            this.wczytajDaneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.wczytajDaneToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.wczytajDaneToolStripMenuItem.Text = "Wczytaj dane";
            this.wczytajDaneToolStripMenuItem.Click += new System.EventHandler(this.wczytajDaneToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(217, 6);
            // 
            // zamknijProgramToolStripMenuItem2
            // 
            this.zamknijProgramToolStripMenuItem2.Name = "zamknijProgramToolStripMenuItem2";
            this.zamknijProgramToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.zamknijProgramToolStripMenuItem2.Size = new System.Drawing.Size(220, 22);
            this.zamknijProgramToolStripMenuItem2.Text = "Zamknij program";
            this.zamknijProgramToolStripMenuItem2.Click += new System.EventHandler(this.zamknijProgramToolStripMenuItem2_Click);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obliczToolStripMenuItem,
            this.toolStripMenuItem2,
            this.wyczyscToolStripMenuItem,
            this.wyczyćObliczeniaToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.plikToolStripMenuItem.Text = "Operacje";
            // 
            // obliczToolStripMenuItem
            // 
            this.obliczToolStripMenuItem.Name = "obliczToolStripMenuItem";
            this.obliczToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.obliczToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.obliczToolStripMenuItem.Text = "Oblicz";
            this.obliczToolStripMenuItem.Click += new System.EventHandler(this.obliczToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // wyczyscToolStripMenuItem
            // 
            this.wyczyscToolStripMenuItem.Name = "wyczyscToolStripMenuItem";
            this.wyczyscToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.wyczyscToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.wyczyscToolStripMenuItem.Text = "Wyczyść";
            this.wyczyscToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćToolStripMenuItem_Click);
            // 
            // wyczyćObliczeniaToolStripMenuItem
            // 
            this.wyczyćObliczeniaToolStripMenuItem.Name = "wyczyćObliczeniaToolStripMenuItem";
            this.wyczyćObliczeniaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.wyczyćObliczeniaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.wyczyćObliczeniaToolStripMenuItem.Text = "Wyczyść obliczenia";
            this.wyczyćObliczeniaToolStripMenuItem.Click += new System.EventHandler(this.wyczyćObliczeniaToolStripMenuItem_Click);
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyczyśćWykresToolStripMenuItem,
            this.toolStripMenuItem3,
            this.kolorWykresuToolStripMenuItem1,
            this.kolorTłaWykresuToolStripMenuItem1,
            this.toolStripMenuItem8,
            this.zapiszWykresToolStripMenuItem1});
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.operacjeToolStripMenuItem.Text = "Operacje wykresu";
            // 
            // wyczyśćWykresToolStripMenuItem
            // 
            this.wyczyśćWykresToolStripMenuItem.Name = "wyczyśćWykresToolStripMenuItem";
            this.wyczyśćWykresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.wyczyśćWykresToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.wyczyśćWykresToolStripMenuItem.Text = "Wyczyść wykres";
            this.wyczyśćWykresToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćWykresToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 6);
            // 
            // kolorWykresuToolStripMenuItem1
            // 
            this.kolorWykresuToolStripMenuItem1.Name = "kolorWykresuToolStripMenuItem1";
            this.kolorWykresuToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kolorWykresuToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.kolorWykresuToolStripMenuItem1.Text = "Kolor wykresu";
            this.kolorWykresuToolStripMenuItem1.Click += new System.EventHandler(this.kolorWykresuToolStripMenuItem1_Click);
            // 
            // kolorTłaWykresuToolStripMenuItem1
            // 
            this.kolorTłaWykresuToolStripMenuItem1.Name = "kolorTłaWykresuToolStripMenuItem1";
            this.kolorTłaWykresuToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.kolorTłaWykresuToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.kolorTłaWykresuToolStripMenuItem1.Text = "Kolor tła wykresu";
            this.kolorTłaWykresuToolStripMenuItem1.Click += new System.EventHandler(this.kolorTłaWykresuToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(202, 6);
            // 
            // zapiszWykresToolStripMenuItem1
            // 
            this.zapiszWykresToolStripMenuItem1.Name = "zapiszWykresToolStripMenuItem1";
            this.zapiszWykresToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.zapiszWykresToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.zapiszWykresToolStripMenuItem1.Text = "Zapisz wykres";
            this.zapiszWykresToolStripMenuItem1.Click += new System.EventHandler(this.zapiszWykresToolStripMenuItem1_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // btWyczyscwykres
            // 
            this.btWyczyscwykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWyczyscwykres.Location = new System.Drawing.Point(158, 72);
            this.btWyczyscwykres.Margin = new System.Windows.Forms.Padding(2);
            this.btWyczyscwykres.Name = "btWyczyscwykres";
            this.btWyczyscwykres.Size = new System.Drawing.Size(132, 28);
            this.btWyczyscwykres.TabIndex = 7;
            this.btWyczyscwykres.Text = "Wyczyść wykres";
            this.btWyczyscwykres.UseVisualStyleBackColor = true;
            this.btWyczyscwykres.Click += new System.EventHandler(this.btWyczyscwykres_Click);
            // 
            // btWyczyscobliczenia
            // 
            this.btWyczyscobliczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWyczyscobliczenia.Location = new System.Drawing.Point(10, 72);
            this.btWyczyscobliczenia.Margin = new System.Windows.Forms.Padding(2);
            this.btWyczyscobliczenia.Name = "btWyczyscobliczenia";
            this.btWyczyscobliczenia.Size = new System.Drawing.Size(132, 28);
            this.btWyczyscobliczenia.TabIndex = 6;
            this.btWyczyscobliczenia.Text = "Wyczyść obliczenia";
            this.btWyczyscobliczenia.UseVisualStyleBackColor = true;
            this.btWyczyscobliczenia.Click += new System.EventHandler(this.btWyczyscobliczenia_Click);
            // 
            // btKolorwykresu
            // 
            this.btKolorwykresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btKolorwykresu.Location = new System.Drawing.Point(158, 104);
            this.btKolorwykresu.Margin = new System.Windows.Forms.Padding(2);
            this.btKolorwykresu.Name = "btKolorwykresu";
            this.btKolorwykresu.Size = new System.Drawing.Size(132, 28);
            this.btKolorwykresu.TabIndex = 9;
            this.btKolorwykresu.Text = "Kolor wykresu";
            this.btKolorwykresu.UseVisualStyleBackColor = true;
            this.btKolorwykresu.Click += new System.EventHandler(this.btKolorwykresu_Click);
            // 
            // btKolortla
            // 
            this.btKolortla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btKolortla.Location = new System.Drawing.Point(10, 104);
            this.btKolortla.Margin = new System.Windows.Forms.Padding(2);
            this.btKolortla.Name = "btKolortla";
            this.btKolortla.Size = new System.Drawing.Size(132, 28);
            this.btKolortla.TabIndex = 8;
            this.btKolortla.Text = "Kolor tła wykresu";
            this.btKolortla.UseVisualStyleBackColor = true;
            this.btKolortla.Click += new System.EventHandler(this.btKolortla_Click);
            // 
            // MenuKontektowe
            // 
            this.MenuKontektowe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuKontektowe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obliczToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.wyczyśćDaneToolStripMenuItem,
            this.wyczyścDaneToolStripMenuItem,
            this.wyczyśćWykresToolStripMenuItem1,
            this.zapiszWykresToolStripMenuItem,
            this.toolStripMenuItem5,
            this.kolorTłaWykresuToolStripMenuItem,
            this.kolorWykresuToolStripMenuItem,
            this.toolStripMenuItem6,
            this.zapiszDaneToolStripMenuItem1,
            this.wczytajDaneToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.zamknijProgramToolStripMenuItem1});
            this.MenuKontektowe.Name = "MenuKontektowe";
            this.MenuKontektowe.Size = new System.Drawing.Size(177, 248);
            this.MenuKontektowe.Text = "Menu";
            // 
            // obliczToolStripMenuItem1
            // 
            this.obliczToolStripMenuItem1.Name = "obliczToolStripMenuItem1";
            this.obliczToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.obliczToolStripMenuItem1.Text = "Oblicz";
            this.obliczToolStripMenuItem1.Click += new System.EventHandler(this.obliczToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // wyczyśćDaneToolStripMenuItem
            // 
            this.wyczyśćDaneToolStripMenuItem.Name = "wyczyśćDaneToolStripMenuItem";
            this.wyczyśćDaneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wyczyśćDaneToolStripMenuItem.Text = "Wyczyść wszysko";
            this.wyczyśćDaneToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćDaneToolStripMenuItem_Click);
            // 
            // wyczyścDaneToolStripMenuItem
            // 
            this.wyczyścDaneToolStripMenuItem.Name = "wyczyścDaneToolStripMenuItem";
            this.wyczyścDaneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wyczyścDaneToolStripMenuItem.Text = "Wyczyść dane";
            this.wyczyścDaneToolStripMenuItem.Click += new System.EventHandler(this.wyczyścDaneToolStripMenuItem_Click);
            // 
            // wyczyśćWykresToolStripMenuItem1
            // 
            this.wyczyśćWykresToolStripMenuItem1.Name = "wyczyśćWykresToolStripMenuItem1";
            this.wyczyśćWykresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.wyczyśćWykresToolStripMenuItem1.Text = "Wyczyść wykres";
            this.wyczyśćWykresToolStripMenuItem1.Click += new System.EventHandler(this.wyczyśćWykresToolStripMenuItem1_Click);
            // 
            // zapiszWykresToolStripMenuItem
            // 
            this.zapiszWykresToolStripMenuItem.Name = "zapiszWykresToolStripMenuItem";
            this.zapiszWykresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszWykresToolStripMenuItem.Text = "Zapisz wykres";
            this.zapiszWykresToolStripMenuItem.Click += new System.EventHandler(this.zapiszWykresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
            // 
            // kolorTłaWykresuToolStripMenuItem
            // 
            this.kolorTłaWykresuToolStripMenuItem.Name = "kolorTłaWykresuToolStripMenuItem";
            this.kolorTłaWykresuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorTłaWykresuToolStripMenuItem.Text = "Kolor tła wykresu";
            this.kolorTłaWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorTłaWykresuToolStripMenuItem_Click);
            // 
            // kolorWykresuToolStripMenuItem
            // 
            this.kolorWykresuToolStripMenuItem.Name = "kolorWykresuToolStripMenuItem";
            this.kolorWykresuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorWykresuToolStripMenuItem.Text = "Kolor wykresu";
            this.kolorWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorWykresuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(177, 6);
            // 
            // zapiszDaneToolStripMenuItem1
            // 
            this.zapiszDaneToolStripMenuItem1.Name = "zapiszDaneToolStripMenuItem1";
            this.zapiszDaneToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zapiszDaneToolStripMenuItem1.Text = "Zapisz dane";
            this.zapiszDaneToolStripMenuItem1.Click += new System.EventHandler(this.zapiszDaneToolStripMenuItem1_Click);
            // 
            // wczytajDaneToolStripMenuItem1
            // 
            this.wczytajDaneToolStripMenuItem1.Name = "wczytajDaneToolStripMenuItem1";
            this.wczytajDaneToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.wczytajDaneToolStripMenuItem1.Text = "Wczytaj dane";
            this.wczytajDaneToolStripMenuItem1.Click += new System.EventHandler(this.wczytajDaneToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // zamknijProgramToolStripMenuItem1
            // 
            this.zamknijProgramToolStripMenuItem1.Name = "zamknijProgramToolStripMenuItem1";
            this.zamknijProgramToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zamknijProgramToolStripMenuItem1.Text = "Zamknij program";
            this.zamknijProgramToolStripMenuItem1.Click += new System.EventHandler(this.zamknijProgramToolStripMenuItem1_Click);
            // 
            // WczytajopenFileDialog
            // 
            this.WczytajopenFileDialog.DefaultExt = "txt";
            this.WczytajopenFileDialog.FileName = "openFileDialog1";
            this.WczytajopenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.WczytajopenFileDialog.RestoreDirectory = true;
            this.WczytajopenFileDialog.Title = "Wczytaj Dane";
            // 
            // ZapiszsaveFileDialog
            // 
            this.ZapiszsaveFileDialog.DefaultExt = "txt";
            this.ZapiszsaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.ZapiszsaveFileDialog.RestoreDirectory = true;
            this.ZapiszsaveFileDialog.Title = "Zapisz dane";
            // 
            // btZapisz
            // 
            this.btZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZapisz.Location = new System.Drawing.Point(11, 136);
            this.btZapisz.Margin = new System.Windows.Forms.Padding(2);
            this.btZapisz.Name = "btZapisz";
            this.btZapisz.Size = new System.Drawing.Size(132, 28);
            this.btZapisz.TabIndex = 10;
            this.btZapisz.Text = "Zapisz dane";
            this.btZapisz.UseVisualStyleBackColor = true;
            this.btZapisz.Click += new System.EventHandler(this.btZapisz_Click);
            // 
            // btWczytaj
            // 
            this.btWczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWczytaj.Location = new System.Drawing.Point(159, 136);
            this.btWczytaj.Margin = new System.Windows.Forms.Padding(2);
            this.btWczytaj.Name = "btWczytaj";
            this.btWczytaj.Size = new System.Drawing.Size(132, 28);
            this.btWczytaj.TabIndex = 11;
            this.btWczytaj.Text = "Wczytaj dane";
            this.btWczytaj.UseVisualStyleBackColor = true;
            this.btWczytaj.Click += new System.EventHandler(this.btWczytaj_Click);
            // 
            // btZapiszWykres
            // 
            this.btZapiszWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZapiszWykres.Location = new System.Drawing.Point(8, 182);
            this.btZapiszWykres.Margin = new System.Windows.Forms.Padding(2);
            this.btZapiszWykres.Name = "btZapiszWykres";
            this.btZapiszWykres.Size = new System.Drawing.Size(283, 28);
            this.btZapiszWykres.TabIndex = 12;
            this.btZapiszWykres.Text = "Zapisz wykres funkcji";
            this.btZapiszWykres.UseVisualStyleBackColor = true;
            this.btZapiszWykres.Click += new System.EventHandler(this.btZapiszWykres_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btWyczysc);
            this.groupBox3.Controls.Add(this.btZapiszWykres);
            this.groupBox3.Controls.Add(this.btWyczyscwykres);
            this.groupBox3.Controls.Add(this.btWyczyscobliczenia);
            this.groupBox3.Controls.Add(this.btZapisz);
            this.groupBox3.Controls.Add(this.btKolorwykresu);
            this.groupBox3.Controls.Add(this.btKolortla);
            this.groupBox3.Controls.Add(this.btWczytaj);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(12, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 225);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operacje:";
            // 
            // ZapiszWykresFileDialog
            // 
            this.ZapiszWykresFileDialog.DefaultExt = "png";
            this.ZapiszWykresFileDialog.Filter = "BMP (*.bmp)|*.bmp|PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|GIF (*.gif)|*.gif";
            this.ZapiszWykresFileDialog.FilterIndex = 2;
            this.ZapiszWykresFileDialog.RestoreDirectory = true;
            this.ZapiszWykresFileDialog.Title = "Zapisz wykres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(946, 639);
            this.ContextMenuStrip = this.MenuKontektowe;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btOblicz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBC);
            this.Controls.Add(this.txBB);
            this.Controls.Add(this.txBA);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Równanie Kwadratowe";
            ((System.ComponentModel.ISupportInitialize)(this.wykresfunkcji)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuKontektowe.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart wykresfunkcji;
        private System.Windows.Forms.TextBox txBA;
        private System.Windows.Forms.TextBox txBB;
        private System.Windows.Forms.TextBox txBC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDelta;
        private System.Windows.Forms.Label labelX01;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOblicz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btWyczysc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obliczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyćObliczeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.Button btWyczyscwykres;
        private System.Windows.Forms.Button btWyczyscobliczenia;
        private System.Windows.Forms.Button btKolorwykresu;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btKolortla;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćWykresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorWykresuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kolorTłaWykresuToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip MenuKontektowe;
        private System.Windows.Forms.ToolStripMenuItem obliczToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyścDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćWykresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kolorTłaWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijProgramToolStripMenuItem1;
        private System.Windows.Forms.Label labelxy;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.OpenFileDialog WczytajopenFileDialog;
        private System.Windows.Forms.SaveFileDialog ZapiszsaveFileDialog;
        private System.Windows.Forms.Button btZapisz;
        private System.Windows.Forms.Button btWczytaj;
        private System.Windows.Forms.Button btZapiszWykres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem zamknijProgramToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem zapiszWykresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszWykresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszDaneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wczytajDaneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog ZapiszWykresFileDialog;
    }
}

