namespace buttons_task
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
            this.shutdown = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.sleep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shutdown
            // 
            this.shutdown.BackColor = System.Drawing.Color.Cyan;
            this.shutdown.Location = new System.Drawing.Point(48, 58);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(217, 40);
            this.shutdown.TabIndex = 0;
            this.shutdown.Text = "shutdown";
            this.shutdown.UseVisualStyleBackColor = false;
            this.shutdown.Click += new System.EventHandler(this.button1_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Aqua;
            this.restart.Location = new System.Drawing.Point(48, 172);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(217, 40);
            this.restart.TabIndex = 1;
            this.restart.Text = "restart";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // sleep
            // 
            this.sleep.BackColor = System.Drawing.Color.Aqua;
            this.sleep.Location = new System.Drawing.Point(48, 275);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(217, 40);
            this.sleep.TabIndex = 2;
            this.sleep.Text = "sleep";
            this.sleep.UseVisualStyleBackColor = false;
            this.sleep.Click += new System.EventHandler(this.sleep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sleep);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.shutdown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button sleep;
    }
}

