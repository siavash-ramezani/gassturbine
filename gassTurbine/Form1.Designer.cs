namespace gassTurbine
{
    partial class Form1
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
            this.InletPressureLoss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutletPressureLoss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LHV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AmbientTemperature = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.Temperature = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InletPressureLoss
            // 
            this.InletPressureLoss.BackColor = System.Drawing.Color.White;
            this.InletPressureLoss.Location = new System.Drawing.Point(161, 44);
            this.InletPressureLoss.Name = "InletPressureLoss";
            this.InletPressureLoss.Size = new System.Drawing.Size(121, 20);
            this.InletPressureLoss.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inlet pressure loss";
            // 
            // OutletPressureLoss
            // 
            this.OutletPressureLoss.Location = new System.Drawing.Point(161, 84);
            this.OutletPressureLoss.Name = "OutletPressureLoss";
            this.OutletPressureLoss.Size = new System.Drawing.Size(121, 20);
            this.OutletPressureLoss.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Outlet pressure loss";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // CH
            // 
            this.CH.FormattingEnabled = true;
            this.CH.Items.AddRange(new object[] {
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7"});
            this.CH.Location = new System.Drawing.Point(161, 118);
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(121, 21);
            this.CH.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "C/H ratio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "LHV";
            // 
            // LHV
            // 
            this.LHV.Location = new System.Drawing.Point(161, 156);
            this.LHV.Name = "LHV";
            this.LHV.Size = new System.Drawing.Size(121, 20);
            this.LHV.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Humidity";
            // 
            // Humidity
            // 
            this.Humidity.Location = new System.Drawing.Point(161, 195);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(121, 20);
            this.Humidity.TabIndex = 9;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(161, 258);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(121, 20);
            this.speed.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ambient Temperature";
            // 
            // AmbientTemperature
            // 
            this.AmbientTemperature.Location = new System.Drawing.Point(161, 285);
            this.AmbientTemperature.Name = "AmbientTemperature";
            this.AmbientTemperature.Size = new System.Drawing.Size(121, 20);
            this.AmbientTemperature.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(161, 335);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Operating Hours ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Result";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(161, 390);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(121, 20);
            this.result.TabIndex = 19;
            // 
            // Temperature
            // 
            this.Temperature.FormattingEnabled = true;
            this.Temperature.Items.AddRange(new object[] {
            "-15",
            "0",
            "15",
            "30",
            "45"});
            this.Temperature.Location = new System.Drawing.Point(161, 223);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(121, 21);
            this.Temperature.TabIndex = 23;
            this.Temperature.TabStop = false;
            this.Temperature.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Temperature";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 426);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.AmbientTemperature);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LHV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutletPressureLoss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InletPressureLoss);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InletPressureLoss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutletPressureLoss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LHV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Humidity;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AmbientTemperature;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ComboBox Temperature;
        private System.Windows.Forms.Label label11;
    }
}

