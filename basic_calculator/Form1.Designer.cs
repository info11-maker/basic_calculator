
namespace basic_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(350, 159);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(58, 44);
            this.button17.TabIndex = 37;
            this.button17.Text = "CE";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(350, 220);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(58, 44);
            this.button18.TabIndex = 36;
            this.button18.Text = "C";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(350, 281);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(58, 106);
            this.buttonEqual.TabIndex = 35;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(268, 343);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(58, 44);
            this.button12.TabIndex = 34;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(268, 159);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(58, 44);
            this.button13.TabIndex = 33;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(268, 220);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(58, 44);
            this.button14.TabIndex = 32;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(268, 281);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(58, 44);
            this.button15.TabIndex = 31;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Operation_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoint.Location = new System.Drawing.Point(191, 343);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(58, 44);
            this.buttonPoint.TabIndex = 30;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.Number_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(27, 343);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(143, 44);
            this.button0.TabIndex = 29;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Number_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(191, 159);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 44);
            this.button9.TabIndex = 28;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Number_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(112, 159);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 44);
            this.button8.TabIndex = 27;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Number_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 159);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 44);
            this.button7.TabIndex = 26;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Number_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 44);
            this.button6.TabIndex = 25;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Number_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 44);
            this.button5.TabIndex = 24;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Number_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 44);
            this.button4.TabIndex = 23;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Number_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 44);
            this.button3.TabIndex = 22;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Number_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Number_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Number_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDisplay.Location = new System.Drawing.Point(27, 63);
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(381, 49);
            this.TxtDisplay.TabIndex = 19;
            this.TxtDisplay.Text = "0";
            this.TxtDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 422);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TxtDisplay;
    }
}

