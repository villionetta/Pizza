using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class AddPizza : Form
    {
        PizzeriaContext context;
        public AddPizza()
        {
            InitializeComponent();
            context = new PizzeriaContext();
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            double weight = 0, price = 0;
            byte[] picture = null;
            if (textBoxName.Text == string.Empty)
            {
                message = "Название не заполнено!\n";
            }
            if (textBoxIngredients.Text == string.Empty)
            {
                message += "Ингредиенты не заполнены!\n";
            }
            if (textBoxWeight.Text == string.Empty)
            {
                message += "Вес не заполнен!\n";
            }
            else if (!double.TryParse(textBoxWeight.Text, out weight))
            {
                message += "Вес должен быть числом!\n";
            }

            if (textBoxPrice.Text == string.Empty)
            {
                message += "Цена не заполнена!\n";
            }
            else if (!double.TryParse(textBoxPrice.Text, out price))
            {
                message += "Цена должна быть числом!\n";
            }
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, "Ошибка");
                return;
            }
            if (pictureBox1.Image != null)
            {
                picture = ImageToByteArray(pictureBox1.Image);
            }
            context.Pizzas.Add(new Pizza { Name = textBoxName.Text, Ingredients = textBoxIngredients.Text, Weight = weight, Price = price, Picture = picture });
            context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonLoadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            pictureBox1.Image = Image.FromFile(filename);
        }
    }
}
