using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk0303
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 0401
            //Button B = new Button();
            //this.Controls.Add(B);
            // 0402 for loop
            //for (int i=0; i<5; i++)
            //{
            //Button B = new Button();
            //B.location = new Point(i*100,0);
            //this.Controls.Add(B);
            //}
            // 0403 double for loop
            for (int i=0; i<5; i++)
            for (int y=0; y<500; y+=100)
            {
            Button B = new Button();
            B.Location = new Point(i*100, y);
            this.Controls.Add(B);
            }

        }

    }
}
