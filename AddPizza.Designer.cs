namespace Pizzeria
{
    partial class AddPizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxIngredients = new TextBox();
            label2 = new Label();
            textBoxWeight = new TextBox();
            label3 = new Label();
            textBoxPrice = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            buttonLoadPic = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(113, 21);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(163, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.Location = new Point(113, 64);
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(163, 23);
            textBoxIngredients.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Ингредиенты";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(113, 111);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(163, 23);
            textBoxWeight.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 4;
            label3.Text = "Вес";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(113, 158);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(163, 23);
            textBoxPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 6;
            label4.Text = "Цена";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(312, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // buttonLoadPic
            // 
            buttonLoadPic.Location = new Point(485, 153);
            buttonLoadPic.Name = "buttonLoadPic";
            buttonLoadPic.Size = new Size(167, 23);
            buttonLoadPic.TabIndex = 10;
            buttonLoadPic.Text = "Загрузить изображение";
            buttonLoadPic.UseVisualStyleBackColor = true;
            buttonLoadPic.Click += buttonLoadPic_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(478, 229);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(167, 23);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 274);
            Controls.Add(buttonAdd);
            Controls.Add(buttonLoadPic);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxPrice);
            Controls.Add(label4);
            Controls.Add(textBoxWeight);
            Controls.Add(label3);
            Controls.Add(textBoxIngredients);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddPizza";
            Text = "Новая пицца";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxIngredients;
        private Label label2;
        private TextBox textBoxWeight;
        private Label label3;
        private TextBox textBoxPrice;
        private Label label4;
        private PictureBox pictureBox1;
        private Button buttonLoadPic;
        private Button buttonAdd;
    }
}