namespace NeuralMarkers
{
    partial class NeuralMarkers
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuralMarkers));
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseDirectoryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoFiles = new System.Windows.Forms.Label();
            this.resizePhotoButton = new System.Windows.Forms.Button();
            this.completedFilesInfo = new System.Windows.Forms.Label();
            this.button_LoadForm_2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseDirectoryButton,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // chooseDirectoryButton
            // 
            this.chooseDirectoryButton.Name = "chooseDirectoryButton";
            this.chooseDirectoryButton.Size = new System.Drawing.Size(209, 22);
            this.chooseDirectoryButton.Text = "Выбрать рабочую папку";
            this.chooseDirectoryButton.Click += new System.EventHandler(this.chooseDirectoryButton_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItem1.Text = "Случайные имена";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // infoFiles
            // 
            this.infoFiles.AutoSize = true;
            this.infoFiles.Location = new System.Drawing.Point(12, 57);
            this.infoFiles.Name = "infoFiles";
            this.infoFiles.Size = new System.Drawing.Size(90, 13);
            this.infoFiles.TabIndex = 2;
            this.infoFiles.Text = "Всего файлов: 0";
            // 
            // resizePhotoButton
            // 
            this.resizePhotoButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.resizePhotoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resizePhotoButton.Enabled = false;
            this.resizePhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizePhotoButton.Location = new System.Drawing.Point(15, 102);
            this.resizePhotoButton.Name = "resizePhotoButton";
            this.resizePhotoButton.Size = new System.Drawing.Size(236, 46);
            this.resizePhotoButton.TabIndex = 6;
            this.resizePhotoButton.Text = "Начать процес";
            this.resizePhotoButton.UseVisualStyleBackColor = false;
            this.resizePhotoButton.Click += new System.EventHandler(this.resizePhotoButton_Click);
            // 
            // completedFilesInfo
            // 
            this.completedFilesInfo.AutoSize = true;
            this.completedFilesInfo.Location = new System.Drawing.Point(12, 75);
            this.completedFilesInfo.Name = "completedFilesInfo";
            this.completedFilesInfo.Size = new System.Drawing.Size(121, 13);
            this.completedFilesInfo.TabIndex = 7;
            this.completedFilesInfo.Text = "Обработано файлов: 0";
            // 
            // button_LoadForm_2
            // 
            this.button_LoadForm_2.Location = new System.Drawing.Point(157, 202);
            this.button_LoadForm_2.Name = "button_LoadForm_2";
            this.button_LoadForm_2.Size = new System.Drawing.Size(95, 43);
            this.button_LoadForm_2.TabIndex = 8;
            this.button_LoadForm_2.Text = "Проверить файлы :)";
            this.button_LoadForm_2.UseVisualStyleBackColor = true;
            this.button_LoadForm_2.Click += new System.EventHandler(this.button_LoadForm_2_Click);
            // 
            // NeuralMarkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 257);
            this.Controls.Add(this.button_LoadForm_2);
            this.Controls.Add(this.completedFilesInfo);
            this.Controls.Add(this.resizePhotoButton);
            this.Controls.Add(this.infoFiles);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "NeuralMarkers";
            this.Text = "NeuralPrepareDataset";
            this.Load += new System.EventHandler(this.NeuralMarkers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseDirectoryButton;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label infoFiles;
        private System.Windows.Forms.Button resizePhotoButton;
        private System.Windows.Forms.Label completedFilesInfo;
        private System.Windows.Forms.Button button_LoadForm_2;
    }
}

