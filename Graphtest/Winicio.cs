using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphtest
{
    public partial class Winicio : Form
    {
        public Winicio()
        {
            InitializeComponent();

           
        }

        public float X = 250, Y = 150, Ancho = 50;
        public float V = 2, G = 0.1f;

        private void tmrPro_Tick(object sender, EventArgs e)
        {
            Actualizar();
            colision();
            Invalidate();
        }

        private void cmdstart_Click(object sender, EventArgs e)
        {
            tmrPro.Interval = 16;
            tmrPro.Start();
            this.DoubleBuffered = true;
        }

        private void Actualizar()
        {
            V = V + G;

            Y = Y + V;
        }

        private void colision()
        {
            if (Y > ClientSize.Height)
            {
                V *= -0.8f;
                Y = ClientSize.Height-Ancho;
            }

        }

        protected override void OnPaint(PaintEventArgs e) 
        { 
            e.Graphics.Clear(Color.White);
            e.Graphics.FillEllipse(Brushes.Black, X - Ancho / 2, Y - Ancho / 2, Ancho, Ancho);
            base.OnPaint(e);
        
        }
    }
}
