namespace MDI容器
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新增窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.竖直排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增窗口ToolStripMenuItem,
            this.垂直排列ToolStripMenuItem,
            this.竖直排列ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增窗口ToolStripMenuItem
            // 
            this.新增窗口ToolStripMenuItem.Name = "新增窗口ToolStripMenuItem";
            this.新增窗口ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.新增窗口ToolStripMenuItem.Text = "新增窗口";
            this.新增窗口ToolStripMenuItem.Click += new System.EventHandler(this.新增窗口ToolStripMenuItem_Click);
            // 
            // 垂直排列ToolStripMenuItem
            // 
            this.垂直排列ToolStripMenuItem.Name = "垂直排列ToolStripMenuItem";
            this.垂直排列ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.垂直排列ToolStripMenuItem.Text = "垂直排列";
            this.垂直排列ToolStripMenuItem.Click += new System.EventHandler(this.垂直排列ToolStripMenuItem_Click);
            // 
            // 竖直排列ToolStripMenuItem
            // 
            this.竖直排列ToolStripMenuItem.Name = "竖直排列ToolStripMenuItem";
            this.竖直排列ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.竖直排列ToolStripMenuItem.Text = "水平排列";
            this.竖直排列ToolStripMenuItem.Click += new System.EventHandler(this.竖直排列ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 403);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 竖直排列ToolStripMenuItem;
    }
}

