namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftText = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.equalLabel1 = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusLabel = new System.Windows.Forms.Label();
            this.equalLabel2 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.productLeftLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.equalLabel3 = new System.Windows.Forms.Label();
            this.productRightLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.divideRightLabel = new System.Windows.Forms.Label();
            this.divideLabel = new System.Windows.Forms.Label();
            this.equalLabel4 = new System.Windows.Forms.Label();
            this.divideLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(229, 8);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // timeLeftText
            // 
            this.timeLeftText.AutoSize = true;
            this.timeLeftText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftText.Location = new System.Drawing.Point(122, 8);
            this.timeLeftText.Name = "timeLeftText";
            this.timeLeftText.Size = new System.Drawing.Size(101, 25);
            this.timeLeftText.TabIndex = 1;
            this.timeLeftText.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(44, 59);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLabel1
            // 
            this.equalLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel1.Location = new System.Drawing.Point(237, 59);
            this.equalLabel1.Name = "equalLabel1";
            this.equalLabel1.Size = new System.Drawing.Size(60, 50);
            this.equalLabel1.TabIndex = 3;
            this.equalLabel1.Text = "=";
            this.equalLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLabel
            // 
            this.plusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel.Location = new System.Drawing.Point(110, 59);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLabel.TabIndex = 4;
            this.plusLabel.Text = "+";
            this.plusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(171, 59);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 5;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(303, 68);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 35);
            this.sum.TabIndex = 1;
            this.sum.ValueChanged += new System.EventHandler(this.sum_ValueChanged);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(303, 118);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(120, 35);
            this.difference.TabIndex = 2;
            this.difference.ValueChanged += new System.EventHandler(this.difference_ValueChanged);
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(171, 109);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 10;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLabel
            // 
            this.minusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLabel.Location = new System.Drawing.Point(110, 109);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLabel.TabIndex = 9;
            this.minusLabel.Text = "-";
            this.minusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLabel2
            // 
            this.equalLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel2.Location = new System.Drawing.Point(237, 109);
            this.equalLabel2.Name = "equalLabel2";
            this.equalLabel2.Size = new System.Drawing.Size(60, 50);
            this.equalLabel2.TabIndex = 8;
            this.equalLabel2.Text = "=";
            this.equalLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(44, 109);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(303, 168);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 35);
            this.product.TabIndex = 3;
            this.product.ValueChanged += new System.EventHandler(this.product_ValueChanged);
            // 
            // productLeftLabel
            // 
            this.productLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLeftLabel.Location = new System.Drawing.Point(171, 159);
            this.productLeftLabel.Name = "productLeftLabel";
            this.productLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.productLeftLabel.TabIndex = 15;
            this.productLeftLabel.Text = "?";
            this.productLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productLabel
            // 
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(110, 159);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(60, 50);
            this.productLabel.TabIndex = 14;
            this.productLabel.Text = "*";
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLabel3
            // 
            this.equalLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel3.Location = new System.Drawing.Point(237, 159);
            this.equalLabel3.Name = "equalLabel3";
            this.equalLabel3.Size = new System.Drawing.Size(60, 50);
            this.equalLabel3.TabIndex = 13;
            this.equalLabel3.Text = "=";
            this.equalLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productRightLabel
            // 
            this.productRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productRightLabel.Location = new System.Drawing.Point(44, 159);
            this.productRightLabel.Name = "productRightLabel";
            this.productRightLabel.Size = new System.Drawing.Size(60, 50);
            this.productRightLabel.TabIndex = 12;
            this.productRightLabel.Text = "?";
            this.productRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(303, 218);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(120, 35);
            this.quotient.TabIndex = 4;
            this.quotient.ValueChanged += new System.EventHandler(this.quotient_ValueChanged);
            // 
            // divideRightLabel
            // 
            this.divideRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideRightLabel.Location = new System.Drawing.Point(171, 209);
            this.divideRightLabel.Name = "divideRightLabel";
            this.divideRightLabel.Size = new System.Drawing.Size(60, 50);
            this.divideRightLabel.TabIndex = 20;
            this.divideRightLabel.Text = "?";
            this.divideRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideLabel
            // 
            this.divideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideLabel.Location = new System.Drawing.Point(110, 209);
            this.divideLabel.Name = "divideLabel";
            this.divideLabel.Size = new System.Drawing.Size(60, 50);
            this.divideLabel.TabIndex = 19;
            this.divideLabel.Text = "/";
            this.divideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLabel4
            // 
            this.equalLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel4.Location = new System.Drawing.Point(237, 209);
            this.equalLabel4.Name = "equalLabel4";
            this.equalLabel4.Size = new System.Drawing.Size(60, 50);
            this.equalLabel4.TabIndex = 18;
            this.equalLabel4.Text = "=";
            this.equalLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideLeftLabel
            // 
            this.divideLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideLeftLabel.Location = new System.Drawing.Point(44, 209);
            this.divideLeftLabel.Name = "divideLeftLabel";
            this.divideLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.divideLeftLabel.TabIndex = 17;
            this.divideLeftLabel.Text = "?";
            this.divideLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(49, 301);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(127, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(303, 301);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(120, 34);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.divideRightLabel);
            this.Controls.Add(this.divideLabel);
            this.Controls.Add(this.equalLabel4);
            this.Controls.Add(this.divideLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.productLeftLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.equalLabel3);
            this.Controls.Add(this.productRightLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLabel);
            this.Controls.Add(this.equalLabel2);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.equalLabel1);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftText);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz | Chase Switzer";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftText;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label equalLabel1;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusLabel;
        private System.Windows.Forms.Label equalLabel2;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label productLeftLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label equalLabel3;
        private System.Windows.Forms.Label productRightLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label divideRightLabel;
        private System.Windows.Forms.Label divideLabel;
        private System.Windows.Forms.Label equalLabel4;
        private System.Windows.Forms.Label divideLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateLabel;
    }
}

