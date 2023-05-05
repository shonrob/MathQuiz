namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label2 = new Label();
            plusLeftLabel = new Label();
            plusRightLabel = new Label();
            additionSignLabel = new Label();
            label5 = new Label();
            sum = new NumericUpDown();
            subtractionLeftLabel = new Label();
            subtractionSignLabel = new Label();
            subtractionRightLabel = new Label();
            label8 = new Label();
            timesLeftLabel = new Label();
            multiplecationSignLabel = new Label();
            timesRightLabel = new Label();
            label12 = new Label();
            dividedLeftLabel = new Label();
            divisionSignLabel = new Label();
            dividedRightLabel = new Label();
            label16 = new Label();
            difference = new NumericUpDown();
            product = new NumericUpDown();
            quotient = new NumericUpDown();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(272, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(167, 10);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 1;
            label2.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusLeftLabel.Location = new Point(50, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusRightLabel.Location = new Point(182, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // additionSignLabel
            // 
            additionSignLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            additionSignLabel.Location = new Point(116, 75);
            additionSignLabel.Name = "additionSignLabel";
            additionSignLabel.Size = new Size(60, 50);
            additionSignLabel.TabIndex = 4;
            additionSignLabel.Text = "+";
            additionSignLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(248, 75);
            label5.Name = "label5";
            label5.Size = new Size(60, 50);
            label5.TabIndex = 5;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sum.Location = new Point(293, 82);
            sum.Name = "sum";
            sum.Size = new Size(100, 39);
            sum.TabIndex = 1;
            sum.Click += answer_Enter;
            sum.Enter += answer_Enter;
            // 
            // subtractionLeftLabel
            // 
            subtractionLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            subtractionLeftLabel.Location = new Point(50, 125);
            subtractionLeftLabel.Name = "subtractionLeftLabel";
            subtractionLeftLabel.Size = new Size(60, 50);
            subtractionLeftLabel.TabIndex = 7;
            subtractionLeftLabel.Text = "?";
            subtractionLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtractionSignLabel
            // 
            subtractionSignLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            subtractionSignLabel.Location = new Point(116, 125);
            subtractionSignLabel.Name = "subtractionSignLabel";
            subtractionSignLabel.Size = new Size(60, 50);
            subtractionSignLabel.TabIndex = 8;
            subtractionSignLabel.Text = "-";
            subtractionSignLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtractionRightLabel
            // 
            subtractionRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            subtractionRightLabel.Location = new Point(182, 125);
            subtractionRightLabel.Name = "subtractionRightLabel";
            subtractionRightLabel.Size = new Size(60, 50);
            subtractionRightLabel.TabIndex = 9;
            subtractionRightLabel.Text = "?";
            subtractionRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(248, 125);
            label8.Name = "label8";
            label8.Size = new Size(60, 50);
            label8.TabIndex = 10;
            label8.Text = "=";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesLeftLabel.Location = new Point(50, 175);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 11;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // multiplecationSignLabel
            // 
            multiplecationSignLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            multiplecationSignLabel.Location = new Point(116, 175);
            multiplecationSignLabel.Name = "multiplecationSignLabel";
            multiplecationSignLabel.Size = new Size(60, 50);
            multiplecationSignLabel.TabIndex = 12;
            multiplecationSignLabel.Text = "x";
            multiplecationSignLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesRightLabel.Location = new Point(182, 175);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 13;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(248, 175);
            label12.Name = "label12";
            label12.Size = new Size(60, 50);
            label12.TabIndex = 14;
            label12.Text = "=";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedLeftLabel.Location = new Point(50, 225);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 15;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divisionSignLabel
            // 
            divisionSignLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            divisionSignLabel.Location = new Point(116, 225);
            divisionSignLabel.Name = "divisionSignLabel";
            divisionSignLabel.Size = new Size(60, 50);
            divisionSignLabel.TabIndex = 16;
            divisionSignLabel.Text = "/";
            divisionSignLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedRightLabel.Location = new Point(182, 225);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 17;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(248, 225);
            label16.Name = "label16";
            label16.Size = new Size(60, 50);
            label16.TabIndex = 18;
            label16.Text = "=";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            difference.Location = new Point(293, 136);
            difference.Name = "difference";
            difference.Size = new Size(100, 39);
            difference.TabIndex = 2;
            difference.Click += answer_Enter;
            difference.Enter += answer_Enter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            product.Location = new Point(293, 183);
            product.Name = "product";
            product.Size = new Size(100, 39);
            product.TabIndex = 3;
            product.Click += answer_Enter;
            product.Enter += answer_Enter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quotient.Location = new Point(293, 228);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 39);
            quotient.TabIndex = 4;
            quotient.Click += answer_Enter;
            quotient.Enter += answer_Enter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(167, 295);
            startButton.Name = "startButton";
            startButton.Size = new Size(136, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Start the Quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(12, 10);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(65, 21);
            dateLabel.TabIndex = 19;
            dateLabel.Text = "Today is";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(dateLabel);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(product);
            Controls.Add(difference);
            Controls.Add(label16);
            Controls.Add(dividedRightLabel);
            Controls.Add(divisionSignLabel);
            Controls.Add(dividedLeftLabel);
            Controls.Add(label12);
            Controls.Add(timesRightLabel);
            Controls.Add(multiplecationSignLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(label8);
            Controls.Add(subtractionRightLabel);
            Controls.Add(subtractionSignLabel);
            Controls.Add(subtractionLeftLabel);
            Controls.Add(sum);
            Controls.Add(label5);
            Controls.Add(additionSignLabel);
            Controls.Add(plusRightLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(label2);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Shonda Robinson Math Quiz";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label2;
        private Label plusLeftLabel;
        private Label plusRightLabel;
        private Label additionSignLabel;
        private Label label5;
        private NumericUpDown sum;
        private Label subtractionLeftLabel;
        private Label subtractionSignLabel;
        private Label subtractionRightLabel;
        private Label label8;
        private Label timesLeftLabel;
        private Label multiplecationSignLabel;
        private Label timesRightLabel;
        private Label label12;
        private Label dividedLeftLabel;
        private Label divisionSignLabel;
        private Label dividedRightLabel;
        private Label label16;
        private NumericUpDown difference;
        private NumericUpDown product;
        private NumericUpDown quotient;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label dateLabel;
    }
}