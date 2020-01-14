namespace AssignmentASE
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
            this.panel_drawing = new System.Windows.Forms.Panel();
            this.textBox_single = new System.Windows.Forms.TextBox();
            this.textBox_multiline = new System.Windows.Forms.TextBox();
            this.btnSingle_run = new System.Windows.Forms.Button();
            this.btn_execute = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.textBox_console = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_drawing
            // 
            this.panel_drawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_drawing.Location = new System.Drawing.Point(12, 27);
            this.panel_drawing.Name = "panel_drawing";
            this.panel_drawing.Size = new System.Drawing.Size(471, 298);
            this.panel_drawing.TabIndex = 0;
            this.panel_drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_drawing_Paint);
            // 
            // textBox_single
            // 
            this.textBox_single.Location = new System.Drawing.Point(489, 45);
            this.textBox_single.Name = "textBox_single";
            this.textBox_single.Size = new System.Drawing.Size(335, 20);
            this.textBox_single.TabIndex = 0;
            // 
            // textBox_multiline
            // 
            this.textBox_multiline.Location = new System.Drawing.Point(12, 340);
            this.textBox_multiline.Multiline = true;
            this.textBox_multiline.Name = "textBox_multiline";
            this.textBox_multiline.Size = new System.Drawing.Size(471, 191);
            this.textBox_multiline.TabIndex = 1;
            this.textBox_multiline.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSingle_run
            // 
            this.btnSingle_run.Location = new System.Drawing.Point(842, 42);
            this.btnSingle_run.Name = "btnSingle_run";
            this.btnSingle_run.Size = new System.Drawing.Size(75, 23);
            this.btnSingle_run.TabIndex = 2;
            this.btnSingle_run.Text = "Run";
            this.btnSingle_run.UseVisualStyleBackColor = true;
            this.btnSingle_run.Click += new System.EventHandler(this.btnSingle_run_Click);
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(501, 226);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(416, 48);
            this.btn_execute.TabIndex = 4;
            this.btn_execute.Text = "Execute";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(501, 159);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(416, 38);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(501, 97);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(416, 43);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // textBox_console
            // 
            this.textBox_console.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_console.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_console.Location = new System.Drawing.Point(501, 304);
            this.textBox_console.Multiline = true;
            this.textBox_console.Name = "textBox_console";
            this.textBox_console.ReadOnly = true;
            this.textBox_console.Size = new System.Drawing.Size(416, 227);
            this.textBox_console.TabIndex = 7;
            this.textBox_console.Text = "Console:";
            this.textBox_console.TextChanged += new System.EventHandler(this.textBox_console_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 565);
            this.Controls.Add(this.textBox_console);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.btnSingle_run);
            this.Controls.Add(this.textBox_single);
            this.Controls.Add(this.textBox_multiline);
            this.Controls.Add(this.panel_drawing);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_drawing;
        private System.Windows.Forms.TextBox textBox_single;
        private System.Windows.Forms.TextBox textBox_multiline;
        private System.Windows.Forms.Button btnSingle_run;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox textBox_console;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

