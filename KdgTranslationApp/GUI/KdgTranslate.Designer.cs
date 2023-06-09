﻿namespace KdgTranslationApp
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tb_answer = new DevExpress.XtraRichEdit.RichEditControl();
            this.cbtn_autoCopy = new System.Windows.Forms.CheckBox();
            this.btnTranslate = new DevExpress.XtraEditors.SimpleButton();
            this.cbtn_autoTranslate = new System.Windows.Forms.CheckBox();
            this.cbtn_removeSpace = new System.Windows.Forms.CheckBox();
            this.cbtnVoiceInput = new DevExpress.XtraEditors.CheckButton();
            this.contextMenuStrip_mic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtn_answerSpeak = new DevExpress.XtraEditors.CheckButton();
            this.cbtn_questSpeak = new DevExpress.XtraEditors.CheckButton();
            this.cbtnReset = new DevExpress.XtraEditors.CheckButton();
            this.cbtnSwitch = new DevExpress.XtraEditors.CheckButton();
            this.cbb_answer = new System.Windows.Forms.ComboBox();
            this.cbb_quest = new System.Windows.Forms.ComboBox();
            this.cbtnCamera = new DevExpress.XtraEditors.CheckButton();
            this.contextMenuStrip_CameraIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_quest = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_ChosseSpeaker = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tb_TR_VietnameseKey = new System.Windows.Forms.TextBox();
            this.tb_TR_EnglishKey = new System.Windows.Forms.TextBox();
            this.tb_ShowFormKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip_notiIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kdgTranslateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textRecognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon_Taskbar = new System.Windows.Forms.NotifyIcon(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.tb_zaloApiKey = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.contextMenuStrip_mic.SuspendLayout();
            this.contextMenuStrip_CameraIcon.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.contextMenuStrip_notiIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(562, 347);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cbtn_autoCopy);
            this.xtraTabPage1.Controls.Add(this.btnTranslate);
            this.xtraTabPage1.Controls.Add(this.cbtn_autoTranslate);
            this.xtraTabPage1.Controls.Add(this.cbtn_removeSpace);
            this.xtraTabPage1.Controls.Add(this.cbtnVoiceInput);
            this.xtraTabPage1.Controls.Add(this.cbtn_answerSpeak);
            this.xtraTabPage1.Controls.Add(this.cbtn_questSpeak);
            this.xtraTabPage1.Controls.Add(this.cbtnReset);
            this.xtraTabPage1.Controls.Add(this.cbtnSwitch);
            this.xtraTabPage1.Controls.Add(this.cbb_answer);
            this.xtraTabPage1.Controls.Add(this.cbb_quest);
            this.xtraTabPage1.Controls.Add(this.cbtnCamera);
            this.xtraTabPage1.Controls.Add(this.tb_quest);
            this.xtraTabPage1.Controls.Add(this.tb_answer);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(560, 316);
            this.xtraTabPage1.Text = "Dịch";
            // 
            // tb_answer
            // 
            this.tb_answer.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.tb_answer.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.tb_answer.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.tb_answer.Location = new System.Drawing.Point(11, 182);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(538, 126);
            this.tb_answer.TabIndex = 32;
            // 
            // cbtn_autoCopy
            // 
            this.cbtn_autoCopy.AutoSize = true;
            this.cbtn_autoCopy.Location = new System.Drawing.Point(256, 3);
            this.cbtn_autoCopy.Name = "cbtn_autoCopy";
            this.cbtn_autoCopy.Size = new System.Drawing.Size(74, 17);
            this.cbtn_autoCopy.TabIndex = 30;
            this.cbtn_autoCopy.Text = "AutoCopy";
            this.cbtn_autoCopy.UseVisualStyleBackColor = true;
            this.cbtn_autoCopy.CheckStateChanged += new System.EventHandler(this.cbtn_autoCopy_CheckStateChanged);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(473, 153);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(77, 23);
            this.btnTranslate.TabIndex = 29;
            this.btnTranslate.Text = "Dịch";
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // cbtn_autoTranslate
            // 
            this.cbtn_autoTranslate.AutoSize = true;
            this.cbtn_autoTranslate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtn_autoTranslate.Location = new System.Drawing.Point(459, 3);
            this.cbtn_autoTranslate.Name = "cbtn_autoTranslate";
            this.cbtn_autoTranslate.Size = new System.Drawing.Size(87, 17);
            this.cbtn_autoTranslate.TabIndex = 24;
            this.cbtn_autoTranslate.Text = "Dịch tự động";
            this.cbtn_autoTranslate.UseVisualStyleBackColor = true;
            this.cbtn_autoTranslate.CheckedChanged += new System.EventHandler(this.cbtn_autoTranslate_CheckedChanged);
            // 
            // cbtn_removeSpace
            // 
            this.cbtn_removeSpace.AutoSize = true;
            this.cbtn_removeSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtn_removeSpace.Location = new System.Drawing.Point(339, 3);
            this.cbtn_removeSpace.Name = "cbtn_removeSpace";
            this.cbtn_removeSpace.Size = new System.Drawing.Size(111, 17);
            this.cbtn_removeSpace.TabIndex = 23;
            this.cbtn_removeSpace.Text = "Xóa khoảng trắng";
            this.cbtn_removeSpace.UseVisualStyleBackColor = true;
            this.cbtn_removeSpace.CheckStateChanged += new System.EventHandler(this.cbtn_removeSpace_CheckStateChanged);
            // 
            // cbtnVoiceInput
            // 
            this.cbtnVoiceInput.ContextMenuStrip = this.contextMenuStrip_mic;
            this.cbtnVoiceInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnVoiceInput.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.google_voice;
            this.cbtnVoiceInput.Location = new System.Drawing.Point(480, 127);
            this.cbtnVoiceInput.Name = "cbtnVoiceInput";
            this.cbtnVoiceInput.Size = new System.Drawing.Size(23, 18);
            this.cbtnVoiceInput.TabIndex = 22;
            this.cbtnVoiceInput.Text = "checkButton1";
            this.cbtnVoiceInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbtnVoiceInput_MouseDown);
            // 
            // contextMenuStrip_mic
            // 
            this.contextMenuStrip_mic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startRecordToolStripMenuItem,
            this.stopRecordToolStripMenuItem});
            this.contextMenuStrip_mic.Name = "contextMenuStrip_mic";
            this.contextMenuStrip_mic.Size = new System.Drawing.Size(139, 48);
            // 
            // startRecordToolStripMenuItem
            // 
            this.startRecordToolStripMenuItem.Name = "startRecordToolStripMenuItem";
            this.startRecordToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.startRecordToolStripMenuItem.Text = "Start Record";
            this.startRecordToolStripMenuItem.Click += new System.EventHandler(this.startRecordToolStripMenuItem_Click);
            // 
            // stopRecordToolStripMenuItem
            // 
            this.stopRecordToolStripMenuItem.Name = "stopRecordToolStripMenuItem";
            this.stopRecordToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.stopRecordToolStripMenuItem.Text = "Stop Record";
            this.stopRecordToolStripMenuItem.Click += new System.EventHandler(this.stopRecordToolStripMenuItem_Click);
            // 
            // cbtn_answerSpeak
            // 
            this.cbtn_answerSpeak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtn_answerSpeak.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.sound;
            this.cbtn_answerSpeak.Location = new System.Drawing.Point(505, 288);
            this.cbtn_answerSpeak.Name = "cbtn_answerSpeak";
            this.cbtn_answerSpeak.Size = new System.Drawing.Size(23, 18);
            this.cbtn_answerSpeak.TabIndex = 21;
            this.cbtn_answerSpeak.Text = "checkButton1";
            this.cbtn_answerSpeak.Click += new System.EventHandler(this.cbtn_answerSpeak_Click_1);
            // 
            // cbtn_questSpeak
            // 
            this.cbtn_questSpeak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtn_questSpeak.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.sound;
            this.cbtn_questSpeak.Location = new System.Drawing.Point(505, 127);
            this.cbtn_questSpeak.Name = "cbtn_questSpeak";
            this.cbtn_questSpeak.Size = new System.Drawing.Size(23, 18);
            this.cbtn_questSpeak.TabIndex = 20;
            this.cbtn_questSpeak.Text = "checkButton1";
            this.cbtn_questSpeak.Click += new System.EventHandler(this.cbtn_questSpeak_Click_1);
            // 
            // cbtnReset
            // 
            this.cbtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnReset.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.file;
            this.cbtnReset.Location = new System.Drawing.Point(11, 152);
            this.cbtnReset.Name = "cbtnReset";
            this.cbtnReset.Size = new System.Drawing.Size(30, 23);
            this.cbtnReset.TabIndex = 17;
            this.cbtnReset.Text = "checkButton2";
            this.cbtnReset.Click += new System.EventHandler(this.cbtnReset_Click_1);
            // 
            // cbtnSwitch
            // 
            this.cbtnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnSwitch.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.left_and_right_arrows;
            this.cbtnSwitch.Location = new System.Drawing.Point(241, 149);
            this.cbtnSwitch.Name = "cbtnSwitch";
            this.cbtnSwitch.Size = new System.Drawing.Size(32, 30);
            this.cbtnSwitch.TabIndex = 15;
            this.cbtnSwitch.Text = "checkButton1";
            this.cbtnSwitch.Click += new System.EventHandler(this.cbtnSwitch_Click_1);
            // 
            // cbb_answer
            // 
            this.cbb_answer.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.cbb_answer.Location = new System.Drawing.Point(280, 154);
            this.cbb_answer.Name = "cbb_answer";
            this.cbb_answer.Size = new System.Drawing.Size(184, 21);
            this.cbb_answer.TabIndex = 13;
            this.cbb_answer.SelectedIndexChanged += new System.EventHandler(this.cbb_answer_SelectedIndexChanged_1);
            // 
            // cbb_quest
            // 
            this.cbb_quest.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.cbb_quest.Location = new System.Drawing.Point(47, 153);
            this.cbb_quest.Name = "cbb_quest";
            this.cbb_quest.Size = new System.Drawing.Size(184, 21);
            this.cbb_quest.TabIndex = 14;
            this.cbb_quest.SelectedIndexChanged += new System.EventHandler(this.cbb_quest_SelectedIndexChanged_1);
            // 
            // cbtnCamera
            // 
            this.cbtnCamera.ContextMenuStrip = this.contextMenuStrip_CameraIcon;
            this.cbtnCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnCamera.ImageOptions.Image = global::KdgTranslationApp.Properties.Resources.camera;
            this.cbtnCamera.Location = new System.Drawing.Point(455, 127);
            this.cbtnCamera.Name = "cbtnCamera";
            this.cbtnCamera.Size = new System.Drawing.Size(23, 18);
            this.cbtnCamera.TabIndex = 11;
            this.cbtnCamera.Text = "checkButton1";
            this.cbtnCamera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbtnCamera_MouseDown_1);
            // 
            // contextMenuStrip_CameraIcon
            // 
            this.contextMenuStrip_CameraIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.vietnameseToolStripMenuItem});
            this.contextMenuStrip_CameraIcon.Name = "contextMenuStrip_CameraIcon";
            this.contextMenuStrip_CameraIcon.Size = new System.Drawing.Size(136, 48);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click_1);
            // 
            // vietnameseToolStripMenuItem
            // 
            this.vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            this.vietnameseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.vietnameseToolStripMenuItem.Text = "Vietnamese";
            this.vietnameseToolStripMenuItem.Click += new System.EventHandler(this.vietnameseToolStripMenuItem_Click_1);
            // 
            // tb_quest
            // 
            this.tb_quest.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.tb_quest.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.tb_quest.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.tb_quest.Location = new System.Drawing.Point(11, 22);
            this.tb_quest.Name = "tb_quest";
            this.tb_quest.Size = new System.Drawing.Size(538, 126);
            this.tb_quest.TabIndex = 31;
            this.tb_quest.TextChanged += new System.EventHandler(this.tb_quest_TextChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.linkLabel1);
            this.xtraTabPage2.Controls.Add(this.tb_zaloApiKey);
            this.xtraTabPage2.Controls.Add(this.label10);
            this.xtraTabPage2.Controls.Add(this.label9);
            this.xtraTabPage2.Controls.Add(this.cbb_ChosseSpeaker);
            this.xtraTabPage2.Controls.Add(this.label8);
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Controls.Add(this.label7);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.label4);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.btnSave);
            this.xtraTabPage2.Controls.Add(this.tb_TR_VietnameseKey);
            this.xtraTabPage2.Controls.Add(this.tb_TR_EnglishKey);
            this.xtraTabPage2.Controls.Add(this.tb_ShowFormKey);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(560, 316);
            this.xtraTabPage2.Text = "Tùy Chỉnh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Giọng Đọc";
            // 
            // cbb_ChosseSpeaker
            // 
            this.cbb_ChosseSpeaker.FormattingEnabled = true;
            this.cbb_ChosseSpeaker.Items.AddRange(new object[] {
            "Nữ Miền Nam",
            "Nữ Miền Bắc",
            "Nam Miền Nam",
            "Nam Miền Bắc"});
            this.cbb_ChosseSpeaker.Location = new System.Drawing.Point(262, 245);
            this.cbb_ChosseSpeaker.Name = "cbb_ChosseSpeaker";
            this.cbb_ChosseSpeaker.Size = new System.Drawing.Size(110, 21);
            this.cbb_ChosseSpeaker.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Phím Tắt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ALT +";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vietnamese:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "English:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ALT +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ALT +";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(439, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tb_TR_VietnameseKey
            // 
            this.tb_TR_VietnameseKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_TR_VietnameseKey.Location = new System.Drawing.Point(272, 170);
            this.tb_TR_VietnameseKey.MaxLength = 1;
            this.tb_TR_VietnameseKey.Name = "tb_TR_VietnameseKey";
            this.tb_TR_VietnameseKey.Size = new System.Drawing.Size(100, 21);
            this.tb_TR_VietnameseKey.TabIndex = 1;
            // 
            // tb_TR_EnglishKey
            // 
            this.tb_TR_EnglishKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_TR_EnglishKey.Location = new System.Drawing.Point(272, 143);
            this.tb_TR_EnglishKey.MaxLength = 1;
            this.tb_TR_EnglishKey.Name = "tb_TR_EnglishKey";
            this.tb_TR_EnglishKey.Size = new System.Drawing.Size(100, 21);
            this.tb_TR_EnglishKey.TabIndex = 1;
            // 
            // tb_ShowFormKey
            // 
            this.tb_ShowFormKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ShowFormKey.Location = new System.Drawing.Point(272, 79);
            this.tb_ShowFormKey.MaxLength = 1;
            this.tb_ShowFormKey.Name = "tb_ShowFormKey";
            this.tb_ShowFormKey.Size = new System.Drawing.Size(100, 21);
            this.tb_ShowFormKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quét Màn Hình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ẩn/Hiện Form";
            // 
            // contextMenuStrip_notiIcon
            // 
            this.contextMenuStrip_notiIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kdgTranslateToolStripMenuItem,
            this.textRecognitionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip_notiIcon.Name = "contextMenuStrip_notiIcon";
            this.contextMenuStrip_notiIcon.Size = new System.Drawing.Size(160, 70);
            // 
            // kdgTranslateToolStripMenuItem
            // 
            this.kdgTranslateToolStripMenuItem.Name = "kdgTranslateToolStripMenuItem";
            this.kdgTranslateToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kdgTranslateToolStripMenuItem.Text = "KdgTranslate";
            this.kdgTranslateToolStripMenuItem.Click += new System.EventHandler(this.kdgTranslateToolStripMenuItem_Click_1);
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
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.englishToolStripMenuItem1_Click_1);
            // 
            // vietnameseToolStripMenuItem1
            // 
            this.vietnameseToolStripMenuItem1.Name = "vietnameseToolStripMenuItem1";
            this.vietnameseToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.vietnameseToolStripMenuItem1.Text = "Vietnamese";
            this.vietnameseToolStripMenuItem1.Click += new System.EventHandler(this.vietnameseToolStripMenuItem1_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // notifyIcon_Taskbar
            // 
            this.notifyIcon_Taskbar.ContextMenuStrip = this.contextMenuStrip_notiIcon;
            this.notifyIcon_Taskbar.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Taskbar.Icon")));
            this.notifyIcon_Taskbar.Text = "KdgTranslate";
            this.notifyIcon_Taskbar.Visible = true;
            this.notifyIcon_Taskbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_Taskbar_MouseClick_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(138, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Zalo API";
            // 
            // tb_zaloApiKey
            // 
            this.tb_zaloApiKey.Location = new System.Drawing.Point(204, 212);
            this.tb_zaloApiKey.Name = "tb_zaloApiKey";
            this.tb_zaloApiKey.Size = new System.Drawing.Size(211, 21);
            this.tb_zaloApiKey.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(421, 215);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Lấy API ở đây";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // KdgTranslateApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 347);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::KdgTranslationApp.Properties.Resources._8511303732_g065;
            this.MaximizeBox = false;
            this.Name = "KdgTranslateApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KdgTranslate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KdgTranslateApp_FormClosing);
            this.Load += new System.EventHandler(this.KdgTranslateApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.contextMenuStrip_mic.ResumeLayout(false);
            this.contextMenuStrip_CameraIcon.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.contextMenuStrip_notiIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.CheckButton cbtnVoiceInput;
        private DevExpress.XtraEditors.CheckButton cbtn_answerSpeak;
        private DevExpress.XtraEditors.CheckButton cbtn_questSpeak;
        private DevExpress.XtraEditors.CheckButton cbtnReset;
        private DevExpress.XtraEditors.CheckButton cbtnSwitch;
        private System.Windows.Forms.ComboBox cbb_answer;
        private System.Windows.Forms.ComboBox cbb_quest;
        private DevExpress.XtraEditors.CheckButton cbtnCamera;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_CameraIcon;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_notiIcon;
        private System.Windows.Forms.ToolStripMenuItem kdgTranslateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textRecognitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon_Taskbar;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tb_ShowFormKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TR_VietnameseKey;
        private System.Windows.Forms.TextBox tb_TR_EnglishKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbtn_removeSpace;
        private System.Windows.Forms.CheckBox cbtn_autoTranslate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_mic;
        private System.Windows.Forms.ToolStripMenuItem startRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRecordToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_ChosseSpeaker;
        private DevExpress.XtraEditors.SimpleButton btnTranslate;
        private System.Windows.Forms.CheckBox cbtn_autoCopy;
        private DevExpress.XtraRichEdit.RichEditControl tb_quest;
        private DevExpress.XtraRichEdit.RichEditControl tb_answer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tb_zaloApiKey;
        private System.Windows.Forms.Label label10;
    }
}

