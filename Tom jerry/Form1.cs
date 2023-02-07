using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tom_jerry.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Tom_jerry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jerrybtn_MouseMove(object sender, MouseEventArgs e)
        {
            if(sender is Button b)
            {
                b.Dispose();
            }
            Button newjerrybtn = new Button();
            newjerrybtn.BackColor = Color.Red;
            newjerrybtn.FlatStyle = FlatStyle.Flat;
            newjerrybtn.Size = jerrybtn.Size;
            newjerrybtn.FlatAppearance.BorderSize = newjerrybtn.FlatAppearance.BorderSize;
            newjerrybtn.FlatAppearance.BorderColor = newjerrybtn.FlatAppearance.BorderColor;
            newjerrybtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            newjerrybtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            Random random = new Random();
            int x = random.Next(10, 800);
            int y = random.Next(10, 500);
            newjerrybtn.Location = new Point(x, y);
            newjerrybtn.AutoSize = true; ;
            newjerrybtn.MouseMove += jerrybtn_MouseMove;
            this.Controls.Add(newjerrybtn);
        }
    }
}
