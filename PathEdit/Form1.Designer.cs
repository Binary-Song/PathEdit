namespace PathEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_add = new System.Windows.Forms.Button();
            this.lst_usrVar = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_revert = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabpg_usr = new System.Windows.Forms.TabPage();
            this.tabpg_sys = new System.Windows.Forms.TabPage();
            this.lst_sysVar = new System.Windows.Forms.ListBox();
            this.tab.SuspendLayout();
            this.tabpg_usr.SuspendLayout();
            this.tabpg_sys.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.Location = new System.Drawing.Point(12, 486);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(53, 50);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lst_usrVar
            // 
            this.lst_usrVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_usrVar.FormattingEnabled = true;
            this.lst_usrVar.ItemHeight = 15;
            this.lst_usrVar.Location = new System.Drawing.Point(3, 3);
            this.lst_usrVar.Name = "lst_usrVar";
            this.lst_usrVar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_usrVar.Size = new System.Drawing.Size(943, 415);
            this.lst_usrVar.TabIndex = 1;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_remove.Location = new System.Drawing.Point(71, 486);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(53, 50);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "-";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btn_revert
            // 
            this.btn_revert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_revert.Location = new System.Drawing.Point(899, 486);
            this.btn_revert.Name = "btn_revert";
            this.btn_revert.Size = new System.Drawing.Size(67, 50);
            this.btn_revert.TabIndex = 3;
            this.btn_revert.Text = "Revert";
            this.btn_revert.UseVisualStyleBackColor = true;
            this.btn_revert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabpg_usr);
            this.tab.Controls.Add(this.tabpg_sys);
            this.tab.Location = new System.Drawing.Point(12, 13);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(957, 450);
            this.tab.TabIndex = 4;
            this.tab.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_Selected);
            // 
            // tabpg_usr
            // 
            this.tabpg_usr.Controls.Add(this.lst_usrVar);
            this.tabpg_usr.Location = new System.Drawing.Point(4, 25);
            this.tabpg_usr.Name = "tabpg_usr";
            this.tabpg_usr.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_usr.Size = new System.Drawing.Size(949, 421);
            this.tabpg_usr.TabIndex = 0;
            this.tabpg_usr.Text = "User";
            this.tabpg_usr.UseVisualStyleBackColor = true;
            // 
            // tabpg_sys
            // 
            this.tabpg_sys.Controls.Add(this.lst_sysVar);
            this.tabpg_sys.Location = new System.Drawing.Point(4, 25);
            this.tabpg_sys.Name = "tabpg_sys";
            this.tabpg_sys.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_sys.Size = new System.Drawing.Size(949, 421);
            this.tabpg_sys.TabIndex = 1;
            this.tabpg_sys.Text = "System";
            this.tabpg_sys.UseVisualStyleBackColor = true;
            // 
            // lst_sysVar
            // 
            this.lst_sysVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_sysVar.FormattingEnabled = true;
            this.lst_sysVar.ItemHeight = 15;
            this.lst_sysVar.Location = new System.Drawing.Point(3, 3);
            this.lst_sysVar.Name = "lst_sysVar";
            this.lst_sysVar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_sysVar.Size = new System.Drawing.Size(943, 415);
            this.lst_sysVar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 548);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.btn_revert);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Path Edit v1.2";
            this.tab.ResumeLayout(false);
            this.tabpg_usr.ResumeLayout(false);
            this.tabpg_sys.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lst_usrVar;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_revert;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabpg_usr;
        private System.Windows.Forms.TabPage tabpg_sys;
        private System.Windows.Forms.ListBox lst_sysVar;
    }
}

