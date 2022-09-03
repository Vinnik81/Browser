
namespace WinFormsAppBrowser
{
    partial class FormTool
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
            this.panelTool = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelClearHistory = new System.Windows.Forms.Label();
            this.comboBoxSearchUrl = new System.Windows.Forms.ComboBox();
            this.labelSearchEngine = new System.Windows.Forms.Label();
            this.textBoxHomeURL = new System.Windows.Forms.TextBox();
            this.labelHomeURL = new System.Windows.Forms.Label();
            this.panelTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.buttonSave);
            this.panelTool.Controls.Add(this.buttonClear);
            this.panelTool.Controls.Add(this.labelClearHistory);
            this.panelTool.Controls.Add(this.comboBoxSearchUrl);
            this.panelTool.Controls.Add(this.labelSearchEngine);
            this.panelTool.Controls.Add(this.textBoxHomeURL);
            this.panelTool.Controls.Add(this.labelHomeURL);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(800, 282);
            this.panelTool.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(693, 236);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 34);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(158, 139);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(630, 43);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelClearHistory
            // 
            this.labelClearHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelClearHistory.AutoSize = true;
            this.labelClearHistory.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClearHistory.Location = new System.Drawing.Point(12, 146);
            this.labelClearHistory.Name = "labelClearHistory";
            this.labelClearHistory.Size = new System.Drawing.Size(128, 28);
            this.labelClearHistory.TabIndex = 4;
            this.labelClearHistory.Text = "Clear History:";
            // 
            // comboBoxSearchUrl
            // 
            this.comboBoxSearchUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchUrl.FormattingEnabled = true;
            this.comboBoxSearchUrl.Items.AddRange(new object[] {
            "Google",
            "Yandex",
            "Bing"});
            this.comboBoxSearchUrl.Location = new System.Drawing.Point(158, 85);
            this.comboBoxSearchUrl.Name = "comboBoxSearchUrl";
            this.comboBoxSearchUrl.Size = new System.Drawing.Size(630, 23);
            this.comboBoxSearchUrl.TabIndex = 3;
            // 
            // labelSearchEngine
            // 
            this.labelSearchEngine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSearchEngine.AutoSize = true;
            this.labelSearchEngine.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearchEngine.Location = new System.Drawing.Point(12, 81);
            this.labelSearchEngine.Name = "labelSearchEngine";
            this.labelSearchEngine.Size = new System.Drawing.Size(138, 28);
            this.labelSearchEngine.TabIndex = 2;
            this.labelSearchEngine.Text = "Search Engine:";
            // 
            // textBoxHomeURL
            // 
            this.textBoxHomeURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHomeURL.Location = new System.Drawing.Point(158, 28);
            this.textBoxHomeURL.Name = "textBoxHomeURL";
            this.textBoxHomeURL.Size = new System.Drawing.Size(630, 23);
            this.textBoxHomeURL.TabIndex = 1;
            // 
            // labelHomeURL
            // 
            this.labelHomeURL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHomeURL.AutoSize = true;
            this.labelHomeURL.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHomeURL.Location = new System.Drawing.Point(12, 24);
            this.labelHomeURL.Name = "labelHomeURL";
            this.labelHomeURL.Size = new System.Drawing.Size(109, 28);
            this.labelHomeURL.TabIndex = 0;
            this.labelHomeURL.Text = "Home URL:";
            // 
            // FormTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.panelTool);
            this.Name = "FormTool";
            this.Text = "FormTool";
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.Label labelClearHistory;
        public System.Windows.Forms.ComboBox comboBoxSearchUrl;
        private System.Windows.Forms.Label labelSearchEngine;
        public System.Windows.Forms.TextBox textBoxHomeURL;
        private System.Windows.Forms.Label labelHomeURL;
    }
}