namespace Migrations.Forms
{
    partial class AddTeacher
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 183);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(242, 31);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 37);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 87);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 131);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 27);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 44);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 94);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 138);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "Зарплата";
            label3.Click += label3_Click;
            // 
            // AddTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 250);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddTeacher";
            Text = "AddTeacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}