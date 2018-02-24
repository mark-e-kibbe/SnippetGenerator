namespace SnippetGenerator
{
    partial class ToastNotification
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
            this.components = new System.ComponentModel.Container();
            this.tmrToastTimer = new System.Windows.Forms.Timer(this.components);
            this.lblToastMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrToastTimer
            // 
            this.tmrToastTimer.Interval = 30;
            this.tmrToastTimer.Tick += new System.EventHandler(this.tmrToastTimer_Tick);
            // 
            // lblToastMessage
            // 
            this.lblToastMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToastMessage.Location = new System.Drawing.Point(0, 0);
            this.lblToastMessage.Name = "lblToastMessage";
            this.lblToastMessage.Size = new System.Drawing.Size(378, 51);
            this.lblToastMessage.TabIndex = 0;
            this.lblToastMessage.Text = "DefaultText";
            this.lblToastMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToastNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 51);
            this.Controls.Add(this.lblToastMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastNotification";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToastNotification";
            this.Load += new System.EventHandler(this.ToastNotification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrToastTimer;
        private System.Windows.Forms.Label lblToastMessage;
    }
}