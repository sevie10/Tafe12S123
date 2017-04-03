namespace VendorMaintenance
{
    partial class frmState
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStateCode = new System.Windows.Forms.TextBox();
            this.btnGetState = new System.Windows.Forms.Button();
            this.txtStateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstZip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastZip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddState = new System.Windows.Forms.Button();
            this.btnModifyState = new System.Windows.Forms.Button();
            this.btnDeleteState = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "State Code";
            // 
            // txtStateCode
            // 
            this.txtStateCode.Location = new System.Drawing.Point(78, 6);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Size = new System.Drawing.Size(100, 20);
            this.txtStateCode.TabIndex = 1;
            // 
            // btnGetState
            // 
            this.btnGetState.Location = new System.Drawing.Point(184, 4);
            this.btnGetState.Name = "btnGetState";
            this.btnGetState.Size = new System.Drawing.Size(88, 23);
            this.btnGetState.TabIndex = 2;
            this.btnGetState.Text = "Get State Code";
            this.btnGetState.UseVisualStyleBackColor = true;
            this.btnGetState.Click += new System.EventHandler(this.btnGetState_Click);
            // 
            // txtStateName
            // 
            this.txtStateName.Location = new System.Drawing.Point(78, 32);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Size = new System.Drawing.Size(194, 20);
            this.txtStateName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "State Name";
            // 
            // txtFirstZip
            // 
            this.txtFirstZip.Location = new System.Drawing.Point(78, 58);
            this.txtFirstZip.Name = "txtFirstZip";
            this.txtFirstZip.Size = new System.Drawing.Size(194, 20);
            this.txtFirstZip.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Zip";
            // 
            // txtLastZip
            // 
            this.txtLastZip.Location = new System.Drawing.Point(78, 84);
            this.txtLastZip.Name = "txtLastZip";
            this.txtLastZip.Size = new System.Drawing.Size(194, 20);
            this.txtLastZip.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Zip";
            // 
            // btnAddState
            // 
            this.btnAddState.Location = new System.Drawing.Point(12, 110);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(75, 23);
            this.btnAddState.TabIndex = 9;
            this.btnAddState.Text = "Add";
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.btnAddState_Click);
            // 
            // btnModifyState
            // 
            this.btnModifyState.Location = new System.Drawing.Point(93, 110);
            this.btnModifyState.Name = "btnModifyState";
            this.btnModifyState.Size = new System.Drawing.Size(75, 23);
            this.btnModifyState.TabIndex = 10;
            this.btnModifyState.Text = "Modify";
            this.btnModifyState.UseVisualStyleBackColor = true;
            this.btnModifyState.Click += new System.EventHandler(this.btnModifyState_Click);
            // 
            // btnDeleteState
            // 
            this.btnDeleteState.Enabled = false;
            this.btnDeleteState.Location = new System.Drawing.Point(12, 139);
            this.btnDeleteState.Name = "btnDeleteState";
            this.btnDeleteState.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteState.TabIndex = 11;
            this.btnDeleteState.Text = "Delete";
            this.btnDeleteState.UseVisualStyleBackColor = true;
            this.btnDeleteState.Click += new System.EventHandler(this.btnDeleteState_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 139);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 110);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 52);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteState);
            this.Controls.Add(this.btnModifyState);
            this.Controls.Add(this.btnAddState);
            this.Controls.Add(this.txtLastZip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstZip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStateName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetState);
            this.Controls.Add(this.txtStateCode);
            this.Controls.Add(this.label1);
            this.Name = "frmState";
            this.Text = "frmState";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStateCode;
        private System.Windows.Forms.Button btnGetState;
        private System.Windows.Forms.TextBox txtStateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstZip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastZip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.Button btnModifyState;
        private System.Windows.Forms.Button btnDeleteState;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}