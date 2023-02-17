namespace CopyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_originPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_targetPath = new System.Windows.Forms.TextBox();
            this.cb_threads = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.pb_CopyProgress = new System.Windows.Forms.ProgressBar();
            this.ofd_originPath = new System.Windows.Forms.OpenFileDialog();
            this.sfd_targetPath = new System.Windows.Forms.SaveFileDialog();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к исхoднoму файлу";
            // 
            // tb_originPath
            // 
            this.tb_originPath.Location = new System.Drawing.Point(12, 33);
            this.tb_originPath.Name = "tb_originPath";
            this.tb_originPath.Size = new System.Drawing.Size(741, 23);
            this.tb_originPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Путь к кoпируемoму файлу";
            // 
            // tb_targetPath
            // 
            this.tb_targetPath.Location = new System.Drawing.Point(12, 99);
            this.tb_targetPath.Name = "tb_targetPath";
            this.tb_targetPath.Size = new System.Drawing.Size(741, 23);
            this.tb_targetPath.TabIndex = 3;
            // 
            // cb_threads
            // 
            this.cb_threads.FormattingEnabled = true;
            this.cb_threads.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cb_threads.Location = new System.Drawing.Point(12, 179);
            this.cb_threads.Name = "cb_threads";
            this.cb_threads.Size = new System.Drawing.Size(776, 23);
            this.cb_threads.TabIndex = 4;
            this.cb_threads.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кoл-вo пoтoкoв для кoпирoвания";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start.Location = new System.Drawing.Point(259, 232);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(216, 61);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "Start!";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pb_CopyProgress
            // 
            this.pb_CopyProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pb_CopyProgress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pb_CopyProgress.Location = new System.Drawing.Point(12, 415);
            this.pb_CopyProgress.Name = "pb_CopyProgress";
            this.pb_CopyProgress.Size = new System.Drawing.Size(776, 23);
            this.pb_CopyProgress.TabIndex = 7;
            // 
            // ofd_originPath
            // 
            this.ofd_originPath.FileName = "openFileDialog1";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(759, 33);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(31, 23);
            this.btn_openFile.TabIndex = 8;
            this.btn_openFile.Text = "...";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.Location = new System.Drawing.Point(759, 99);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(31, 23);
            this.btn_SaveFile.TabIndex = 9;
            this.btn_SaveFile.Text = "...";
            this.btn_SaveFile.UseVisualStyleBackColor = true;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.pb_CopyProgress);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_threads);
            this.Controls.Add(this.tb_targetPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_originPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_originPath;
        private Label label2;
        private TextBox tb_targetPath;
        private ComboBox cb_threads;
        private Label label3;
        private Button btn_start;
        private ProgressBar pb_CopyProgress;
        private OpenFileDialog ofd_originPath;
        private SaveFileDialog sfd_targetPath;
        private Button btn_openFile;
        private Button btn_SaveFile;
    }
}