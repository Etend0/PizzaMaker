namespace FrmOrderDetails
{
    partial class Form1
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
            lblOrderDetails = new Label();
            SuspendLayout();
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Location = new Point(50, 55);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(75, 15);
            lblOrderDetails.TabIndex = 0;
            lblOrderDetails.Text = "Order Details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOrderDetails);
            Name = "Form1";
            Text = "Pizza Order Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderDetails;
    }
}
