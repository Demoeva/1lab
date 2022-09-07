namespace Prakt1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radian = new System.Windows.Forms.RadioButton();
            this.degree = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radian);
            this.groupBox1.Controls.Add(this.degree);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(333, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Угол:";
            // 
            // radian
            // 
            this.radian.AutoSize = true;
            this.radian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radian.Location = new System.Drawing.Point(35, 84);
            this.radian.Name = "radian";
            this.radian.Size = new System.Drawing.Size(118, 25);
            this.radian.TabIndex = 1;
            this.radian.TabStop = true;
            this.radian.Text = "В радианах";
            this.radian.UseVisualStyleBackColor = true;
            // 
            // degree
            // 
            this.degree.AutoSize = true;
            this.degree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.degree.Location = new System.Drawing.Point(35, 42);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(116, 25);
            this.degree.TabIndex = 0;
            this.degree.TabStop = true;
            this.degree.Text = "В градусах";
            this.degree.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(329, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите угол α:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(333, 190);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(125, 20);
            this.input.TabIndex = 3;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // calcButton
            // 
            this.calcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcButton.Location = new System.Drawing.Point(333, 299);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(125, 40);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Вычислить";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Bisque;
            this.result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(12, 164);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 21);
            this.result.TabIndex = 5;
            this.result.MouseEnter += new System.EventHandler(this.result_MouseEnter);
            this.result.MouseLeave += new System.EventHandler(this.result_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(329, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите угол b:";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(333, 256);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(125, 20);
            this.input2.TabIndex = 8;
            this.input2.TextChanged += new System.EventHandler(this.input2_TextChanged);
            this.input2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input2_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(621, 427);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Вычисление по формулам";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radian;
        private System.Windows.Forms.RadioButton degree;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input2;
    }
}

