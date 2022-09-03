
namespace WinFormsAppBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelView = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonTool = new System.Windows.Forms.Button();
            this.buttonBookmarks = new System.Windows.Forms.Button();
            this.buttonFavorit = new System.Windows.Forms.Button();
            this.buttonSearchT = new System.Windows.Forms.Button();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.buttonForw = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelView.Controls.Add(this.buttonHome);
            this.panelView.Controls.Add(this.buttonTool);
            this.panelView.Controls.Add(this.buttonBookmarks);
            this.panelView.Controls.Add(this.buttonFavorit);
            this.panelView.Controls.Add(this.buttonSearchT);
            this.panelView.Controls.Add(this.textBoxRequest);
            this.panelView.Controls.Add(this.buttonForw);
            this.panelView.Controls.Add(this.buttonBack);
            this.panelView.Controls.Add(this.buttonHistory);
            this.panelView.Controls.Add(this.buttonDel);
            this.panelView.Controls.Add(this.buttonAdd);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(800, 34);
            this.panelView.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.Location = new System.Drawing.Point(624, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(34, 34);
            this.buttonHome.TabIndex = 10;
            this.buttonHome.Text = "🏠";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonTool
            // 
            this.buttonTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTool.Location = new System.Drawing.Point(658, 0);
            this.buttonTool.Name = "buttonTool";
            this.buttonTool.Size = new System.Drawing.Size(34, 34);
            this.buttonTool.TabIndex = 9;
            this.buttonTool.Text = "🛠";
            this.buttonTool.UseVisualStyleBackColor = true;
            this.buttonTool.Click += new System.EventHandler(this.buttonTool_Click);
            // 
            // buttonBookmarks
            // 
            this.buttonBookmarks.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBookmarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBookmarks.Location = new System.Drawing.Point(692, 0);
            this.buttonBookmarks.Name = "buttonBookmarks";
            this.buttonBookmarks.Size = new System.Drawing.Size(37, 34);
            this.buttonBookmarks.TabIndex = 8;
            this.buttonBookmarks.Text = "🧾";
            this.buttonBookmarks.UseVisualStyleBackColor = true;
            this.buttonBookmarks.Click += new System.EventHandler(this.buttonBookmarks_Click);
            // 
            // buttonFavorit
            // 
            this.buttonFavorit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFavorit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFavorit.Location = new System.Drawing.Point(729, 0);
            this.buttonFavorit.Name = "buttonFavorit";
            this.buttonFavorit.Size = new System.Drawing.Size(37, 34);
            this.buttonFavorit.TabIndex = 7;
            this.buttonFavorit.Text = "🌟";
            this.buttonFavorit.UseVisualStyleBackColor = true;
            this.buttonFavorit.Click += new System.EventHandler(this.buttonFavorit_Click);
            // 
            // buttonSearchT
            // 
            this.buttonSearchT.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSearchT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchT.Location = new System.Drawing.Point(559, 0);
            this.buttonSearchT.Name = "buttonSearchT";
            this.buttonSearchT.Size = new System.Drawing.Size(35, 34);
            this.buttonSearchT.TabIndex = 6;
            this.buttonSearchT.Text = "🔎";
            this.buttonSearchT.UseVisualStyleBackColor = true;
            this.buttonSearchT.Click += new System.EventHandler(this.buttonSearchT_Click);
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxRequest.Location = new System.Drawing.Point(143, 0);
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(416, 23);
            this.textBoxRequest.TabIndex = 5;
            this.textBoxRequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRequest_KeyDown);
            // 
            // buttonForw
            // 
            this.buttonForw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonForw.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonForw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonForw.Location = new System.Drawing.Point(110, 0);
            this.buttonForw.Name = "buttonForw";
            this.buttonForw.Size = new System.Drawing.Size(33, 34);
            this.buttonForw.TabIndex = 4;
            this.buttonForw.Text = "➡";
            this.buttonForw.UseVisualStyleBackColor = false;
            this.buttonForw.Click += new System.EventHandler(this.buttonForw_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(76, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(34, 34);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "⬅";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHistory.Location = new System.Drawing.Point(766, 0);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(34, 34);
            this.buttonHistory.TabIndex = 2;
            this.buttonHistory.Text = "📖";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDel.Location = new System.Drawing.Point(40, 0);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(36, 34);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "➖";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 34);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "➕";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(576, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 439);
            this.listBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 439);
            this.tabControl1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 442);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(576, 31);
            this.progressBar1.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(576, 442);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(224, 31);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Browser";
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonForw;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearchT;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonTool;
        private System.Windows.Forms.Button buttonBookmarks;
        private System.Windows.Forms.Button buttonFavorit;
    }
}

