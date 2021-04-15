
namespace Calculator
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
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.KeerButton = new System.Windows.Forms.Button();
            this.DeelButton = new System.Windows.Forms.Button();
            this.RootButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.SecondNumberTextBox = new System.Windows.Forms.TextBox();
            this.DoubleTextBox = new System.Windows.Forms.TextBox();
            this.DecimalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(91, 209);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(101, 95);
            this.PlusButton.TabIndex = 0;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinButton.Location = new System.Drawing.Point(198, 209);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(101, 95);
            this.MinButton.TabIndex = 1;
            this.MinButton.Text = "-";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // KeerButton
            // 
            this.KeerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeerButton.Location = new System.Drawing.Point(305, 209);
            this.KeerButton.Name = "KeerButton";
            this.KeerButton.Size = new System.Drawing.Size(101, 95);
            this.KeerButton.TabIndex = 2;
            this.KeerButton.Text = "*";
            this.KeerButton.UseVisualStyleBackColor = true;
            this.KeerButton.Click += new System.EventHandler(this.KeerButton_Click);
            // 
            // DeelButton
            // 
            this.DeelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeelButton.Location = new System.Drawing.Point(91, 310);
            this.DeelButton.Name = "DeelButton";
            this.DeelButton.Size = new System.Drawing.Size(101, 95);
            this.DeelButton.TabIndex = 3;
            this.DeelButton.Text = "/";
            this.DeelButton.UseVisualStyleBackColor = true;
            this.DeelButton.Click += new System.EventHandler(this.DeelButton_Click);
            // 
            // RootButton
            // 
            this.RootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RootButton.Location = new System.Drawing.Point(198, 310);
            this.RootButton.Name = "RootButton";
            this.RootButton.Size = new System.Drawing.Size(101, 95);
            this.RootButton.TabIndex = 4;
            this.RootButton.Text = "√";
            this.RootButton.UseVisualStyleBackColor = true;
            this.RootButton.Click += new System.EventHandler(this.RootButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(305, 310);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(101, 95);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumberTextBox.Location = new System.Drawing.Point(91, 122);
            this.FirstNumberTextBox.Multiline = true;
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            this.FirstNumberTextBox.Size = new System.Drawing.Size(159, 67);
            this.FirstNumberTextBox.TabIndex = 6;
            this.FirstNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecondNumberTextBox
            // 
            this.SecondNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumberTextBox.Location = new System.Drawing.Point(250, 122);
            this.SecondNumberTextBox.Multiline = true;
            this.SecondNumberTextBox.Name = "SecondNumberTextBox";
            this.SecondNumberTextBox.Size = new System.Drawing.Size(159, 67);
            this.SecondNumberTextBox.TabIndex = 7;
            this.SecondNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DoubleTextBox
            // 
            this.DoubleTextBox.Location = new System.Drawing.Point(430, 150);
            this.DoubleTextBox.Multiline = true;
            this.DoubleTextBox.Name = "DoubleTextBox";
            this.DoubleTextBox.ReadOnly = true;
            this.DoubleTextBox.Size = new System.Drawing.Size(345, 102);
            this.DoubleTextBox.TabIndex = 8;
            // 
            // DecimalTextBox
            // 
            this.DecimalTextBox.Location = new System.Drawing.Point(430, 303);
            this.DecimalTextBox.Multiline = true;
            this.DecimalTextBox.Name = "DecimalTextBox";
            this.DecimalTextBox.ReadOnly = true;
            this.DecimalTextBox.Size = new System.Drawing.Size(345, 102);
            this.DecimalTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Double";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Decimal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecimalTextBox);
            this.Controls.Add(this.DoubleTextBox);
            this.Controls.Add(this.SecondNumberTextBox);
            this.Controls.Add(this.FirstNumberTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RootButton);
            this.Controls.Add(this.DeelButton);
            this.Controls.Add(this.KeerButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.PlusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button KeerButton;
        private System.Windows.Forms.Button DeelButton;
        private System.Windows.Forms.Button RootButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox FirstNumberTextBox;
        private System.Windows.Forms.TextBox SecondNumberTextBox;
        private System.Windows.Forms.TextBox DoubleTextBox;
        private System.Windows.Forms.TextBox DecimalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

