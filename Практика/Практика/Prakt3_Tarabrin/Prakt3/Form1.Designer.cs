namespace Prakt3
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
            this.components = new System.ComponentModel.Container();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toSeven = new System.Windows.Forms.RadioButton();
            this.toFive = new System.Windows.Forms.RadioButton();
            this.toThree = new System.Windows.Forms.RadioButton();
            this.changeCountSyst = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(12, 30);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(117, 29);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите натуральное число:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toSeven);
            this.groupBox1.Controls.Add(this.toFive);
            this.groupBox1.Controls.Add(this.toThree);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите систему счисления";
            // 
            // toSeven
            // 
            this.toSeven.AutoSize = true;
            this.toSeven.Location = new System.Drawing.Point(6, 116);
            this.toSeven.Name = "toSeven";
            this.toSeven.Size = new System.Drawing.Size(121, 24);
            this.toSeven.TabIndex = 2;
            this.toSeven.TabStop = true;
            this.toSeven.Text = "Семиричная";
            this.toSeven.UseVisualStyleBackColor = true;
            this.toSeven.CheckedChanged += new System.EventHandler(this.toSeven_CheckedChanged);
            // 
            // toFive
            // 
            this.toFive.AutoSize = true;
            this.toFive.Location = new System.Drawing.Point(7, 86);
            this.toFive.Name = "toFive";
            this.toFive.Size = new System.Drawing.Size(120, 24);
            this.toFive.TabIndex = 1;
            this.toFive.TabStop = true;
            this.toFive.Text = "Пятиричная";
            this.toFive.UseVisualStyleBackColor = true;
            this.toFive.CheckedChanged += new System.EventHandler(this.toFive_CheckedChanged);
            // 
            // toThree
            // 
            this.toThree.AutoSize = true;
            this.toThree.Location = new System.Drawing.Point(6, 56);
            this.toThree.Name = "toThree";
            this.toThree.Size = new System.Drawing.Size(99, 24);
            this.toThree.TabIndex = 0;
            this.toThree.TabStop = true;
            this.toThree.Text = "Троичная";
            this.toThree.UseVisualStyleBackColor = true;
            this.toThree.CheckedChanged += new System.EventHandler(this.toThree_CheckedChanged);
            // 
            // changeCountSyst
            // 
            this.changeCountSyst.Enabled = false;
            this.changeCountSyst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeCountSyst.Location = new System.Drawing.Point(12, 279);
            this.changeCountSyst.Name = "changeCountSyst";
            this.changeCountSyst.Size = new System.Drawing.Size(169, 31);
            this.changeCountSyst.TabIndex = 3;
            this.changeCountSyst.Text = "Перевести";
            this.changeCountSyst.UseVisualStyleBackColor = true;
            this.changeCountSyst.Click += new System.EventHandler(this.changeCountSyst_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(8, 71);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(89, 20);
            this.result.TabIndex = 4;
            this.result.Text = "Результат";
            this.result.Visible = false;
            this.result.MouseLeave += new System.EventHandler(this.result_MouseLeave);
            this.result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.result_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "выполненные задачи записываются в файл history.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(279, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.changeCountSyst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Перевод систем счисления";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton toSeven;
        private System.Windows.Forms.RadioButton toFive;
        private System.Windows.Forms.RadioButton toThree;
        private System.Windows.Forms.Button changeCountSyst;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
    }
}

