namespace Devil_Cookies_3D
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.switchTo2DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.switchTo3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visualizationToolStripMenuItem
            // 
            this.visualizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.switchTo2DToolStripMenuItem,
            this.createRectangleToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripTextBox2,
            this.switchTo3DToolStripMenuItem});
            this.visualizationToolStripMenuItem.Name = "visualizationToolStripMenuItem";
            this.visualizationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.visualizationToolStripMenuItem.Text = "Visualization";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "2D";
            // 
            // switchTo2DToolStripMenuItem
            // 
            this.switchTo2DToolStripMenuItem.Name = "switchTo2DToolStripMenuItem";
            this.switchTo2DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.switchTo2DToolStripMenuItem.Text = "Switch to 2D";
            this.switchTo2DToolStripMenuItem.Click += new System.EventHandler(this.switchTo2DToolStripMenuItem_Click);
            // 
            // createRectangleToolStripMenuItem
            // 
            this.createRectangleToolStripMenuItem.Name = "createRectangleToolStripMenuItem";
            this.createRectangleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createRectangleToolStripMenuItem.Text = "Create Rectangle";
            this.createRectangleToolStripMenuItem.Click += new System.EventHandler(this.createRectangleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "3D";
            // 
            // switchTo3DToolStripMenuItem
            // 
            this.switchTo3DToolStripMenuItem.Name = "switchTo3DToolStripMenuItem";
            this.switchTo3DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.switchTo3DToolStripMenuItem.Text = "Switch to 3D";
            this.switchTo3DToolStripMenuItem.Click += new System.EventHandler(this.switchTo3DToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 627);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem switchTo2DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem switchTo3DToolStripMenuItem;
    }
}

