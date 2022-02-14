namespace NeuralMarkers
{
    partial class Form2
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
            this.button_open_path = new System.Windows.Forms.Button();
            this.button_select_path = new System.Windows.Forms.Button();
            this.check_copy_file = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resizePhotoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_open_path
            // 
            this.button_open_path.Location = new System.Drawing.Point(28, 67);
            this.button_open_path.Name = "button_open_path";
            this.button_open_path.Size = new System.Drawing.Size(173, 23);
            this.button_open_path.TabIndex = 0;
            this.button_open_path.Text = "Выбрать папку с данными";
            this.button_open_path.UseVisualStyleBackColor = true;
            this.button_open_path.Click += new System.EventHandler(this.button_open_path_Click);
            // 
            // button_select_path
            // 
            this.button_select_path.Location = new System.Drawing.Point(28, 38);
            this.button_select_path.Name = "button_select_path";
            this.button_select_path.Size = new System.Drawing.Size(173, 23);
            this.button_select_path.TabIndex = 1;
            this.button_select_path.Text = "Выбрать папку сохранения";
            this.button_select_path.UseVisualStyleBackColor = true;
            this.button_select_path.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_copy_file
            // 
            this.check_copy_file.AutoSize = true;
            this.check_copy_file.Location = new System.Drawing.Point(209, 42);
            this.check_copy_file.Name = "check_copy_file";
            this.check_copy_file.Size = new System.Drawing.Size(123, 17);
            this.check_copy_file.TabIndex = 2;
            this.check_copy_file.Text = "Копировать файлы";
            this.check_copy_file.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "saf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "saf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "saf";
            // 
            // resizePhotoButton
            // 
            this.resizePhotoButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.resizePhotoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resizePhotoButton.Enabled = false;
            this.resizePhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizePhotoButton.Location = new System.Drawing.Point(28, 96);
            this.resizePhotoButton.Name = "resizePhotoButton";
            this.resizePhotoButton.Size = new System.Drawing.Size(173, 46);
            this.resizePhotoButton.TabIndex = 7;
            this.resizePhotoButton.Text = "Начать процесс";
            this.resizePhotoButton.UseVisualStyleBackColor = false;
            this.resizePhotoButton.Click += new System.EventHandler(this.resizePhotoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "saf";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resizePhotoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_copy_file);
            this.Controls.Add(this.button_select_path);
            this.Controls.Add(this.button_open_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open_path;
        private System.Windows.Forms.Button button_select_path;
        private System.Windows.Forms.CheckBox check_copy_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resizePhotoButton;
        private System.Windows.Forms.Label label4;
    }
}