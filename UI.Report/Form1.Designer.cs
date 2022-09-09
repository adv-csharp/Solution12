namespace UI.Report
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonNotTransaction = new System.Windows.Forms.Button();
            this.buttonTrasnactionScope = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(12, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonNotTransaction
            // 
            this.buttonNotTransaction.Location = new System.Drawing.Point(199, 27);
            this.buttonNotTransaction.Name = "buttonNotTransaction";
            this.buttonNotTransaction.Size = new System.Drawing.Size(236, 53);
            this.buttonNotTransaction.TabIndex = 1;
            this.buttonNotTransaction.Text = "No Transaction";
            this.buttonNotTransaction.UseVisualStyleBackColor = true;
            this.buttonNotTransaction.Click += new System.EventHandler(this.buttonNotTransaction_Click);
            // 
            // buttonTrasnactionScope
            // 
            this.buttonTrasnactionScope.Location = new System.Drawing.Point(199, 86);
            this.buttonTrasnactionScope.Name = "buttonTrasnactionScope";
            this.buttonTrasnactionScope.Size = new System.Drawing.Size(236, 53);
            this.buttonTrasnactionScope.TabIndex = 2;
            this.buttonTrasnactionScope.Text = "TransactionScope";
            this.buttonTrasnactionScope.UseVisualStyleBackColor = true;
            this.buttonTrasnactionScope.Click += new System.EventHandler(this.buttonTrasnactionScope_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTrasnactionScope);
            this.Controls.Add(this.buttonNotTransaction);
            this.Controls.Add(this.buttonPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonNotTransaction;
        private System.Windows.Forms.Button buttonTrasnactionScope;
    }
}

