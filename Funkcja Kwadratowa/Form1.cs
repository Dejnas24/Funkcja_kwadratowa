using System;
using System.Windows.Forms;

namespace Funkcja_Kwadratowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOblicz_Click(object sender, EventArgs e)
        {
            RownanieKwadratowe();
        }

        private void btWyczysc_Click(object sender, EventArgs e)
        {
            WyczyscWszysko();
        }

        private void obliczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RownanieKwadratowe();
        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WyczyscWszysko();
        }

        private void wyczyćObliczeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WyczyscDane();
        }

        private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oprogramie oprogramie = new Oprogramie();
            oprogramie.ShowDialog();
        }

        private void btWyczyscwykres_Click(object sender, EventArgs e)
        {
            WyczyscWykres();
        }

        private void btWyczyscobliczenia_Click(object sender, EventArgs e)
        {
            WyczyscDane();
        }

        private void btKolorwykresu_Click(object sender, EventArgs e)
        {
            KolorWykresu();
        }

        private void btKolortla_Click(object sender, EventArgs e)
        {
            KolorTlaWykresu();
        }

        private void wyczyśćWykresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            WyczyscWykres();
        }

        private void kolorWykresuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KolorWykresu();
        }

        private void kolorTłaWykresuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KolorTlaWykresu();
        }

        private void obliczToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RownanieKwadratowe();
        }

        private void wyczyśćDaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WyczyscWszysko();
        }

        private void wyczyścDaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WyczyscDane();
        }

        private void wyczyśćWykresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WyczyscWykres();
        }

        private void kolorTłaWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KolorTlaWykresu();
        }

        private void kolorWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KolorWykresu();
        }

        private void zamknijProgramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RownanieKwadratowe()
        {
            Clear();
            WyczyscWykres();

            double delta, x1, x2, Y1, Y2, Y1w = 0, Y2w = 0, X1w = 0, X2w = 0;
            double Xw, Yw;
            try
            {
                if (Double.Parse(txBA.Text) == 0)
                {
                    MessageBox.Show("A musi być różne od zera (a!=0)!!!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    delta = Math.Pow(Double.Parse(txBB.Text), 2) - (4 * Double.Parse(txBA.Text) * Double.Parse(txBC.Text));

                    labelDelta.Text = "Delta = " + delta.ToString();

                    if (delta > 0)
                    {
                        labelOdpowiedz.Text = "Więc są dwa pierwiaski:";
                        x1 = (-Double.Parse(txBB.Text) - Math.Sqrt(delta)) / (2 * Double.Parse(txBA.Text));
                        x2 = (-Double.Parse(txBB.Text) + Math.Sqrt(delta)) / (2 * Double.Parse(txBA.Text));
                        labelX01.Text = "x1 = " + Math.Round(x1, 2).ToString();
                        labelX2.Text = "x2 = " + Math.Round(x2, 2).ToString();

                        Xw = (-Double.Parse(txBB.Text)) / (2 * Double.Parse(txBA.Text));
                        Yw = (-delta) / (4 * Double.Parse(txBA.Text));
                        labelxy.Text = "Współrzędna wierzchołka: W(" + Math.Round(Xw, 2) + ", " + Math.Round(Yw, 2) + ");";

                        Y1 = Double.Parse(txBA.Text) * Math.Pow(x1, 2) + Double.Parse(txBB.Text) * x1 + Double.Parse(txBC.Text);
                        Y2 = Double.Parse(txBA.Text) * Math.Pow(x2, 2) + Double.Parse(txBB.Text) * x2 + Double.Parse(txBC.Text);
                        if (Double.Parse(txBA.Text) > 0)
                        {
                            X1w = x1 - 1;
                            X2w = x2 + 1;
                            Y1w = Double.Parse(txBA.Text) * Math.Pow(X1w, 2) + Double.Parse(txBB.Text) * X1w + Double.Parse(txBC.Text);
                            Y2w = Double.Parse(txBA.Text) * Math.Pow(X2w, 2) + Double.Parse(txBB.Text) * X2w + Double.Parse(txBC.Text);
                        }
                        else if (Double.Parse(txBA.Text) < 0)
                        {
                            X1w = x1 + 1;
                            X2w = x2 - 1;
                            Y1w = Double.Parse(txBA.Text) * Math.Pow(X1w, 2) + Double.Parse(txBB.Text) * X1w + Double.Parse(txBC.Text);
                            Y2w = Double.Parse(txBA.Text) * Math.Pow(X2w, 2) + Double.Parse(txBB.Text) * X2w + Double.Parse(txBC.Text);
                        }
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(X1w, 2), Math.Round(Y1w, 2));
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(x1, 2), Math.Round(Y1, 2));
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(Xw, 2), Math.Round(Yw, 2));
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(x2, 2), Math.Round(Y2, 2));
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(X2w, 2), Math.Round(Y2w, 2));
                    }
                    else if (delta == 0)
                    {
                        labelOdpowiedz.Text = "Więc jest jeden pierwiastek:";
                        x1 = (-Double.Parse(txBB.Text)) / (2 * Double.Parse(txBA.Text));
                        labelX01.Text = "x0 = " + Math.Round(x1, 2).ToString();
                        Y1 = Double.Parse(txBA.Text) * Math.Pow(x1, 2) + Double.Parse(txBB.Text) * x1 + Double.Parse(txBC.Text);
                        labelxy.Text = "Współrzędna wierzchołka: W(" + Math.Round(x1, 2) + ", " + Math.Round(Y1, 2) + ");";

                        if (Double.Parse(txBA.Text) > 0)
                        {
                            X1w = x1 - 2;
                            X2w = x1 + 2;
                            Y1w = Double.Parse(txBA.Text) * Math.Pow(X1w, 2) + Double.Parse(txBB.Text) * X1w + Double.Parse(txBC.Text);
                            Y2w = Double.Parse(txBA.Text) * Math.Pow(X2w, 2) + Double.Parse(txBB.Text) * X2w + Double.Parse(txBC.Text);
                        }
                        else if (Double.Parse(txBA.Text) < 0)
                        {
                            X1w = x1 + 2;
                            X2w = x1 - 2;
                            Y1w = Double.Parse(txBA.Text) * Math.Pow(X1w, 2) + Double.Parse(txBB.Text) * X1w + Double.Parse(txBC.Text);
                            Y2w = Double.Parse(txBA.Text) * Math.Pow(X2w, 2) + Double.Parse(txBB.Text) * X2w + Double.Parse(txBC.Text);
                        }
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(X1w, 2), Math.Round(Y1w, 2));
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(x1, 2), Math.Round(Y1, 2));
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(X2w, 2), Math.Round(Y2w, 2));
                    }
                    else if (delta < 0)
                    {
                        labelOdpowiedz.Text = "Więc brak pierwiasków!!!";

                        Xw = (-Double.Parse(txBB.Text)) / (2 * Double.Parse(txBA.Text));
                        Yw = (-delta) / (4 * Double.Parse(txBA.Text));
                        labelxy.Text = "Współrzędna wierzchołka: W(" + Math.Round(Xw, 2) + ", " + Math.Round(Yw, 2) + ");";

                        if (Double.Parse(txBA.Text) > 0)
                        {
                            X1w = Xw - 2;
                            X2w = Xw + 2;
                            Y1w = Double.Parse(txBA.Text) * Math.Pow(X1w, 2) + Double.Parse(txBB.Text) * X1w + Double.Parse(txBC.Text);
                            Y2w = Double.Parse(txBA.Text) * Math.Pow(X2w, 2) + Double.Parse(txBB.Text) * X2w + Double.Parse(txBC.Text);
                        }
                        else if (Double.Parse(txBA.Text) < 0)
                        {
                            X1w = Xw + 2;
                            X2w = Xw - 2;
                            Y1w = Double.Parse(txBA.Text) * Math.Pow(X1w, 2) + Double.Parse(txBB.Text) * X1w + Double.Parse(txBC.Text);
                            Y2w = Double.Parse(txBA.Text) * Math.Pow(X2w, 2) + Double.Parse(txBB.Text) * X2w + Double.Parse(txBC.Text);
                        }

                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(X1w, 2), Math.Round(Y1w, 2));
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(Xw, 2), Math.Round(Yw, 2));
                        wykresfunkcji.Series[0].Points.AddXY(Math.Round(X2w, 2), Math.Round(Y2w, 2));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pola A, B i C nie mogą być puste, " + "\nlub inne znaki od liczb!!!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WyczyscDane()
        {
            Clear();
            txBA.Clear();
            txBB.Clear();
            txBC.Clear();
        }

        private void WyczyscWszysko()
        {
            Clear();
            wykresfunkcji.Series[0].Points.Clear();
            txBA.Clear();
            txBB.Clear();
            txBC.Clear();
        }

        private void WyczyscWykres()
        {
            wykresfunkcji.Series[0].Points.Clear();
        }

        private void Clear()
        {
            labelX01.Text = labelX2.Text = labelOdpowiedz.Text = labelDelta.Text = labelxy.Text = "";
        }

        private void KolorWykresu()
        {
            colorDialog1.ShowDialog();
            wykresfunkcji.Series[0].Color = colorDialog1.Color;
            btKolorwykresu.BackColor = colorDialog1.Color;
        }

        private void KolorTlaWykresu()
        {
            colorDialog1.ShowDialog();
            wykresfunkcji.ChartAreas[0].BackColor = colorDialog1.Color;
            btKolortla.BackColor = colorDialog1.Color;
        }
    }
}