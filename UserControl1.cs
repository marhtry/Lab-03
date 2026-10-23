using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_02.FolderforModel;

namespace Lab_02
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void Fill(Table_Motorbike motorbike)
        {
            labelID.Text = motorbike.ID.ToString();
            labelModel.Text = motorbike.Model;
            labelBrand.Text = motorbike.Brand; 
            labelPrice.Text = motorbike.Price.ToString();
            labelHorsepower.Text = motorbike.Horsepower.ToString();
            labelMileage .Text = motorbike.Mileage.ToString();
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Pictures", motorbike.Image);

            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
