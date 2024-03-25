namespace Login
{
    partial class FrmDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDash));
            lblUserGreeting = new Label();
            SuspendLayout();
            // 
            // lblUserGreeting
            // 
            lblUserGreeting.AutoSize = true;
            lblUserGreeting.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUserGreeting.Location = new Point(12, 9);
            lblUserGreeting.Name = "lblUserGreeting";
            lblUserGreeting.Size = new Size(215, 37);
            lblUserGreeting.TabIndex = 0;
            lblUserGreeting.Text = "Greetings User!";
            // 
            // FrmDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUserGreeting);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDash";
            Text = "Dashboard";
            Load += FrmDash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserGreeting;
    }
}