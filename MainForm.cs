using Microsoft.EntityFrameworkCore;

namespace Pizzeria
{
    public partial class MainForm : Form
    {
        PizzeriaContext context;
        public MainForm()
        {
            InitializeComponent();
            context = new PizzeriaContext();
            context.Pizzas.Load();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.DataSource = context.Pizzas.Local.ToBindingList();
            dataGridView1.Columns[0].Visible = false;
        }
        void UpdateDataGrid()
        {
            context.Pizzas.Load();
            dataGridView1.DataSource = context.Pizzas.Local.ToBindingList();
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Ингредиенты";
            dataGridView1.Columns[3].HeaderText = "Вес";
            dataGridView1.Columns[4].HeaderText = "Цена";
            dataGridView1.Columns[5].HeaderText = "Изображение";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddPizza addPizza = new AddPizza();
            if (addPizza.ShowDialog() == DialogResult.OK)
            {
                UpdateDataGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 0)
            {
                MessageBox.Show("Выберите пиццу!");
                return;
            }
            if (MessageBox.Show("Действительно хотите удалить?", "Удалить", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            context.Pizzas.Remove(context.Pizzas.Find(dataGridView1.SelectedRows[0].Cells[0].Value));
            context.SaveChanges();
            UpdateDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 0)
            {
                MessageBox.Show("Выберите пиццу!");
                return;
            }
            EditPizza editPizza = new EditPizza((long)dataGridView1.SelectedRows[0].Cells[0].Value);
            if (editPizza.ShowDialog() == DialogResult.OK)
            {
                context = new PizzeriaContext();
                UpdateDataGrid();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == string.Empty)
            {
                UpdateDataGrid();
            }
            else
            {
                context.Pizzas.Load();
                dataGridView1.DataSource = context.Pizzas.Where(u => u.Name.Contains($"{textBoxSearch.Text}") || u.Ingredients.Contains($"{textBoxSearch.Text}") || u.Price.ToString().Contains(textBoxSearch.Text) || u.Weight.ToString().Contains(textBoxSearch.Text)).ToList();
            }

        }
    }
}