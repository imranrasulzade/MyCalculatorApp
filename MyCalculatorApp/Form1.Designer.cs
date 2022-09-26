namespace MyCalculatorApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number00Button = new System.Windows.Forms.Button();
            this.number0Button = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.allDeleteButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.equalsbutton = new System.Windows.Forms.Button();
            this.dividebutton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.number3Button = new System.Windows.Forms.Button();
            this.number2Button = new System.Windows.Forms.Button();
            this.number1Button = new System.Windows.Forms.Button();
            this.number6Button = new System.Windows.Forms.Button();
            this.number5Button = new System.Windows.Forms.Button();
            this.number4Button = new System.Windows.Forms.Button();
            this.number9Button = new System.Windows.Forms.Button();
            this.number8Button = new System.Windows.Forms.Button();
            this.number7Button = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 30.5F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 76);
            this.textBox1.TabIndex = 76;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number00Button
            // 
            this.number00Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number00Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number00Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number00Button.Location = new System.Drawing.Point(92, 281);
            this.number00Button.Name = "number00Button";
            this.number00Button.Size = new System.Drawing.Size(74, 58);
            this.number00Button.TabIndex = 75;
            this.number00Button.Text = "00";
            this.number00Button.UseVisualStyleBackColor = false;
            this.number00Button.Click += new System.EventHandler(this.number00Button_Click);
            // 
            // number0Button
            // 
            this.number0Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number0Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number0Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number0Button.Location = new System.Drawing.Point(12, 281);
            this.number0Button.Name = "number0Button";
            this.number0Button.Size = new System.Drawing.Size(74, 58);
            this.number0Button.TabIndex = 74;
            this.number0Button.Text = "0";
            this.number0Button.UseVisualStyleBackColor = false;
            this.number0Button.Click += new System.EventHandler(this.number0Button_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Lime;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(266, 89);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 58);
            this.deleteButton.TabIndex = 73;
            this.deleteButton.Text = "del";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // allDeleteButton
            // 
            this.allDeleteButton.BackColor = System.Drawing.Color.Lime;
            this.allDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allDeleteButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDeleteButton.Location = new System.Drawing.Point(346, 89);
            this.allDeleteButton.Name = "allDeleteButton";
            this.allDeleteButton.Size = new System.Drawing.Size(74, 58);
            this.allDeleteButton.TabIndex = 72;
            this.allDeleteButton.Text = "C";
            this.allDeleteButton.UseVisualStyleBackColor = false;
            this.allDeleteButton.Click += new System.EventHandler(this.allDeleteButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Lime;
            this.multiplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplyButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(267, 153);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(74, 58);
            this.multiplyButton.TabIndex = 71;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Lime;
            this.minusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(267, 217);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(74, 58);
            this.minusButton.TabIndex = 70;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // equalsbutton
            // 
            this.equalsbutton.BackColor = System.Drawing.Color.Crimson;
            this.equalsbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equalsbutton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.equalsbutton.Location = new System.Drawing.Point(347, 217);
            this.equalsbutton.Name = "equalsbutton";
            this.equalsbutton.Size = new System.Drawing.Size(74, 122);
            this.equalsbutton.TabIndex = 69;
            this.equalsbutton.Text = "=";
            this.equalsbutton.UseVisualStyleBackColor = false;
            this.equalsbutton.Click += new System.EventHandler(this.equalsbutton_Click);
            // 
            // dividebutton
            // 
            this.dividebutton.BackColor = System.Drawing.Color.Lime;
            this.dividebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dividebutton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividebutton.Location = new System.Drawing.Point(347, 153);
            this.dividebutton.Name = "dividebutton";
            this.dividebutton.Size = new System.Drawing.Size(74, 58);
            this.dividebutton.TabIndex = 68;
            this.dividebutton.Text = "/";
            this.dividebutton.UseVisualStyleBackColor = false;
            this.dividebutton.Click += new System.EventHandler(this.dividebutton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Lime;
            this.plusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(267, 281);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(74, 58);
            this.plusButton.TabIndex = 67;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pointButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pointButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointButton.Location = new System.Drawing.Point(172, 281);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(74, 58);
            this.pointButton.TabIndex = 66;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = false;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // number3Button
            // 
            this.number3Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number3Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3Button.Location = new System.Drawing.Point(172, 217);
            this.number3Button.Name = "number3Button";
            this.number3Button.Size = new System.Drawing.Size(74, 58);
            this.number3Button.TabIndex = 65;
            this.number3Button.Text = "3";
            this.number3Button.UseVisualStyleBackColor = false;
            this.number3Button.Click += new System.EventHandler(this.number3Button_Click);
            // 
            // number2Button
            // 
            this.number2Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number2Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2Button.Location = new System.Drawing.Point(92, 217);
            this.number2Button.Name = "number2Button";
            this.number2Button.Size = new System.Drawing.Size(74, 58);
            this.number2Button.TabIndex = 64;
            this.number2Button.Text = "2";
            this.number2Button.UseVisualStyleBackColor = false;
            this.number2Button.Click += new System.EventHandler(this.number2Button_Click);
            // 
            // number1Button
            // 
            this.number1Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number1Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1Button.Location = new System.Drawing.Point(12, 217);
            this.number1Button.Name = "number1Button";
            this.number1Button.Size = new System.Drawing.Size(74, 58);
            this.number1Button.TabIndex = 63;
            this.number1Button.Text = "1";
            this.number1Button.UseVisualStyleBackColor = false;
            this.number1Button.Click += new System.EventHandler(this.number1Button_Click);
            // 
            // number6Button
            // 
            this.number6Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number6Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number6Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number6Button.Location = new System.Drawing.Point(172, 153);
            this.number6Button.Name = "number6Button";
            this.number6Button.Size = new System.Drawing.Size(74, 58);
            this.number6Button.TabIndex = 62;
            this.number6Button.Text = "6";
            this.number6Button.UseVisualStyleBackColor = false;
            this.number6Button.Click += new System.EventHandler(this.number6Button_Click);
            // 
            // number5Button
            // 
            this.number5Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number5Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number5Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5Button.Location = new System.Drawing.Point(92, 153);
            this.number5Button.Name = "number5Button";
            this.number5Button.Size = new System.Drawing.Size(74, 58);
            this.number5Button.TabIndex = 61;
            this.number5Button.Text = "5";
            this.number5Button.UseVisualStyleBackColor = false;
            this.number5Button.Click += new System.EventHandler(this.number5Button_Click);
            // 
            // number4Button
            // 
            this.number4Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number4Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number4Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4Button.Location = new System.Drawing.Point(12, 153);
            this.number4Button.Name = "number4Button";
            this.number4Button.Size = new System.Drawing.Size(74, 58);
            this.number4Button.TabIndex = 60;
            this.number4Button.Text = "4";
            this.number4Button.UseVisualStyleBackColor = false;
            this.number4Button.Click += new System.EventHandler(this.number4Button_Click);
            // 
            // number9Button
            // 
            this.number9Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number9Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number9Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number9Button.Location = new System.Drawing.Point(172, 89);
            this.number9Button.Name = "number9Button";
            this.number9Button.Size = new System.Drawing.Size(74, 58);
            this.number9Button.TabIndex = 59;
            this.number9Button.Text = "9";
            this.number9Button.UseVisualStyleBackColor = false;
            this.number9Button.Click += new System.EventHandler(this.number9Button_Click);
            // 
            // number8Button
            // 
            this.number8Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number8Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number8Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number8Button.Location = new System.Drawing.Point(92, 89);
            this.number8Button.Name = "number8Button";
            this.number8Button.Size = new System.Drawing.Size(74, 58);
            this.number8Button.TabIndex = 58;
            this.number8Button.Text = "8";
            this.number8Button.UseVisualStyleBackColor = false;
            this.number8Button.Click += new System.EventHandler(this.number8Button_Click);
            // 
            // number7Button
            // 
            this.number7Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number7Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number7Button.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number7Button.Location = new System.Drawing.Point(12, 89);
            this.number7Button.Name = "number7Button";
            this.number7Button.Size = new System.Drawing.Size(74, 58);
            this.number7Button.TabIndex = 57;
            this.number7Button.Text = "7";
            this.number7Button.UseVisualStyleBackColor = false;
            this.number7Button.Click += new System.EventHandler(this.number7Button_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.historyButton.ForeColor = System.Drawing.Color.Black;
            this.historyButton.Location = new System.Drawing.Point(12, 12);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(107, 34);
            this.historyButton.TabIndex = 77;
            this.historyButton.Text = "history";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 349);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.number00Button);
            this.Controls.Add(this.number0Button);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.allDeleteButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.equalsbutton);
            this.Controls.Add(this.dividebutton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.number3Button);
            this.Controls.Add(this.number2Button);
            this.Controls.Add(this.number1Button);
            this.Controls.Add(this.number6Button);
            this.Controls.Add(this.number5Button);
            this.Controls.Add(this.number4Button);
            this.Controls.Add(this.number9Button);
            this.Controls.Add(this.number8Button);
            this.Controls.Add(this.number7Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button number00Button;
        private System.Windows.Forms.Button number0Button;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button allDeleteButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button equalsbutton;
        private System.Windows.Forms.Button dividebutton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button number3Button;
        private System.Windows.Forms.Button number2Button;
        private System.Windows.Forms.Button number1Button;
        private System.Windows.Forms.Button number6Button;
        private System.Windows.Forms.Button number5Button;
        private System.Windows.Forms.Button number4Button;
        private System.Windows.Forms.Button number9Button;
        private System.Windows.Forms.Button number8Button;
        private System.Windows.Forms.Button number7Button;
        private System.Windows.Forms.Button historyButton;
    }
}

