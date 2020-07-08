namespace WindowsFormsAppTest
{
    partial class importForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importForm));
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileText = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.xzButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileLabel
            // 
            this.fileLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileLabel.Location = new System.Drawing.Point(0, 0);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(105, 22);
            this.fileLabel.TabIndex = 0;
            this.fileLabel.Text = "请选择文件路径";
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileText
            // 
            this.fileText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileText.Location = new System.Drawing.Point(105, 0);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(479, 21);
            this.fileText.TabIndex = 1;
            this.fileText.Text = "E:/1.txt";
            this.fileText.TextChanged += new System.EventHandler(this.fileText_TextChanged);
            // 
            // importButton
            // 
            this.importButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.importButton.Location = new System.Drawing.Point(534, 0);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(50, 22);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "导入";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // xzButton
            // 
            this.xzButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.xzButton.Location = new System.Drawing.Point(484, 0);
            this.xzButton.Name = "xzButton";
            this.xzButton.Size = new System.Drawing.Size(50, 22);
            this.xzButton.TabIndex = 3;
            this.xzButton.Text = "选择";
            this.xzButton.UseVisualStyleBackColor = true;
            this.xzButton.Click += new System.EventHandler(this.xzButton_Click);
            // 
            // importForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 22);
            this.Controls.Add(this.xzButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.fileLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 60);
            this.MinimumSize = new System.Drawing.Size(600, 60);
            this.Name = "importForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button xzButton;
    }
}