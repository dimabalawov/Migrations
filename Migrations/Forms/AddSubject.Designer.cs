namespace Migrations.Forms
{
    partial class AddSubject
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
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 132);
            button1.Name = "button1";
            button1.Size = new Size(189, 43);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 55);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 1;
            label1.Text = "Название предмета";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 2;
            // 
            // AddSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 212);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddSubject";
            Text = "AddSubject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}