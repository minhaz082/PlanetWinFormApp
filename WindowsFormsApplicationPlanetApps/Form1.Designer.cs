namespace WindowsFormsApplicationPlanetApps
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
            this.planetLabel = new System.Windows.Forms.Label();
            this.planetNameComboBox = new System.Windows.Forms.ComboBox();
            this.planetNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planetLabel
            // 
            this.planetLabel.AutoSize = true;
            this.planetLabel.Location = new System.Drawing.Point(62, 33);
            this.planetLabel.Name = "planetLabel";
            this.planetLabel.Size = new System.Drawing.Size(68, 13);
            this.planetLabel.TabIndex = 0;
            this.planetLabel.Text = "Planet Name";
            // 
            // planetNameComboBox
            // 
            this.planetNameComboBox.FormattingEnabled = true;
            this.planetNameComboBox.Items.AddRange(new object[] {
            "Planet",
            "Saturn",
            "Mars"});
            this.planetNameComboBox.Location = new System.Drawing.Point(144, 24);
            this.planetNameComboBox.Name = "planetNameComboBox";
            this.planetNameComboBox.Size = new System.Drawing.Size(176, 21);
            this.planetNameComboBox.TabIndex = 1;
            // 
            // planetNumberButton
            // 
            this.planetNumberButton.Location = new System.Drawing.Point(144, 66);
            this.planetNumberButton.Name = "planetNumberButton";
            this.planetNumberButton.Size = new System.Drawing.Size(147, 23);
            this.planetNumberButton.TabIndex = 2;
            this.planetNumberButton.Text = "Show Planet Number";
            this.planetNumberButton.UseVisualStyleBackColor = true;
            this.planetNumberButton.Click += new System.EventHandler(this.planetNumberButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 262);
            this.Controls.Add(this.planetNumberButton);
            this.Controls.Add(this.planetNameComboBox);
            this.Controls.Add(this.planetLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Conditional Statement Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label planetLabel;
        private System.Windows.Forms.ComboBox planetNameComboBox;
        private System.Windows.Forms.Button planetNumberButton;
    }
}

