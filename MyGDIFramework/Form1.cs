using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGDIFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GdiSystem Gdi;

        private void Form1_Load(object sender, EventArgs e)
        {
            Gdi = new GdiSystem(this);
        }

        Brush b = new SolidBrush(Color.FromArgb(127, 127, 255, 0));

        private void timer1_Tick(object sender, EventArgs e)
        {
            Gdi.Graphics.Clear(Color.Transparent);

            Gdi.Graphics.FillEllipse(b, 0, 0, Width, Height);

            Gdi.UpdateWindow();
        }
    }
}


