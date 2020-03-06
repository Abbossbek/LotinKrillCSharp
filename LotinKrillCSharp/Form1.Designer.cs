namespace LotinKrillCSharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nusxaOlishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joylashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hammasiniBelgilashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sozlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krillLotinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotinKrillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nusxaOlishToolStripMenuItem,
            this.joylashToolStripMenuItem,
            this.hammasiniBelgilashToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.MouseEnter += new System.EventHandler(this.rtb_TextChanged);
            // 
            // nusxaOlishToolStripMenuItem
            // 
            this.nusxaOlishToolStripMenuItem.Name = "nusxaOlishToolStripMenuItem";
            resources.ApplyResources(this.nusxaOlishToolStripMenuItem, "nusxaOlishToolStripMenuItem");
            this.nusxaOlishToolStripMenuItem.Click += new System.EventHandler(this.nusxaOlishToolStripMenuItem_Click);
            // 
            // joylashToolStripMenuItem
            // 
            this.joylashToolStripMenuItem.Name = "joylashToolStripMenuItem";
            resources.ApplyResources(this.joylashToolStripMenuItem, "joylashToolStripMenuItem");
            this.joylashToolStripMenuItem.Click += new System.EventHandler(this.joylashToolStripMenuItem_Click);
            // 
            // hammasiniBelgilashToolStripMenuItem
            // 
            this.hammasiniBelgilashToolStripMenuItem.Name = "hammasiniBelgilashToolStripMenuItem";
            resources.ApplyResources(this.hammasiniBelgilashToolStripMenuItem, "hammasiniBelgilashToolStripMenuItem");
            this.hammasiniBelgilashToolStripMenuItem.Click += new System.EventHandler(this.hammasiniBelgilashToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sozlamalarToolStripMenuItem,
            this.toolStripComboBox1,
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // sozlamalarToolStripMenuItem
            // 
            this.sozlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krillLotinToolStripMenuItem,
            this.lotinKrillToolStripMenuItem});
            this.sozlamalarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.sozlamalarToolStripMenuItem, "sozlamalarToolStripMenuItem");
            this.sozlamalarToolStripMenuItem.Name = "sozlamalarToolStripMenuItem";
            this.sozlamalarToolStripMenuItem.DropDownClosed += new System.EventHandler(this.sozlamalarToolStripMenuItem_DropDownClosed);
            this.sozlamalarToolStripMenuItem.DropDownOpened += new System.EventHandler(this.sozlamalarToolStripMenuItem_DropDownOpened);
            // 
            // krillLotinToolStripMenuItem
            // 
            this.krillLotinToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.krillLotinToolStripMenuItem.Checked = true;
            this.krillLotinToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.krillLotinToolStripMenuItem.Name = "krillLotinToolStripMenuItem";
            resources.ApplyResources(this.krillLotinToolStripMenuItem, "krillLotinToolStripMenuItem");
            this.krillLotinToolStripMenuItem.Click += new System.EventHandler(this.krillLotinToolStripMenuItem_Click);
            // 
            // lotinKrillToolStripMenuItem
            // 
            this.lotinKrillToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.lotinKrillToolStripMenuItem.Name = "lotinKrillToolStripMenuItem";
            resources.ApplyResources(this.lotinKrillToolStripMenuItem, "lotinKrillToolStripMenuItem");
            this.lotinKrillToolStripMenuItem.Click += new System.EventHandler(this.lotinKrillToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.Color.Black;
            this.toolStripComboBox1.ForeColor = System.Drawing.Color.White;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBox1.Items"),
            resources.GetString("toolStripComboBox1.Items1"),
            resources.GetString("toolStripComboBox1.Items2"),
            resources.GetString("toolStripComboBox1.Items3"),
            resources.GetString("toolStripComboBox1.Items4"),
            resources.GetString("toolStripComboBox1.Items5"),
            resources.GetString("toolStripComboBox1.Items6"),
            resources.GetString("toolStripComboBox1.Items7"),
            resources.GetString("toolStripComboBox1.Items8")});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            resources.ApplyResources(this.toolStripComboBox1, "toolStripComboBox1");
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripComboBox1_KeyPress);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // rtb1
            // 
            this.rtb1.AcceptsTab = true;
            resources.ApplyResources(this.rtb1, "rtb1");
            this.rtb1.ContextMenuStrip = this.contextMenuStrip1;
            this.rtb1.Name = "rtb1";
            this.rtb1.SelectionChanged += new System.EventHandler(this.rtb2_SelectionChanged);
            this.rtb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtb1_MouseClick);
            this.rtb1.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            this.rtb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtb1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.rtb1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "1";
            this.groupBox1.Layout += new System.Windows.Forms.LayoutEventHandler(this.groupBox1_Layout);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // rtb2
            // 
            this.rtb2.AcceptsTab = true;
            resources.ApplyResources(this.rtb2, "rtb2");
            this.rtb2.ContextMenuStrip = this.contextMenuStrip1;
            this.rtb2.Name = "rtb2";
            this.rtb2.SelectionChanged += new System.EventHandler(this.rtb2_SelectionChanged);
            this.rtb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtb1_MouseClick);
            this.rtb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtb1_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.rtb2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "1";
            this.groupBox2.Layout += new System.Windows.Forms.LayoutEventHandler(this.groupBox1_Layout);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LotinKrillCSharp.Properties.Resources.IMG_20181204_222604_652_1;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged_1);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sozlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krillLotinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lotinKrillToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nusxaOlishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joylashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hammasiniBelgilashToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

