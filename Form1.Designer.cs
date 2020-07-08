using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.setMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.importMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.etMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // setMenu
            // 
            this.setMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importMenu,
            this.exportMenu,
            this.etMenu});
            this.setMenu.Name = "setMenu";
            resources.ApplyResources(this.setMenu, "setMenu");
            // 
            // importMenu
            // 
            this.importMenu.Name = "importMenu";
            resources.ApplyResources(this.importMenu, "importMenu");
            this.importMenu.Click += new System.EventHandler(this.importMenu_Click);
            // 
            // exportMenu
            // 
            this.exportMenu.Name = "exportMenu";
            resources.ApplyResources(this.exportMenu, "exportMenu");
            // 
            // etMenu
            // 
            this.etMenu.Name = "etMenu";
            resources.ApplyResources(this.etMenu, "etMenu");
            this.etMenu.Click += new System.EventHandler(this.etMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.Name = "editMenu";
            resources.ApplyResources(this.editMenu, "editMenu");
            // 
            // toolMenu
            // 
            this.toolMenu.Name = "toolMenu";
            resources.ApplyResources(this.toolMenu, "toolMenu");
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            resources.ApplyResources(this.helpMenu, "helpMenu");
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMenu,
            this.editMenu,
            this.toolMenu,
            this.helpMenu});
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Name = "mainMenu";
            // 
            // textArea
            // 
            resources.ApplyResources(this.textArea, "textArea");
            this.textArea.Name = "textArea";
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.mainMenu);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsAppTest.Properties.Settings.Default, "mainForm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "mainForm";
            this.Text = global::WindowsFormsAppTest.Properties.Settings.Default.mainForm;
            this.TransparencyKey = System.Drawing.Color.Aqua;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem setMenu;
        private System.Windows.Forms.ToolStripMenuItem importMenu;
        private System.Windows.Forms.ToolStripMenuItem exportMenu;
        private System.Windows.Forms.ToolStripMenuItem etMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem toolMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.MenuStrip mainMenu;
        private RichTextBox textArea;
    }
}

