using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Pizzeria
{
    public partial class EditPizza : Form
    {
        PizzeriaContext context;
        long _id;
        Pizza pizza;
        bool updateImg = false;
        public EditPizza(long id)
        {
            InitializeComponent();
            _id = id;
            context = new PizzeriaContext();
            pizza = context.Pizzas.Find(id);
            textBoxName.Text = pizza.Name;
            textBoxIngredients.Text = pizza.Ingredients;
            textBoxPrice.Text = pizza.Price.ToString();
            textBoxWeight.Text = pizza.Weight.ToString();
            if (pizza.Picture != null)
                using (var ms = new MemoryStream(pizza.Picture))
                {
                    pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                }

        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
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
            if (pictureBox1.Image != null && updateImg == true)
            {
                picture = ImageToByteArray(pictureBox1.Image);
                pizza.Picture = picture;
            }
            pizza.Name = textBoxName.Text;

            pizza.Weight = weight;
            pizza.Price = price;
            pizza.Ingredients = textBoxIngredients.Text;
            context.Pizzas.Update(pizza);
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
            updateImg = true;
            pictureBox1.Image = System.Drawing.Image.FromFile(filename);
        }
    }
}
