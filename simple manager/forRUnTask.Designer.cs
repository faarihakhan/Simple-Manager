namespace simple_manager
{
    partial class forRUnTask
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
            this.Opentxt = new System.Windows.Forms.TextBox();
            this.btnrun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open";
            // 
            // Opentxt
            // 
            this.Opentxt.Location = new System.Drawing.Point(72, 9);
            this.Opentxt.Name = "Opentxt";
            this.Opentxt.Size = new System.Drawing.Size(360, 20);
            this.Opentxt.TabIndex = 1;
            // 
            // btnrun
            // 
            this.btnrun.BackColor = System.Drawing.Color.SkyBlue;
            this.btnrun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrun.Location = new System.Drawing.Point(341, 37);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(91, 23);
            this.btnrun.TabIndex = 2;
            this.btnrun.Text = "Run";
            this.btnrun.UseVisualStyleBackColor = false;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // forRUnTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(444, 83);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.Opentxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "forRUnTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RUN NEW TASK";
            this.Load += new System.EventHandler(this.forRUnTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Opentxt;
        private System.Windows.Forms.Button btnrun;
    }
}