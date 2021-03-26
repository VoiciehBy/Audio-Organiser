
namespace Audio_Organiser
{
    partial class Form2
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
            this.resolutionPanel = new System.Windows.Forms.Panel();
            this.resolutionsBox = new System.Windows.Forms.ListBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.resolutionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resolutionPanel
            // 
            this.resolutionPanel.Controls.Add(this.resolutionsBox);
            this.resolutionPanel.Controls.Add(this.resolutionLabel);
            this.resolutionPanel.Location = new System.Drawing.Point(12, 12);
            this.resolutionPanel.Name = "resolutionPanel";
            this.resolutionPanel.Size = new System.Drawing.Size(354, 230);
            this.resolutionPanel.TabIndex = 66;
            // 
            // resolutionsBox
            // 
            this.resolutionsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resolutionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resolutionsBox.FormattingEnabled = true;
            this.resolutionsBox.ItemHeight = 37;
            this.resolutionsBox.Items.AddRange(new object[] {
            "1280 x 768 (Domyślny)",
            "1024 x 768",
            "800 x 768"});
            this.resolutionsBox.Location = new System.Drawing.Point(3, 79);
            this.resolutionsBox.Name = "resolutionsBox";
            this.resolutionsBox.Size = new System.Drawing.Size(353, 148);
            this.resolutionsBox.TabIndex = 2;
            this.resolutionsBox.SelectedIndexChanged += new System.EventHandler(this.resolutionsBox_SelectedIndexChanged);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resolutionLabel.Location = new System.Drawing.Point(1, 10);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(364, 37);
            this.resolutionLabel.TabIndex = 1;
            this.resolutionLabel.Text = "Wybierz rozdzielczość:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 237);
            this.Controls.Add(this.resolutionPanel);
            this.Name = "Form2";
            this.Text = "Zmiana rozdzielczości";
            this.resolutionPanel.ResumeLayout(false);
            this.resolutionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel resolutionPanel;
        private System.Windows.Forms.ListBox resolutionsBox;
        private System.Windows.Forms.Label resolutionLabel;
    }
}