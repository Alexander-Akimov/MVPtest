
namespace MVPtest
{
    partial class FormView
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
            this.farenheitButton = new System.Windows.Forms.Button();
            this.celsiusButton = new System.Windows.Forms.Button();
            this.celsiusBox = new System.Windows.Forms.TextBox();
            this.farenheitBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // farenheitButton
            // 
            this.farenheitButton.Location = new System.Drawing.Point(76, 127);
            this.farenheitButton.Name = "farenheitButton";
            this.farenheitButton.Size = new System.Drawing.Size(75, 23);
            this.farenheitButton.TabIndex = 0;
            this.farenheitButton.Text = "Farenheit";
            this.farenheitButton.UseVisualStyleBackColor = true;
            this.farenheitButton.Click += new System.EventHandler(this.farenheitButton_Click);
            // 
            // celsiusButton
            // 
            this.celsiusButton.Location = new System.Drawing.Point(246, 127);
            this.celsiusButton.Name = "celsiusButton";
            this.celsiusButton.Size = new System.Drawing.Size(75, 23);
            this.celsiusButton.TabIndex = 1;
            this.celsiusButton.Text = "Celsius";
            this.celsiusButton.UseVisualStyleBackColor = true;
            this.celsiusButton.Click += new System.EventHandler(this.celsiusButton_Click);
            // 
            // celsiusBox
            // 
            this.celsiusBox.Location = new System.Drawing.Point(50, 60);
            this.celsiusBox.Name = "celsiusBox";
            this.celsiusBox.Size = new System.Drawing.Size(100, 23);
            this.celsiusBox.TabIndex = 2;
            // 
            // farenheitBox
            // 
            this.farenheitBox.Location = new System.Drawing.Point(232, 60);
            this.farenheitBox.Name = "farenheitBox";
            this.farenheitBox.Size = new System.Drawing.Size(100, 23);
            this.farenheitBox.TabIndex = 3;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(141, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 23);
            this.inputBox.TabIndex = 4;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.farenheitBox);
            this.Controls.Add(this.celsiusBox);
            this.Controls.Add(this.celsiusButton);
            this.Controls.Add(this.farenheitButton);
            this.Name = "FormView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button farenheitButton;
        private System.Windows.Forms.Button celsiusButton;
        private System.Windows.Forms.TextBox celsiusBox;
        private System.Windows.Forms.TextBox farenheitBox;
        private System.Windows.Forms.TextBox inputBox;
    }
}

