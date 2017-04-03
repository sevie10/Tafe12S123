namespace VendorMaintenance
{
    partial class frmTerm
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
            this.termLabel = new System.Windows.Forms.Label();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.dueDaysLabel = new System.Windows.Forms.Label();
            this.dueDaysTextBox = new System.Windows.Forms.TextBox();
            this.getTermButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(18, 94);
            this.termLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(70, 20);
            this.termLabel.TabIndex = 0;
            this.termLabel.Text = "Term ID:";
            // 
            // termTextBox
            // 
            this.termTextBox.Location = new System.Drawing.Point(162, 83);
            this.termTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(148, 26);
            this.termTextBox.TabIndex = 1;
            this.termTextBox.Tag = "Term ID";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(18, 142);
            this.descLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(93, 20);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "Description:";
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(162, 131);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.ReadOnly = true;
            this.descTextBox.Size = new System.Drawing.Size(148, 26);
            this.descTextBox.TabIndex = 3;
            // 
            // dueDaysLabel
            // 
            this.dueDaysLabel.AutoSize = true;
            this.dueDaysLabel.Location = new System.Drawing.Point(18, 191);
            this.dueDaysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dueDaysLabel.Name = "dueDaysLabel";
            this.dueDaysLabel.Size = new System.Drawing.Size(83, 20);
            this.dueDaysLabel.TabIndex = 4;
            this.dueDaysLabel.Text = "Due Days:";
            // 
            // dueDaysTextBox
            // 
            this.dueDaysTextBox.Location = new System.Drawing.Point(162, 191);
            this.dueDaysTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dueDaysTextBox.Name = "dueDaysTextBox";
            this.dueDaysTextBox.ReadOnly = true;
            this.dueDaysTextBox.Size = new System.Drawing.Size(148, 26);
            this.dueDaysTextBox.TabIndex = 5;
            // 
            // getTermButton
            // 
            this.getTermButton.Location = new System.Drawing.Point(368, 78);
            this.getTermButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getTermButton.Name = "getTermButton";
            this.getTermButton.Size = new System.Drawing.Size(112, 35);
            this.getTermButton.TabIndex = 6;
            this.getTermButton.Text = "Get Term";
            this.getTermButton.UseVisualStyleBackColor = true;
            this.getTermButton.Click += new System.EventHandler(this.getTermButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(-1, 302);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 35);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Enabled = false;
            this.modifyButton.Location = new System.Drawing.Point(95, 302);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(76, 35);
            this.modifyButton.TabIndex = 8;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(198, 302);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(84, 35);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(423, 302);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 35);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(315, 302);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 35);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // frmTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 402);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.getTermButton);
            this.Controls.Add(this.dueDaysTextBox);
            this.Controls.Add(this.dueDaysLabel);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.termTextBox);
            this.Controls.Add(this.termLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTerm";
            this.Text = "frmTerm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label dueDaysLabel;
        private System.Windows.Forms.TextBox dueDaysTextBox;
        private System.Windows.Forms.Button getTermButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}