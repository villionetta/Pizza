namespace Pizzeria
{
    partial class EditPizza
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
            buttonEdit = new Button();
            buttonLoadPic = new Button();
            pictureBox1 = new PictureBox();
            textBoxPrice = new TextBox();
            label4 = new Label();
            textBoxWeight = new TextBox();
            label3 = new Label();
            textBoxIngredients = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(474, 230);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(167, 23);
            buttonEdit.TabIndex = 22;
            buttonEdit.Text = "Сохранить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonLoadPic
            // 
            buttonLoadPic.Location = new Point(481, 154);
            buttonLoadPic.Name = "buttonLoadPic";
            buttonLoadPic.Size = new Size(167, 23);
            buttonLoadPic.TabIndex = 21;
            buttonLoadPic.Text = "Загрузить изображение";
            buttonLoadPic.UseVisualStyleBackColor = true;
            buttonLoadPic.Click += buttonLoadPic_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(308, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(109, 159);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(163, 23);
            textBoxPrice.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 162);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 18;
            label4.Text = "Цена";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(109, 112);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(163, 23);
            textBoxWeight.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 115);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 16;
            label3.Text = "Вес";
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.Location = new Point(109, 65);
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(163, 23);
            textBoxIngredients.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 68);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 14;
            label2.Text = "Ингредиенты";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(109, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(163, 23);
            textBoxName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 25);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 12;
            label1.Text = "Название";
            // 
            // EditPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 274);
            Controls.Add(buttonEdit);
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
            Name = "EditPizza";
            Text = "Изменение пиццы";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private Button buttonLoadPic;
        private PictureBox pictureBox1;
        private TextBox textBoxPrice;
        private Label label4;
        private TextBox textBoxWeight;
        private Label label3;
        private TextBox textBoxIngredients;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
    }
}