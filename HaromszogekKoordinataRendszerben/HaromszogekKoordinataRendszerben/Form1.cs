namespace HaromszogekKoordinataRendszerben
{
    public partial class Form1 : Form
    {
        // Három pont koordinátái (A, B, C)
        private PointF A, B, C;

        public Form1()
        {
            InitializeComponent();
            A = new PointF(-3, -3);
            B = new PointF(3, -3);
            C = new PointF(0, 3);
            panelDraw.Paint += new PaintEventHandler(panelRajzolas);
        }

        private void panelRajzolas(object sender, PaintEventArgs e)
        {
            Graphics grafika = e.Graphics;
            KoordinataRendszerRajz(grafika);  // Koordinátarendszer rajz
            HaromszogRajz(grafika);           // Háromszög rajz
        }

        private void KoordinataRendszerRajz(Graphics grafika)
        {
            int panelSzelesseg = panelDraw.Width;
            int panelMagassag = panelDraw.Height;
            int kozepeX = panelSzelesseg / 2;
            int kozepeY = panelMagassag / 2;

            Pen vekonyPen = new Pen(Color.LightGray, 1);
            Pen vastagPen = new Pen(Color.Black, 3);

            // Rács rajzolása
            for (int i = 0; i < panelSzelesseg; i += 20)
            {
                Pen jelenlegiPen = (i == kozepeX) ? vastagPen : vekonyPen;
                grafika.DrawLine(jelenlegiPen, i, 0, i, panelMagassag);
            }

            for (int i = 0; i < panelMagassag; i += 20)
            {
                Pen jelenlegiPen = (i == kozepeY) ? vastagPen : vekonyPen;
                grafika.DrawLine(jelenlegiPen, 0, i, panelSzelesseg, i);
            }

            // Tengelyek és jelölések
            grafika.DrawString("y tengely", DefaultFont, Brushes.Black, kozepeX + 5, 10);
            grafika.DrawString("x tengely", DefaultFont, Brushes.Black, panelSzelesseg - 60, kozepeY + 5);
            grafika.DrawString("O", DefaultFont, Brushes.Black, kozepeX + 5, kozepeY + 5);
            grafika.DrawString("1", DefaultFont, Brushes.Black, kozepeX + 25, kozepeY - 10);
            grafika.DrawString("-1", DefaultFont, Brushes.Black, kozepeX - 35, kozepeY - 10);
            grafika.DrawString("1", DefaultFont, Brushes.Black, kozepeX - 10, kozepeY - 30);
            grafika.DrawString("-1", DefaultFont, Brushes.Black, kozepeX - 10, kozepeY + 25);
        }

        private void HaromszogRajz(Graphics grafika)
        {
            Pen pen = new Pen(Color.Black, 2);
            int kozepeX = panelDraw.Width / 2;
            int kozepeY = panelDraw.Height / 2;

            PontokRendezese();

            PointF pontA = new PointF(kozepeX + A.X * 20, kozepeY - A.Y * 20);
            PointF pontB = new PointF(kozepeX + B.X * 20, kozepeY - B.Y * 20);
            PointF pontC = new PointF(kozepeX + C.X * 20, kozepeY - C.Y * 20);

            grafika.DrawLine(pen, pontA, pontB);
            grafika.DrawLine(pen, pontB, pontC);
            grafika.DrawLine(pen, pontC, pontA);

            grafika.DrawString("A", DefaultFont, Brushes.Black, pontA.X + 5, pontA.Y - 10);
            grafika.DrawString("B", DefaultFont, Brushes.Black, pontB.X + 5, pontB.Y - 10);
            grafika.DrawString("C", DefaultFont, Brushes.Black, pontC.X + 5, pontC.Y - 10);
        }

        private void PontokRendezese()
        {
            PointF[] pontok = { A, B, C };
            Array.Sort(pontok, (p1, p2) =>
            {
                if (p1.Y == p2.Y) return p1.X.CompareTo(p2.X); // X szerint, ha az Y egyenlõ
                return p1.Y.CompareTo(p2.Y); // Y szerint rendezzük
            });
            A = pontok[0];

            double szogB = Math.Atan2(pontok[1].Y - A.Y, pontok[1].X - A.X);
            double szogC = Math.Atan2(pontok[2].Y - A.Y, pontok[2].X - A.X);

            if (szogB < szogC)
            {
                B = pontok[1];
                C = pontok[2];
            }
            else
            {
                B = pontok[2];
                C = pontok[1];
            }

            // TextBox-ok frissítése
            textBox1.Text = "A";
            textBox2.Text = "B";
            textBox3.Text = "C";
            txtAx.Text = A.X.ToString();
            txtAy.Text = A.Y.ToString();
            txtBx.Text = B.X.ToString();
            txtBy.Text = B.Y.ToString();
            txtCx.Text = C.X.ToString();
            txtCy.Text = C.Y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtAx.Text, out float ax) &&
                float.TryParse(txtAy.Text, out float ay) &&
                float.TryParse(txtBx.Text, out float bx) &&
                float.TryParse(txtBy.Text, out float by) &&
                float.TryParse(txtCx.Text, out float cx) &&
                float.TryParse(txtCy.Text, out float cy))
            {
                A = new PointF(ax, ay);
                B = new PointF(bx, by);
                C = new PointF(cx, cy);

                PontokRendezese();
                panelDraw.Invalidate();
            }
            else
            {
                MessageBox.Show("Kérlek, adj meg érvényes számokat minden mezõben!", "Érvénytelen adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
