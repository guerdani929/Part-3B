namespace Part_3B
{
    partial class MainForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblMeassage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Red;
            this.btnSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubmit.Location = new System.Drawing.Point(12, 74);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 42);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Click Me";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(153, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(22, 27);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(118, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Please enter your name";
            // 
            // lblMeassage
            // 
            this.lblMeassage.AutoSize = true;
            this.lblMeassage.Location = new System.Drawing.Point(115, 88);
            this.lblMeassage.Name = "lblMeassage";
            this.lblMeassage.Size = new System.Drawing.Size(50, 13);
            this.lblMeassage.TabIndex = 3;
            this.lblMeassage.Text = "Message";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 137);
            this.Controls.Add(this.lblMeassage);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSubmit);
            this.Name = "MainForm";
            this.Text = "Getting Input";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMeassage;
    }
}

