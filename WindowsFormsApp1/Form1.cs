using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Graphics gr2;

        List<Color> colors = new List<Color>();
        List<string> circuits = new List<string>();

        Pen drawcircuitPen = new Pen(Color.Black, 1);
        SolidBrush eraser = new SolidBrush(Color.White);
        Rectangle rect = new Rectangle(MousePosition.X, MousePosition.Y, 1, 1);


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_hamilton_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Lewis Hamilton";
        }

        private void pictureBox_hamilton_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "F1 World Champions";
        }

        private void button_hamilton_MouseClick(object sender, MouseEventArgs e)
        {
            string sample = " World Titles: 6 \n F1 Starts: 250 \n Nationality: British \n Teams: Vodafone McLaren F1 Team, Mercedes AMG Petronas F1 Team  \n Active Years: 2007-present";
            MessageBox.Show(sample);
        }

        private void pictureBox_schumacher_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Michael Schumacher";
        }

        private void pictureBox_schumacher_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "F1 World Champions";
        }

        private void button_schumacher_Click(object sender, EventArgs e)
        {
            string sample = " World Titles: 7 \n F1 Starts: 306 \n Nationality: German \n Teams: Benetton F1 Team, Ferarri, Mercedes AMG Petronas F1 Team \n Active Years: 1991–2006, 2010–2012";
            MessageBox.Show(sample);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Juan Manuel Fangio";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "F1 World Champions";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sample = " World Titles: 5 \n F1 Starts: 51 \n Nationality: Argentine \n Teams: Alfa Romeo, Maserati, Mercedes, Ferrari \n Active Years: 1950 – 1951, 1953 – 1958";
            MessageBox.Show(sample);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Alain Prost";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "F1 World Champions"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sample = " World Titles: 4 \n F1 Starts: 199 \n Nationality: French \n Teams: McLaren, Renault, Ferrari, Williams \n Active Years: 1980–1991, 1993";
            MessageBox.Show(sample);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Sebastian Vettel";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "F1 World Champions";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sample = " World Titles: 4 \n F1 Starts: 240 \n Nationality: German \n Teams: BMW, Scuderia Toro Rosso, Red Bull Racing, Scuderia Ferrari \n Active Years: 2007-present";
            MessageBox.Show(sample);
        }

        private void pictureBox_senna_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Ayrton Senna";
        }

        private void button_senna_Click(object sender, EventArgs e)
        {
            string sample = " World Titles: 3 \n F1 Starts: 161 \n Nationality: Brazillian \n Teams: Toleman, Lotus, McLaren, Williams Renault  \n Active Years: 1984-1994";
            MessageBox.Show(sample);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer_f1.Start();

            colors.Add(Color.Black);

            circuits.Add("Albert Park");
            circuits.Add("Bahrain International Circuit");
            circuits.Add("Shanghai International Circuit");
            circuits.Add("Baku City Circuit");
            circuits.Add("Circuit de Catalunya");
            circuits.Add("Monaco Street Circuit");
            circuits.Add("Circuit Gilles Villeneuve");
            circuits.Add("Circuit Paul Ricard");
            circuits.Add("Red Bull Ring");
            circuits.Add("Silverstone Circuit");
            circuits.Add("Hockenheimring");
            circuits.Add("Hungaroring");
            circuits.Add("Circuit de Spa-Francorchamps");
            circuits.Add("Monza Circuit");
            circuits.Add("Singapore Street Circuit");
            circuits.Add("Sochi Autodrom");
            circuits.Add("Suzuka Circuit");
            circuits.Add("Autodromo Hermanos Rodriguez");
            circuits.Add("Circuit of the Americas");
            circuits.Add("Autodromo Jose Carlos Pace");
            circuits.Add("Yas Marina Circuit");

        }

        private void timer_f1_Tick(object sender, EventArgs e)
        {
            Pen drawcircuitPen = new Pen(Color.Black, 1);
            System.Drawing.Graphics gr = this.CreateGraphics();
            
            if (Control.MouseButtons == MouseButtons.Left)
                gr.DrawRectangle(drawcircuitPen, MousePosition.X, MousePosition.Y - 23, 1, 1);
            
            SolidBrush eraser = new SolidBrush(BackColor);
            Rectangle rect = new Rectangle(MousePosition.X, MousePosition.Y - 23, 100, 100);
            
            if (Control.MouseButtons == MouseButtons.Right)
                gr.FillRectangle(eraser, rect);


        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int index = r.Next(circuits.Count);
            string count = circuits[index];
            MessageBox.Show((string)circuits[index]);
        }

        
    }
}
