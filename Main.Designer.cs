namespace NonLinearEquationSolver
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.TextBox();
            this.right = new System.Windows.Forms.TextBox();
            this.deltaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Solve = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Solution = new System.Windows.Forms.TextBox();
            this.Iterations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "x + 0.4x + 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "3";
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(170, 100);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(98, 20);
            this.left.TabIndex = 2;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(170, 126);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(98, 20);
            this.right.TabIndex = 3;
            // 
            // deltaTB
            // 
            this.deltaTB.Location = new System.Drawing.Point(170, 152);
            this.deltaTB.Name = "deltaTB";
            this.deltaTB.Size = new System.Drawing.Size(98, 20);
            this.deltaTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Левая граница";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Правая граница";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Точность";
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(145, 190);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(75, 23);
            this.Solve.TabIndex = 8;
            this.Solve.Text = "Решить";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Решение";
            // 
            // Solution
            // 
            this.Solution.Enabled = false;
            this.Solution.Location = new System.Drawing.Point(95, 223);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(209, 20);
            this.Solution.TabIndex = 9;
            this.Solution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Iterations
            // 
            this.Iterations.Enabled = false;
            this.Iterations.Location = new System.Drawing.Point(95, 249);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(209, 20);
            this.Iterations.TabIndex = 11;
            this.Iterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Итераций";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 295);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deltaTB);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Калькулятор нелинейного уравнения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.TextBox right;
        private System.Windows.Forms.TextBox deltaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Solution;
        private System.Windows.Forms.TextBox Iterations;
        private System.Windows.Forms.Label label7;
    }
}

