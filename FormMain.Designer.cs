
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
            this.formMainResult = new System.Windows.Forms.Label();
            this.formMainRecognize = new System.Windows.Forms.Button();
            this.formMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.formMainMenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuStripFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuStripFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.formMainMenuStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuStripReference = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuStripReferenceAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.formMainStatusStripVersion = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.formMainPictureBox)).BeginInit();
            this.formMainMenuStrip.SuspendLayout();
            this.formMainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // formMainPictureBox
            // 
            this.formMainPictureBox.BackColor = System.Drawing.Color.White;
            this.formMainPictureBox.Location = new System.Drawing.Point(0, 31);
            this.formMainPictureBox.Name = "formMainPictureBox";
            this.formMainPictureBox.Size = new System.Drawing.Size(782, 340);
            this.formMainPictureBox.TabIndex = 0;
            this.formMainPictureBox.TabStop = false;
            this.formMainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMainPictureBox_MouseDown);
            this.formMainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMainPictureBox_MouseMove);
            this.formMainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formMainPictureBox_MouseUp);
            // 
            // formMainResult
            // 
            this.formMainResult.AutoSize = true;
            this.formMainResult.Location = new System.Drawing.Point(164, 387);
            this.formMainResult.Name = "formMainResult";
            this.formMainResult.Size = new System.Drawing.Size(0, 17);
            this.formMainResult.TabIndex = 1;
            // 
            // formMainRecognize
            // 
            this.formMainRecognize.Location = new System.Drawing.Point(0, 377);
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
            this.formMainMenuStripFileOpen,
            this.formMainMenuStripFileSeparator,
            this.formMainMenuStripFileExit});
            this.formMainMenuStripFile.Name = "formMainMenuStripFile";
            this.formMainMenuStripFile.Size = new System.Drawing.Size(59, 24);
            this.formMainMenuStripFile.Text = "Файл";
            // 
            // formMainMenuStripFileOpen
            // 
            this.formMainMenuStripFileOpen.Name = "formMainMenuStripFileOpen";
            this.formMainMenuStripFileOpen.Size = new System.Drawing.Size(150, 26);
            this.formMainMenuStripFileOpen.Text = "Открыть";
            this.formMainMenuStripFileOpen.Click += new System.EventHandler(this.formMainMenuStripFileOpen_Click);
            // 
            // formMainMenuStripFileSeparator
            // 
            this.formMainMenuStripFileSeparator.Name = "formMainMenuStripFileSeparator";
            this.formMainMenuStripFileSeparator.Size = new System.Drawing.Size(147, 6);
            // 
            // formMainMenuStripFileExit
            // 
            this.formMainMenuStripFileExit.Name = "formMainMenuStripFileExit";
            this.formMainMenuStripFileExit.Size = new System.Drawing.Size(150, 26);
            this.formMainMenuStripFileExit.Text = "Выйти";
            this.formMainMenuStripFileExit.Click += new System.EventHandler(this.formMainMenuStripFileExit_Click);
            // 
            // formMainMenuStripReference
            // 
            this.formMainMenuStripReference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainMenuStripReferenceAbout});
            this.formMainMenuStripReference.Name = "formMainMenuStripReference";
            this.formMainMenuStripReference.Size = new System.Drawing.Size(81, 24);
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
            this.formMainStatusStripVersion.Size = new System.Drawing.Size(767, 24);
            this.formMainStatusStripVersion.Spring = true;
            this.formMainStatusStripVersion.Text = "Версия: 1.0.0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.formMainStatusStrip);
            this.Controls.Add(this.formMainRecognize);
            this.Controls.Add(this.formMainResult);
            this.Controls.Add(this.formMainPictureBox);
            this.Controls.Add(this.formMainMenuStrip);
            this.MainMenuStrip = this.formMainMenuStrip;
            this.Name = "FormMain";
            this.Text = "NeuroVision";
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
        private System.Windows.Forms.Label formMainResult;
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
    }
}

