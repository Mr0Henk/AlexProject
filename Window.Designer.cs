namespace AlexProject
{
    partial class Window
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
            this.save2d = new System.Windows.Forms.Button();
            this.load2d = new System.Windows.Forms.Button();
            this.save3d = new System.Windows.Forms.Button();
            this.load3d = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rad2d = new System.Windows.Forms.TextBox();
            this.diag2d = new System.Windows.Forms.TextBox();
            this.rad3d = new System.Windows.Forms.TextBox();
            this.cube3d = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save2d
            // 
            this.save2d.Location = new System.Drawing.Point(58, 197);
            this.save2d.Name = "save2d";
            this.save2d.Size = new System.Drawing.Size(75, 23);
            this.save2d.TabIndex = 0;
            this.save2d.Text = "Сохранить";
            this.save2d.UseVisualStyleBackColor = true;
            this.save2d.Click += new System.EventHandler(this.save2d_Click);
            // 
            // load2d
            // 
            this.load2d.Location = new System.Drawing.Point(58, 226);
            this.load2d.Name = "load2d";
            this.load2d.Size = new System.Drawing.Size(75, 23);
            this.load2d.TabIndex = 1;
            this.load2d.Text = "Загрузить";
            this.load2d.UseVisualStyleBackColor = true;
            this.load2d.Click += new System.EventHandler(this.load2d_Click);
            // 
            // save3d
            // 
            this.save3d.Location = new System.Drawing.Point(361, 197);
            this.save3d.Name = "save3d";
            this.save3d.Size = new System.Drawing.Size(75, 23);
            this.save3d.TabIndex = 3;
            this.save3d.Text = "Сохранить";
            this.save3d.UseVisualStyleBackColor = true;
            this.save3d.Click += new System.EventHandler(this.save3d_Click);
            // 
            // load3d
            // 
            this.load3d.Location = new System.Drawing.Point(361, 226);
            this.load3d.Name = "load3d";
            this.load3d.Size = new System.Drawing.Size(75, 23);
            this.load3d.TabIndex = 2;
            this.load3d.Text = "Загрузить";
            this.load3d.UseVisualStyleBackColor = true;
            this.load3d.Click += new System.EventHandler(this.load3d_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "для 2D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "для 3D";
            // 
            // rad2d
            // 
            this.rad2d.Location = new System.Drawing.Point(103, 94);
            this.rad2d.Name = "rad2d";
            this.rad2d.Size = new System.Drawing.Size(100, 20);
            this.rad2d.TabIndex = 6;
            // 
            // diag2d
            // 
            this.diag2d.Location = new System.Drawing.Point(103, 120);
            this.diag2d.Name = "diag2d";
            this.diag2d.Size = new System.Drawing.Size(100, 20);
            this.diag2d.TabIndex = 7;
            // 
            // rad3d
            // 
            this.rad3d.Location = new System.Drawing.Point(350, 120);
            this.rad3d.Name = "rad3d";
            this.rad3d.Size = new System.Drawing.Size(100, 20);
            this.rad3d.TabIndex = 9;
            // 
            // cube3d
            // 
            this.cube3d.Location = new System.Drawing.Point(350, 94);
            this.cube3d.Name = "cube3d";
            this.cube3d.Size = new System.Drawing.Size(100, 20);
            this.cube3d.TabIndex = 8;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(204, 226);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(89, 20);
            this.fileName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Название файла";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Диагональ ромба";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Радиус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Длина ребра";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Радиус отверстия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Параметры окружности";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Параметры куба";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 284);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.rad3d);
            this.Controls.Add(this.cube3d);
            this.Controls.Add(this.diag2d);
            this.Controls.Add(this.rad2d);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save3d);
            this.Controls.Add(this.load3d);
            this.Controls.Add(this.load2d);
            this.Controls.Add(this.save2d);
            this.Name = "Window";
            this.Text = "Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save2d;
        private System.Windows.Forms.Button load2d;
        private System.Windows.Forms.Button save3d;
        private System.Windows.Forms.Button load3d;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rad2d;
        private System.Windows.Forms.TextBox diag2d;
        private System.Windows.Forms.TextBox rad3d;
        private System.Windows.Forms.TextBox cube3d;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}