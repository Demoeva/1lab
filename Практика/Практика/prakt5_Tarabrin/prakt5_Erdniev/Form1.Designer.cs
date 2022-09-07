namespace prakt5_Erdniev
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arraySize = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manually = new System.Windows.Forms.RadioButton();
            this.randomly = new System.Windows.Forms.RadioButton();
            this.calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fillArrButton = new System.Windows.Forms.Button();
            this.numForCalcs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.Label();
            this.sumOutput = new System.Windows.Forms.Label();
            this.multOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arraySize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 88);
            this.dataGridView1.TabIndex = 0;
            // 
            // arraySize
            // 
            this.arraySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arraySize.Location = new System.Drawing.Point(214, 40);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(144, 26);
            this.arraySize.TabIndex = 1;
            this.arraySize.ValueChanged += new System.EventHandler(this.arraySize_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.manually);
            this.groupBox1.Controls.Add(this.randomly);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ заполнения массива";
            // 
            // manually
            // 
            this.manually.AutoSize = true;
            this.manually.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manually.Location = new System.Drawing.Point(6, 58);
            this.manually.Name = "manually";
            this.manually.Size = new System.Drawing.Size(91, 24);
            this.manually.TabIndex = 1;
            this.manually.TabStop = true;
            this.manually.Text = "Вручную";
            this.manually.UseVisualStyleBackColor = true;
            this.manually.Click += new System.EventHandler(this.manually_Click);
            // 
            // randomly
            // 
            this.randomly.AutoSize = true;
            this.randomly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomly.Location = new System.Drawing.Point(6, 28);
            this.randomly.Name = "randomly";
            this.randomly.Size = new System.Drawing.Size(100, 24);
            this.randomly.TabIndex = 0;
            this.randomly.TabStop = true;
            this.randomly.Text = "Случайно";
            this.randomly.UseVisualStyleBackColor = true;
            this.randomly.Click += new System.EventHandler(this.randomly_Click);
            // 
            // calculate
            // 
            this.calculate.Enabled = false;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate.Location = new System.Drawing.Point(368, 72);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(144, 54);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Вычислить";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(211, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Укажите размер массива";
            // 
            // fillArrButton
            // 
            this.fillArrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillArrButton.Location = new System.Drawing.Point(214, 72);
            this.fillArrButton.Name = "fillArrButton";
            this.fillArrButton.Size = new System.Drawing.Size(144, 54);
            this.fillArrButton.TabIndex = 5;
            this.fillArrButton.Text = "Заполнить массив";
            this.fillArrButton.UseVisualStyleBackColor = true;
            this.fillArrButton.Click += new System.EventHandler(this.fillArrButton_Click);
            // 
            // numForCalcs
            // 
            this.numForCalcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numForCalcs.Location = new System.Drawing.Point(368, 40);
            this.numForCalcs.Name = "numForCalcs";
            this.numForCalcs.Size = new System.Drawing.Size(140, 26);
            this.numForCalcs.TabIndex = 6;
            this.numForCalcs.TextChanged += new System.EventHandler(this.numForCalcs_TextChanged);
            this.numForCalcs.MouseLeave += new System.EventHandler(this.numForCalcs_MouseLeave);
            this.numForCalcs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numForCalcs_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(368, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Укажите число\r\n";
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hint.Location = new System.Drawing.Point(177, 132);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(445, 13);
            this.hint.TabIndex = 8;
            this.hint.Text = "Элементы массива с индексом, кратным числу будут использованы для вычислений ";
            this.hint.Visible = false;
            // 
            // sumOutput
            // 
            this.sumOutput.AutoSize = true;
            this.sumOutput.Location = new System.Drawing.Point(18, 248);
            this.sumOutput.Name = "sumOutput";
            this.sumOutput.Size = new System.Drawing.Size(44, 13);
            this.sumOutput.TabIndex = 9;
            this.sumOutput.Text = "Сумма:";
            // 
            // multOutput
            // 
            this.multOutput.AutoSize = true;
            this.multOutput.Location = new System.Drawing.Point(228, 248);
            this.multOutput.Name = "multOutput";
            this.multOutput.Size = new System.Drawing.Size(84, 13);
            this.multOutput.TabIndex = 10;
            this.multOutput.Text = "Произведение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 279);
            this.Controls.Add(this.multOutput);
            this.Controls.Add(this.sumOutput);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numForCalcs);
            this.Controls.Add(this.fillArrButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.arraySize);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arraySize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown arraySize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton randomly;
        private System.Windows.Forms.RadioButton manually;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fillArrButton;
        private System.Windows.Forms.TextBox numForCalcs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Label sumOutput;
        private System.Windows.Forms.Label multOutput;
    }
}

