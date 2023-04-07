namespace KdgTranslationApp
{
    partial class KdgTranslateApp
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
            this.cbtnCamera = new DevExpress.XtraEditors.CheckButton();
            this.tb_quest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbtnCamera
            // 
            this.cbtnCamera.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.camera;
            this.cbtnCamera.Location = new System.Drawing.Point(388, 129);
            this.cbtnCamera.Name = "cbtnCamera";
            this.cbtnCamera.Size = new System.Drawing.Size(23, 18);
            this.cbtnCamera.TabIndex = 0;
            this.cbtnCamera.Text = "checkButton1";
            this.cbtnCamera.Click += new System.EventHandler(this.cbtnCamera_Click);
            // 
            // tb_quest
            // 
            this.tb_quest.Location = new System.Drawing.Point(13, 13);
            this.tb_quest.Multiline = true;
            this.tb_quest.Name = "tb_quest";
            this.tb_quest.Size = new System.Drawing.Size(450, 110);
            this.tb_quest.TabIndex = 1;
            // 
            // KdgTranslateApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.tb_quest);
            this.Controls.Add(this.cbtnCamera);
            this.MaximizeBox = false;
            this.Name = "KdgTranslateApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KdgTranslate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton cbtnCamera;
        private System.Windows.Forms.TextBox tb_quest;
    }
}

