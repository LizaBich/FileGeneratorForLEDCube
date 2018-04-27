namespace LEDCubeFileGenerator
{
    partial class LedCubeApp
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
            this.CubeViewHost = new System.Windows.Forms.Integration.ElementHost();
            this.cubeView = new LEDCubeFileGenerator.CubeView();
            this.layersList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CubeViewHost
            // 
            this.CubeViewHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CubeViewHost.Location = new System.Drawing.Point(12, 12);
            this.CubeViewHost.MaximumSize = new System.Drawing.Size(400, 400);
            this.CubeViewHost.MinimumSize = new System.Drawing.Size(360, 360);
            this.CubeViewHost.Name = "CubeViewHost";
            this.CubeViewHost.Size = new System.Drawing.Size(360, 360);
            this.CubeViewHost.TabIndex = 0;
            this.CubeViewHost.Text = "CubeViewHost";
            this.CubeViewHost.Child = this.cubeView;
            // 
            // layersList
            // 
            this.layersList.FormattingEnabled = true;
            this.layersList.Items.AddRange(new object[] {
            "Layer 0",
            "Layer 1",
            "Layer 2",
            "Layer 3",
            "Layer 4",
            "Layer 5",
            "Layer 6",
            "Layer 7"});
            this.layersList.Location = new System.Drawing.Point(379, 13);
            this.layersList.Name = "layersList";
            this.layersList.Size = new System.Drawing.Size(131, 21);
            this.layersList.TabIndex = 1;
            // 
            // LedCubeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 382);
            this.Controls.Add(this.layersList);
            this.Controls.Add(this.CubeViewHost);
            this.MinimumSize = new System.Drawing.Size(738, 421);
            this.Name = "LedCubeApp";
            this.Text = "Led Cube File Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost CubeViewHost;
        private CubeView cubeView;
        private System.Windows.Forms.ComboBox layersList;
    }
}

