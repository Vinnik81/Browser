
namespace WinFormsAppBrowser
{
    partial class FormFavorit
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
            this.panelFavorit = new System.Windows.Forms.Panel();
            this.buttonCLOSE = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonGO = new System.Windows.Forms.Button();
            this.listBoxFavorit = new System.Windows.Forms.ListBox();
            this.panelFavorit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFavorit
            // 
            this.panelFavorit.Controls.Add(this.buttonCLOSE);
            this.panelFavorit.Controls.Add(this.buttonDELETE);
            this.panelFavorit.Controls.Add(this.buttonGO);
            this.panelFavorit.Controls.Add(this.listBoxFavorit);
            this.panelFavorit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFavorit.Location = new System.Drawing.Point(0, 0);
            this.panelFavorit.Name = "panelFavorit";
            this.panelFavorit.Size = new System.Drawing.Size(800, 450);
            this.panelFavorit.TabIndex = 0;
            // 
            // buttonCLOSE
            // 
            this.buttonCLOSE.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCLOSE.Location = new System.Drawing.Point(654, 409);
            this.buttonCLOSE.Name = "buttonCLOSE";
            this.buttonCLOSE.Size = new System.Drawing.Size(146, 41);
            this.buttonCLOSE.TabIndex = 3;
            this.buttonCLOSE.Text = "CLOSE";
            this.buttonCLOSE.UseVisualStyleBackColor = true;
            this.buttonCLOSE.Click += new System.EventHandler(this.buttonCLOSE_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDELETE.Location = new System.Drawing.Point(169, 409);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(175, 41);
            this.buttonDELETE.TabIndex = 2;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttonGO
            // 
            this.buttonGO.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonGO.Location = new System.Drawing.Point(0, 409);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(169, 41);
            this.buttonGO.TabIndex = 1;
            this.buttonGO.Text = "GO";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // listBoxFavorit
            // 
            this.listBoxFavorit.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxFavorit.FormattingEnabled = true;
            this.listBoxFavorit.ItemHeight = 15;
            this.listBoxFavorit.Location = new System.Drawing.Point(0, 0);
            this.listBoxFavorit.Name = "listBoxFavorit";
            this.listBoxFavorit.Size = new System.Drawing.Size(800, 409);
            this.listBoxFavorit.TabIndex = 0;
            // 
            // FormFavorit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFavorit);
            this.Name = "FormFavorit";
            this.Text = "FormFavorit";
            this.panelFavorit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFavorit;
        private System.Windows.Forms.Button buttonCLOSE;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonGO;
        public System.Windows.Forms.ListBox listBoxFavorit;
    }
}