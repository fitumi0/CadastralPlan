namespace CadastralPlan
{
    partial class PreviewXmlForm
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
            this.xmlPreviewBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xmlPreviewBox
            // 
            this.xmlPreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlPreviewBox.Location = new System.Drawing.Point(0, 0);
            this.xmlPreviewBox.Multiline = true;
            this.xmlPreviewBox.Name = "xmlPreviewBox";
            this.xmlPreviewBox.ReadOnly = true;
            this.xmlPreviewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.xmlPreviewBox.Size = new System.Drawing.Size(800, 450);
            this.xmlPreviewBox.TabIndex = 0;
            // 
            // PreviewXmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xmlPreviewBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PreviewXmlForm";
            this.Text = "PreviewXmlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xmlPreviewBox;
    }
}