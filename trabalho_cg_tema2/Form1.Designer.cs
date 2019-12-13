namespace trabalho_cg_tema2
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
            this.pb_curvesDisplay = new System.Windows.Forms.PictureBox();
            this.pb_modelsDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_curvesDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_modelsDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_curvesDisplay
            // 
            this.pb_curvesDisplay.Location = new System.Drawing.Point(36, 44);
            this.pb_curvesDisplay.Name = "pb_curvesDisplay";
            this.pb_curvesDisplay.Size = new System.Drawing.Size(414, 310);
            this.pb_curvesDisplay.TabIndex = 0;
            this.pb_curvesDisplay.TabStop = false;
            // 
            // pb_modelsDisplay
            // 
            this.pb_modelsDisplay.Location = new System.Drawing.Point(495, 44);
            this.pb_modelsDisplay.Name = "pb_modelsDisplay";
            this.pb_modelsDisplay.Size = new System.Drawing.Size(558, 310);
            this.pb_modelsDisplay.TabIndex = 1;
            this.pb_modelsDisplay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 624);
            this.Controls.Add(this.pb_modelsDisplay);
            this.Controls.Add(this.pb_curvesDisplay);
            this.Name = "Form1";
            this.Text = "Visual3D all night";
            ((System.ComponentModel.ISupportInitialize)(this.pb_curvesDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_modelsDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_curvesDisplay;
        private System.Windows.Forms.PictureBox pb_modelsDisplay;
    }
}

