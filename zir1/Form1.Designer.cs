namespace zir1
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
            this.keyField = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.showTable = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.inputField = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputField = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyField
            // 
            this.keyField.Location = new System.Drawing.Point(64, 96);
            this.keyField.Name = "keyField";
            this.keyField.Size = new System.Drawing.Size(242, 20);
            this.keyField.TabIndex = 0;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(23, 99);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 1;
            this.keyLabel.Text = "Key";
            // 
            // showTable
            // 
            this.showTable.Location = new System.Drawing.Point(322, 94);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(75, 23);
            this.showTable.TabIndex = 2;
            this.showTable.Text = "Show table";
            this.showTable.UseVisualStyleBackColor = true;
            this.showTable.Click += new System.EventHandler(this.showTable_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(26, 148);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(182, 23);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(215, 148);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(183, 23);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(64, 28);
            this.inputField.Multiline = true;
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(242, 62);
            this.inputField.TabIndex = 5;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(23, 31);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(31, 13);
            this.inputLabel.TabIndex = 6;
            this.inputLabel.Text = "Input";
            // 
            // outputField
            // 
            this.outputField.Location = new System.Drawing.Point(64, 200);
            this.outputField.Multiline = true;
            this.outputField.Name = "outputField";
            this.outputField.ReadOnly = true;
            this.outputField.Size = new System.Drawing.Size(242, 79);
            this.outputField.TabIndex = 7;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(24, 203);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 291);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.showTable);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyField);
            this.Name = "Form1";
            this.Text = "Playfair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyField;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button showTable;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox outputField;
        private System.Windows.Forms.Label outputLabel;
    }
}

