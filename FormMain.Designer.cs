
namespace NeuroVision {
    partial class FormMain {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.formMainPictureBox = new System.Windows.Forms.PictureBox();
            this.formMainRecognize = new System.Windows.Forms.Button();
            this.formMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.formMainMenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuStripFileDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuStripFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuStripFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.formMainMenuStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuStripReference = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuStripReferenceAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.formMainStatusStripVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.formMainResult = new System.Windows.Forms.RichTextBox();
            this.formMainCopy = new System.Windows.Forms.Button();
            this.formMainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formMainPictureBox)).BeginInit();
            this.formMainMenuStrip.SuspendLayout();
            this.formMainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // formMainPictureBox
            // 
            this.formMainPictureBox.BackColor = System.Drawing.Color.White;
            this.formMainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formMainPictureBox.Location = new System.Drawing.Point(12, 45);
            this.formMainPictureBox.Name = "formMainPictureBox";
            this.formMainPictureBox.Size = new System.Drawing.Size(559, 358);
            this.formMainPictureBox.TabIndex = 0;
            this.formMainPictureBox.TabStop = false;
            this.formMainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMainPictureBox_MouseDown);
            this.formMainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMainPictureBox_MouseMove);
            this.formMainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formMainPictureBox_MouseUp);
            // 
            // formMainRecognize
            // 
            this.formMainRecognize.Location = new System.Drawing.Point(587, 33);
            this.formMainRecognize.Name = "formMainRecognize";
            this.formMainRecognize.Size = new System.Drawing.Size(141, 37);
            this.formMainRecognize.TabIndex = 2;
            this.formMainRecognize.Text = "Распознать";
            this.formMainRecognize.UseVisualStyleBackColor = true;
            this.formMainRecognize.Click += new System.EventHandler(this.formMainRecognize_Click);
            // 
            // formMainMenuStrip
            // 
            this.formMainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.formMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainMenuStripFile,
            this.formMainMenuStripReference});
            this.formMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.formMainMenuStrip.Name = "formMainMenuStrip";
            this.formMainMenuStrip.Size = new System.Drawing.Size(782, 28);
            this.formMainMenuStrip.TabIndex = 3;
            this.formMainMenuStrip.Text = "menuStrip1";
            // 
            // formMainMenuStripFile
            // 
            this.formMainMenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainMenuStripFileDraw,
            this.formMainMenuStripFileOpen,
            this.formMainMenuStripFileSeparator,
            this.formMainMenuStripFileExit});
            this.formMainMenuStripFile.Name = "formMainMenuStripFile";
            this.formMainMenuStripFile.Size = new System.Drawing.Size(59, 26);
            this.formMainMenuStripFile.Text = "Файл";
            // 
            // formMainMenuStripFileDraw
            // 
            this.formMainMenuStripFileDraw.Name = "formMainMenuStripFileDraw";
            this.formMainMenuStripFileDraw.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.formMainMenuStripFileDraw.Size = new System.Drawing.Size(218, 26);
            this.formMainMenuStripFileDraw.Text = "Рисовать";
            this.formMainMenuStripFileDraw.Click += new System.EventHandler(this.formMainMenuStripFileDraw_Click);
            // 
            // formMainMenuStripFileOpen
            // 
            this.formMainMenuStripFileOpen.Name = "formMainMenuStripFileOpen";
            this.formMainMenuStripFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.formMainMenuStripFileOpen.Size = new System.Drawing.Size(218, 26);
            this.formMainMenuStripFileOpen.Text = "Открыть";
            this.formMainMenuStripFileOpen.Click += new System.EventHandler(this.formMainMenuStripFileOpen_Click);
            // 
            // formMainMenuStripFileSeparator
            // 
            this.formMainMenuStripFileSeparator.Name = "formMainMenuStripFileSeparator";
            this.formMainMenuStripFileSeparator.Size = new System.Drawing.Size(215, 6);
            // 
            // formMainMenuStripFileExit
            // 
            this.formMainMenuStripFileExit.Name = "formMainMenuStripFileExit";
            this.formMainMenuStripFileExit.Size = new System.Drawing.Size(218, 26);
            this.formMainMenuStripFileExit.Text = "Выйти";
            this.formMainMenuStripFileExit.Click += new System.EventHandler(this.formMainMenuStripFileExit_Click);
            // 
            // formMainMenuStripReference
            // 
            this.formMainMenuStripReference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainMenuStripReferenceAbout});
            this.formMainMenuStripReference.Name = "formMainMenuStripReference";
            this.formMainMenuStripReference.Size = new System.Drawing.Size(81, 26);
            this.formMainMenuStripReference.Text = "Справка";
            // 
            // formMainMenuStripReferenceAbout
            // 
            this.formMainMenuStripReferenceAbout.Name = "formMainMenuStripReferenceAbout";
            this.formMainMenuStripReferenceAbout.Size = new System.Drawing.Size(187, 26);
            this.formMainMenuStripReferenceAbout.Text = "О программе";
            this.formMainMenuStripReferenceAbout.Click += new System.EventHandler(this.formMainMenuStripReferenceAbout_Click);
            // 
            // formMainStatusStrip
            // 
            this.formMainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.formMainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainStatusStripVersion});
            this.formMainStatusStrip.Location = new System.Drawing.Point(0, 423);
            this.formMainStatusStrip.Name = "formMainStatusStrip";
            this.formMainStatusStrip.Size = new System.Drawing.Size(782, 30);
            this.formMainStatusStrip.SizingGrip = false;
            this.formMainStatusStrip.TabIndex = 4;
            // 
            // formMainStatusStripVersion
            // 
            this.formMainStatusStripVersion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.formMainStatusStripVersion.Name = "formMainStatusStripVersion";
            this.formMainStatusStripVersion.Size = new System.Drawing.Size(728, 24);
            this.formMainStatusStripVersion.Spring = true;
            this.formMainStatusStripVersion.Text = "Версия: 1.1.0";
            // 
            // formMainResult
            // 
            this.formMainResult.BackColor = System.Drawing.Color.White;
            this.formMainResult.Location = new System.Drawing.Point(587, 163);
            this.formMainResult.Name = "formMainResult";
            this.formMainResult.ReadOnly = true;
            this.formMainResult.Size = new System.Drawing.Size(168, 240);
            this.formMainResult.TabIndex = 5;
            this.formMainResult.Text = "";
            // 
            // formMainCopy
            // 
            this.formMainCopy.Location = new System.Drawing.Point(587, 76);
            this.formMainCopy.Name = "formMainCopy";
            this.formMainCopy.Size = new System.Drawing.Size(141, 43);
            this.formMainCopy.TabIndex = 6;
            this.formMainCopy.Text = "Скопировать";
            this.formMainCopy.UseVisualStyleBackColor = true;
            this.formMainCopy.Click += new System.EventHandler(this.formMainCopy_Click);
            // 
            // formMainLabel
            // 
            this.formMainLabel.AutoSize = true;
            this.formMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formMainLabel.Location = new System.Drawing.Point(582, 131);
            this.formMainLabel.Name = "formMainLabel";
            this.formMainLabel.Size = new System.Drawing.Size(254, 29);
            this.formMainLabel.TabIndex = 7;
            this.formMainLabel.Text = "Распознанный текст";
            this.formMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.formMainLabel);
            this.Controls.Add(this.formMainCopy);
            this.Controls.Add(this.formMainResult);
            this.Controls.Add(this.formMainStatusStrip);
            this.Controls.Add(this.formMainRecognize);
            this.Controls.Add(this.formMainPictureBox);
            this.Controls.Add(this.formMainMenuStrip);
            this.MainMenuStrip = this.formMainMenuStrip;
            this.Name = "FormMain";
            this.Text = "NeuroVision";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.formMainPictureBox)).EndInit();
            this.formMainMenuStrip.ResumeLayout(false);
            this.formMainMenuStrip.PerformLayout();
            this.formMainStatusStrip.ResumeLayout(false);
            this.formMainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox formMainPictureBox;
        private System.Windows.Forms.Button formMainRecognize;
        private System.Windows.Forms.MenuStrip formMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuStripFileOpen;
        private System.Windows.Forms.ToolStripSeparator formMainMenuStripFileSeparator;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuStripFileExit;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuStripReference;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuStripReferenceAbout;
        private System.Windows.Forms.StatusStrip formMainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel formMainStatusStripVersion;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuStripFileDraw;
        private System.Windows.Forms.RichTextBox formMainResult;
        private System.Windows.Forms.Button formMainCopy;
        private System.Windows.Forms.Label formMainLabel;
    }
}

