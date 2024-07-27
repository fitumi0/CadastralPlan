namespace CadastralPlan
{
    partial class AboutForm
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
            this.devInfo = new System.Windows.Forms.LinkLabel();
            this.guideLine = new System.Windows.Forms.Label();
            this.completeDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // devInfo
            // 
            this.devInfo.AutoSize = true;
            this.devInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.devInfo.LinkArea = new System.Windows.Forms.LinkArea(7, 21);
            this.devInfo.Location = new System.Drawing.Point(0, 0);
            this.devInfo.Name = "devInfo";
            this.devInfo.Size = new System.Drawing.Size(127, 17);
            this.devInfo.TabIndex = 0;
            this.devInfo.TabStop = true;
            this.devInfo.Text = "Автор: Червяков Антон";
            this.devInfo.UseCompatibleTextRendering = true;
            this.devInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.devInfo_LinkClicked);
            // 
            // guideLine
            // 
            this.guideLine.AutoSize = true;
            this.guideLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guideLine.Location = new System.Drawing.Point(0, 17);
            this.guideLine.MaximumSize = new System.Drawing.Size(480, 0);
            this.guideLine.Name = "guideLine";
            this.guideLine.Size = new System.Drawing.Size(0, 13);
            this.guideLine.TabIndex = 1;
            // 
            // completeDate
            // 
            this.completeDate.AutoSize = true;
            this.completeDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.completeDate.Location = new System.Drawing.Point(0, 448);
            this.completeDate.Name = "completeDate";
            this.completeDate.Size = new System.Drawing.Size(257, 13);
            this.completeDate.TabIndex = 2;
            this.completeDate.Text = "Дата выполнения тестового задания: 27.07.2024";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.completeDate);
            this.Controls.Add(this.guideLine);
            this.Controls.Add(this.devInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel devInfo;
        private System.Windows.Forms.Label guideLine;
        private System.Windows.Forms.Label completeDate;
    }
}