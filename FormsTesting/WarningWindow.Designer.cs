namespace FormsTesting
{
    partial class WarningWindow
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
            this.WarningMessage = new System.Windows.Forms.Label();
            this.ConfirmExit = new System.Windows.Forms.Button();
            this.CancelExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WarningMessage
            // 
            this.WarningMessage.AutoSize = true;
            this.WarningMessage.Location = new System.Drawing.Point(12, 9);
            this.WarningMessage.Name = "WarningMessage";
            this.WarningMessage.Size = new System.Drawing.Size(317, 13);
            this.WarningMessage.TabIndex = 0;
            this.WarningMessage.Text = "Warning! You have unsaved changes! Would you still like to exit?";
            // 
            // ConfirmExit
            // 
            this.ConfirmExit.Location = new System.Drawing.Point(15, 35);
            this.ConfirmExit.Name = "ConfirmExit";
            this.ConfirmExit.Size = new System.Drawing.Size(75, 23);
            this.ConfirmExit.TabIndex = 1;
            this.ConfirmExit.Text = "Yes, exit";
            this.ConfirmExit.UseVisualStyleBackColor = true;
            this.ConfirmExit.Click += new System.EventHandler(this.ConfirmExit_Click);
            // 
            // CancelExit
            // 
            this.CancelExit.Location = new System.Drawing.Point(96, 35);
            this.CancelExit.Name = "CancelExit";
            this.CancelExit.Size = new System.Drawing.Size(75, 23);
            this.CancelExit.TabIndex = 2;
            this.CancelExit.Text = "No, return";
            this.CancelExit.UseVisualStyleBackColor = true;
            this.CancelExit.Click += new System.EventHandler(this.CancelExit_Click);
            // 
            // WarningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 67);
            this.Controls.Add(this.CancelExit);
            this.Controls.Add(this.ConfirmExit);
            this.Controls.Add(this.WarningMessage);
            this.Name = "WarningWindow";
            this.Text = "WarningWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WarningMessage;
        private System.Windows.Forms.Button ConfirmExit;
        private System.Windows.Forms.Button CancelExit;
    }
}