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
            this.components = new System.ComponentModel.Container();
            this.cbtnCamera = new DevExpress.XtraEditors.CheckButton();
            this.contextMenuStrip_Camera = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_quest = new System.Windows.Forms.TextBox();
            this.contextMenuStrip_Camera.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbtnCamera
            // 
            this.cbtnCamera.ContextMenuStrip = this.contextMenuStrip_Camera;
            this.cbtnCamera.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.camera;
            this.cbtnCamera.Location = new System.Drawing.Point(388, 129);
            this.cbtnCamera.Name = "cbtnCamera";
            this.cbtnCamera.Size = new System.Drawing.Size(23, 18);
            this.cbtnCamera.TabIndex = 0;
            this.cbtnCamera.Text = "checkButton1";
            this.cbtnCamera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbtnCamera_MouseDown);
            // 
            // contextMenuStrip_Camera
            // 
            this.contextMenuStrip_Camera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vietnameseToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.contextMenuStrip_Camera.Name = "contextMenuStrip_Camera";
            this.contextMenuStrip_Camera.Size = new System.Drawing.Size(136, 48);
            // 
            // vietnameseToolStripMenuItem
            // 
            this.vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            this.vietnameseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.vietnameseToolStripMenuItem.Text = "Vietnamese";
            this.vietnameseToolStripMenuItem.Click += new System.EventHandler(this.vietnameseToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
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
            this.contextMenuStrip_Camera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton cbtnCamera;
        private System.Windows.Forms.TextBox tb_quest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Camera;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

