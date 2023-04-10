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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KdgTranslateApp));
            this.contextMenuStrip_Camera = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_quest = new System.Windows.Forms.TextBox();
            this.cbb_quest = new System.Windows.Forms.ComboBox();
            this.cbb_answer = new System.Windows.Forms.ComboBox();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.rbtn_AutoTranslate = new System.Windows.Forms.RadioButton();
            this.notifyIcon_Taskbar = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_notifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kdgTranslateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textRecognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnVoiceInput = new DevExpress.XtraEditors.CheckButton();
            this.cbtn_answerSpeak = new DevExpress.XtraEditors.CheckButton();
            this.cbtn_questSpeak = new DevExpress.XtraEditors.CheckButton();
            this.cbtnReset = new DevExpress.XtraEditors.CheckButton();
            this.cbtnSwitch = new DevExpress.XtraEditors.CheckButton();
            this.cbtnCamera = new DevExpress.XtraEditors.CheckButton();
            this.contextMenuStrip_Camera.SuspendLayout();
            this.contextMenuStrip_notifyIcon.SuspendLayout();
            this.SuspendLayout();
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
            this.tb_quest.Location = new System.Drawing.Point(13, 21);
            this.tb_quest.Multiline = true;
            this.tb_quest.Name = "tb_quest";
            this.tb_quest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_quest.Size = new System.Drawing.Size(435, 110);
            this.tb_quest.TabIndex = 1;
            this.tb_quest.TextChanged += new System.EventHandler(this.tb_quest_TextChanged);
            // 
            // cbb_quest
            // 
            this.cbb_quest.FormattingEnabled = true;
            this.cbb_quest.Items.AddRange(new object[] {
            "Detect",
            "Afrikaans",
            "Albanian",
            "Amharic",
            "Arabic",
            "Armenian",
            "Azerbaijani",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bosnian",
            "Bulgarian",
            "Catalan",
            "Cebuano",
            "Chichewa",
            "Chinese (Simplified)",
            "Chinese (Traditional)",
            "Corsican",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Esperanto",
            "Estonian",
            "Filipino",
            "Finnish",
            "French",
            "Frisian",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Gujarati",
            "Haitian Creole",
            "Hausa",
            "Hawaiian",
            "Hebrew",
            "Hindi",
            "Hmong",
            "Hungarian",
            "Icelandic",
            "Igbo",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Javanese",
            "Kannada",
            "Kazakh",
            "Khmer",
            "Kinyarwanda",
            "Korean",
            "Kurdish (Kurmanji)",
            "Kyrgyz",
            "Lao",
            "Latin",
            "Latvian",
            "Lithuanian",
            "Luxembourgish",
            "Macedonian",
            "Malagasy",
            "Malay",
            "Malayalam",
            "Maltese",
            "Maori",
            "Marathi",
            "Mongolian",
            "Myanmar (Burmese)",
            "Nepali",
            "Norwegian",
            "Nyanja (Chichewa)",
            "Odia (Oriya)",
            "Pashto",
            "Persian",
            "Polish",
            "Portuguese",
            "Punjabi",
            "Romanian",
            "Russian",
            "Samoan",
            "Scots Gaelic",
            "Serbian",
            "Sesotho",
            "Shona",
            "Sindhi",
            "Sinhala (Sinhalese)",
            "Slovak",
            "Slovenian",
            "Somali",
            "Spanish",
            "Sundanese",
            "Swahili",
            "Swedish",
            "Tajik",
            "Tamil",
            "Tatar",
            "Telugu",
            "Thai",
            "Turkish",
            "Turkmen",
            "Ukrainian",
            "Urdu",
            "Uyghur",
            "Uzbek",
            "Vietnamese",
            "Welsh",
            "Xhosa",
            "Yiddish",
            "Yoruba",
            "Zulu"});
            this.cbb_quest.Location = new System.Drawing.Point(46, 137);
            this.cbb_quest.Name = "cbb_quest";
            this.cbb_quest.Size = new System.Drawing.Size(145, 21);
            this.cbb_quest.TabIndex = 2;
            this.cbb_quest.SelectedIndexChanged += new System.EventHandler(this.cbb_quest_SelectedIndexChanged);
            // 
            // cbb_answer
            // 
            this.cbb_answer.FormattingEnabled = true;
            this.cbb_answer.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Amharic",
            "Arabic",
            "Armenian",
            "Azerbaijani",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bosnian",
            "Bulgarian",
            "Catalan",
            "Cebuano",
            "Chichewa",
            "Chinese (Simplified)",
            "Chinese (Traditional)",
            "Corsican",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Esperanto",
            "Estonian",
            "Filipino",
            "Finnish",
            "French",
            "Frisian",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Gujarati",
            "Haitian Creole",
            "Hausa",
            "Hawaiian",
            "Hebrew",
            "Hindi",
            "Hmong",
            "Hungarian",
            "Icelandic",
            "Igbo",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Javanese",
            "Kannada",
            "Kazakh",
            "Khmer",
            "Kinyarwanda",
            "Korean",
            "Kurdish (Kurmanji)",
            "Kyrgyz",
            "Lao",
            "Latin",
            "Latvian",
            "Lithuanian",
            "Luxembourgish",
            "Macedonian",
            "Malagasy",
            "Malay",
            "Malayalam",
            "Maltese",
            "Maori",
            "Marathi",
            "Mongolian",
            "Myanmar (Burmese)",
            "Nepali",
            "Norwegian",
            "Nyanja (Chichewa)",
            "Odia (Oriya)",
            "Pashto",
            "Persian",
            "Polish",
            "Portuguese",
            "Punjabi",
            "Romanian",
            "Russian",
            "Samoan",
            "Scots Gaelic",
            "Serbian",
            "Sesotho",
            "Shona",
            "Sindhi",
            "Sinhala (Sinhalese)",
            "Slovak",
            "Slovenian",
            "Somali",
            "Spanish",
            "Sundanese",
            "Swahili",
            "Swedish",
            "Tajik",
            "Tamil",
            "Tatar",
            "Telugu",
            "Thai",
            "Turkish",
            "Turkmen",
            "Ukrainian",
            "Urdu",
            "Uyghur",
            "Uzbek",
            "Vietnamese",
            "Welsh",
            "Xhosa",
            "Yiddish",
            "Yoruba",
            "Zulu"});
            this.cbb_answer.Location = new System.Drawing.Point(233, 137);
            this.cbb_answer.Name = "cbb_answer";
            this.cbb_answer.Size = new System.Drawing.Size(145, 21);
            this.cbb_answer.TabIndex = 2;
            this.cbb_answer.SelectedIndexChanged += new System.EventHandler(this.cbb_answer_SelectedIndexChanged);
            // 
            // tb_answer
            // 
            this.tb_answer.Location = new System.Drawing.Point(13, 165);
            this.tb_answer.Multiline = true;
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.ReadOnly = true;
            this.tb_answer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_answer.Size = new System.Drawing.Size(435, 110);
            this.tb_answer.TabIndex = 4;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(384, 136);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(64, 23);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // rbtn_AutoTranslate
            // 
            this.rbtn_AutoTranslate.AutoSize = true;
            this.rbtn_AutoTranslate.Location = new System.Drawing.Point(338, 0);
            this.rbtn_AutoTranslate.Name = "rbtn_AutoTranslate";
            this.rbtn_AutoTranslate.Size = new System.Drawing.Size(114, 17);
            this.rbtn_AutoTranslate.TabIndex = 7;
            this.rbtn_AutoTranslate.TabStop = true;
            this.rbtn_AutoTranslate.Text = "Instant translation";
            this.rbtn_AutoTranslate.UseVisualStyleBackColor = true;
            this.rbtn_AutoTranslate.Click += new System.EventHandler(this.rbtn_AutoTranslate_Click);
            // 
            // notifyIcon_Taskbar
            // 
            this.notifyIcon_Taskbar.ContextMenuStrip = this.contextMenuStrip_notifyIcon;
            this.notifyIcon_Taskbar.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Taskbar.Icon")));
            this.notifyIcon_Taskbar.Text = "KdgTranslate";
            this.notifyIcon_Taskbar.Visible = true;
            this.notifyIcon_Taskbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_Taskbar_MouseClick);
            // 
            // contextMenuStrip_notifyIcon
            // 
            this.contextMenuStrip_notifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kdgTranslateToolStripMenuItem,
            this.textRecognitionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip_notifyIcon.Name = "contextMenuStrip_notifyIcon";
            this.contextMenuStrip_notifyIcon.Size = new System.Drawing.Size(160, 70);
            // 
            // kdgTranslateToolStripMenuItem
            // 
            this.kdgTranslateToolStripMenuItem.Name = "kdgTranslateToolStripMenuItem";
            this.kdgTranslateToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kdgTranslateToolStripMenuItem.Text = "KdgTranslate";
            this.kdgTranslateToolStripMenuItem.Click += new System.EventHandler(this.kdgTranslateToolStripMenuItem_Click);
            // 
            // textRecognitionToolStripMenuItem
            // 
            this.textRecognitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem1,
            this.vietnameseToolStripMenuItem1});
            this.textRecognitionToolStripMenuItem.Name = "textRecognitionToolStripMenuItem";
            this.textRecognitionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.textRecognitionToolStripMenuItem.Text = "Text recognition";
            // 
            // englishToolStripMenuItem1
            // 
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            this.englishToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.englishToolStripMenuItem1.Text = "English";
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.englishToolStripMenuItem1_Click);
            // 
            // vietnameseToolStripMenuItem1
            // 
            this.vietnameseToolStripMenuItem1.Name = "vietnameseToolStripMenuItem1";
            this.vietnameseToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.vietnameseToolStripMenuItem1.Text = "Vietnamese";
            this.vietnameseToolStripMenuItem1.Click += new System.EventHandler(this.vietnameseToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cbtnVoiceInput
            // 
            this.cbtnVoiceInput.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.google_voice;
            this.cbtnVoiceInput.Location = new System.Drawing.Point(369, 113);
            this.cbtnVoiceInput.Name = "cbtnVoiceInput";
            this.cbtnVoiceInput.Size = new System.Drawing.Size(23, 18);
            this.cbtnVoiceInput.TabIndex = 10;
            this.cbtnVoiceInput.Text = "checkButton1";
            this.cbtnVoiceInput.Click += new System.EventHandler(this.cbtnVoiceInput_Click);
            // 
            // cbtn_answerSpeak
            // 
            this.cbtn_answerSpeak.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.sound;
            this.cbtn_answerSpeak.Location = new System.Drawing.Point(399, 257);
            this.cbtn_answerSpeak.Name = "cbtn_answerSpeak";
            this.cbtn_answerSpeak.Size = new System.Drawing.Size(23, 18);
            this.cbtn_answerSpeak.TabIndex = 9;
            this.cbtn_answerSpeak.Text = "checkButton1";
            this.cbtn_answerSpeak.Click += new System.EventHandler(this.cbtn_answerSpeak_Click);
            // 
            // cbtn_questSpeak
            // 
            this.cbtn_questSpeak.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.sound;
            this.cbtn_questSpeak.Location = new System.Drawing.Point(399, 113);
            this.cbtn_questSpeak.Name = "cbtn_questSpeak";
            this.cbtn_questSpeak.Size = new System.Drawing.Size(23, 18);
            this.cbtn_questSpeak.TabIndex = 8;
            this.cbtn_questSpeak.Text = "checkButton1";
            this.cbtn_questSpeak.Click += new System.EventHandler(this.cbtn_questSpeak_Click);
            // 
            // cbtnReset
            // 
            this.cbtnReset.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.file;
            this.cbtnReset.Location = new System.Drawing.Point(13, 136);
            this.cbtnReset.Name = "cbtnReset";
            this.cbtnReset.Size = new System.Drawing.Size(30, 23);
            this.cbtnReset.TabIndex = 5;
            this.cbtnReset.Text = "checkButton2";
            this.cbtnReset.Click += new System.EventHandler(this.cbtnReset_Click);
            // 
            // cbtnSwitch
            // 
            this.cbtnSwitch.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.left_and_right_arrows;
            this.cbtnSwitch.Location = new System.Drawing.Point(197, 136);
            this.cbtnSwitch.Name = "cbtnSwitch";
            this.cbtnSwitch.Size = new System.Drawing.Size(30, 23);
            this.cbtnSwitch.TabIndex = 3;
            this.cbtnSwitch.Text = "checkButton1";
            this.cbtnSwitch.Click += new System.EventHandler(this.cbtnSwitch_Click);
            // 
            // cbtnCamera
            // 
            this.cbtnCamera.ContextMenuStrip = this.contextMenuStrip_Camera;
            this.cbtnCamera.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.camera;
            this.cbtnCamera.Location = new System.Drawing.Point(338, 113);
            this.cbtnCamera.Name = "cbtnCamera";
            this.cbtnCamera.Size = new System.Drawing.Size(23, 18);
            this.cbtnCamera.TabIndex = 0;
            this.cbtnCamera.Text = "checkButton1";
            this.cbtnCamera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbtnCamera_MouseDown);
            // 
            // KdgTranslateApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 285);
            this.Controls.Add(this.cbtnVoiceInput);
            this.Controls.Add(this.cbtn_answerSpeak);
            this.Controls.Add(this.cbtn_questSpeak);
            this.Controls.Add(this.rbtn_AutoTranslate);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.cbtnReset);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.cbtnSwitch);
            this.Controls.Add(this.cbb_answer);
            this.Controls.Add(this.cbb_quest);
            this.Controls.Add(this.cbtnCamera);
            this.Controls.Add(this.tb_quest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::KdgTranslationApp.Properties.Resources._8511303732_g065;
            this.MaximizeBox = false;
            this.Name = "KdgTranslateApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KdgTranslate";
            this.Load += new System.EventHandler(this.KdgTranslateApp_Load);
            this.contextMenuStrip_Camera.ResumeLayout(false);
            this.contextMenuStrip_notifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton cbtnCamera;
        private System.Windows.Forms.TextBox tb_quest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Camera;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbb_quest;
        private System.Windows.Forms.ComboBox cbb_answer;
        private DevExpress.XtraEditors.CheckButton cbtnSwitch;
        private System.Windows.Forms.TextBox tb_answer;
        private DevExpress.XtraEditors.CheckButton cbtnReset;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.RadioButton rbtn_AutoTranslate;
        private DevExpress.XtraEditors.CheckButton cbtn_questSpeak;
        private DevExpress.XtraEditors.CheckButton cbtn_answerSpeak;
        private DevExpress.XtraEditors.CheckButton cbtnVoiceInput;
        private System.Windows.Forms.NotifyIcon notifyIcon_Taskbar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem kdgTranslateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textRecognitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem1;
    }
}

