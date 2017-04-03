namespace VendorMaintenance
{
    partial class frmAddModifyTerm
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.termLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.dueLabel = new System.Windows.Forms.Label();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.dueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(60, 238);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(100, 32);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(384, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 32);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(56, 47);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(70, 20);
            this.termLabel.TabIndex = 2;
            this.termLabel.Text = "Term ID:";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(56, 111);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(93, 20);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "Description:";
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Location = new System.Drawing.Point(56, 176);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(83, 20);
            this.dueLabel.TabIndex = 4;
            this.dueLabel.Text = "Due Days:";
            // 
            // termTextBox
            // 
            this.termTextBox.Location = new System.Drawing.Point(265, 47);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(100, 26);
            this.termTextBox.TabIndex = 5;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(265, 104);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(166, 26);
            this.descTextBox.TabIndex = 6;
            // 
            // dueTextBox
            // 
            this.dueTextBox.Location = new System.Drawing.Point(265, 169);
            this.dueTextBox.Name = "dueTextBox";
            this.dueTextBox.Size = new System.Drawing.Size(100, 26);
            this.dueTextBox.TabIndex = 7;
            // 
            // frmAddModifyTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 324);
            this.Controls.Add(this.dueTextBox);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.termTextBox);
            this.Controls.Add(this.dueLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.termLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "frmAddModifyTerm";
            this.Text = "Add/Modify Terms";
            this.Load += new System.EventHandler(this.frmAddModifyTerm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label dueLabel;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox dueTextBox;
    }
}