namespace курсовая_по_тп
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(533, 382);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 406);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(141, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(279, 406);
            this.trackBar2.Maximum = 30;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(138, 56);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(684, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выкл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(553, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Вкл";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(623, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Гравитация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Размер счетчика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(299, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во частиц";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(553, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "Красный";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lavender;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(553, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "Голубой";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lavender;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(554, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "Желтый";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lavender;
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(554, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(235, 27);
            this.button6.TabIndex = 11;
            this.button6.Text = "Розовый";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lavender;
            this.button7.Location = new System.Drawing.Point(554, 240);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 27);
            this.button7.TabIndex = 12;
            this.button7.Text = "Зеленый";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Lavender;
            this.button8.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(554, 285);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(235, 27);
            this.button8.TabIndex = 13;
            this.button8.Text = "Коричневый";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(591, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Цвет частиц:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 16;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Lavender;
            this.button9.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(554, 330);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(235, 27);
            this.button9.TabIndex = 17;
            this.button9.Text = "Фиолетовый";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(806, 455);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Частицы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
    }
}

