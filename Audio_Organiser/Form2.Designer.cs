
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.resolutionPanel = new System.Windows.Forms.Panel();
            this.resolutionBox = new System.Windows.Forms.ComboBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.resolutionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resolutionPanel
            // 
            resources.ApplyResources(this.resolutionPanel, "resolutionPanel");
            this.resolutionPanel.Controls.Add(this.resolutionBox);
            this.resolutionPanel.Controls.Add(this.resolutionLabel);
            this.resolutionPanel.Name = "resolutionPanel";
            // 
            // resolutionBox
            // 
            resources.ApplyResources(this.resolutionBox, "resolutionBox");
            this.resolutionBox.FormattingEnabled = true;
            this.resolutionBox.Items.AddRange(new object[] {
            resources.GetString("resolutionBox.Items"),
            resources.GetString("resolutionBox.Items1"),
            resources.GetString("resolutionBox.Items2")});
            this.resolutionBox.Name = "resolutionBox";
            this.resolutionBox.SelectedIndexChanged += new System.EventHandler(this.ResolutionBox_SelectedIndexChanged);
            // 
            // resolutionLabel
            // 
            resources.ApplyResources(this.resolutionLabel, "resolutionLabel");
            this.resolutionLabel.Name = "resolutionLabel";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resolutionPanel);
            this.Name = "Form2";
            this.resolutionPanel.ResumeLayout(false);
            this.resolutionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel resolutionPanel;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.ComboBox resolutionBox;
    }
}