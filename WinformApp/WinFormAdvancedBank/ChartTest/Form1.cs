using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartStart();
        }

        private void chartStart()
        {
            Random rand = new Random();
            ChtTest.Series["Score"].Points.Clear();


            for (int i = 0; i < 10; i++)
            {
                ChtTest.Series["Score"].Points.Add(rand.Next(10, 100));
            }

            ChtTest.Series["Score"].LegendText = "수학";
            ChtTest.Series["Score"].ChartType = SeriesChartType.Line;
        }
    }
}
