namespace FixMessageVisualizer.WinForms
{
    partial class FixMessageVisualizerDialog
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
            this.fixMessageVisualizerControl1 = new FixMessageVisualizerControl();
            this.Controls.Add(this.fixMessageVisualizerControl1);

            this.SuspendLayout();
            // 
            // fixMessageVisualizerControl1
            // 
            this.fixMessageVisualizerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fixMessageVisualizerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixMessageVisualizerControl1.Location = new System.Drawing.Point(0, 0);
            this.fixMessageVisualizerControl1.Name = "fixMessageVisualizerControl1";
            this.fixMessageVisualizerControl1.Size = new System.Drawing.Size(396, 557);
            this.fixMessageVisualizerControl1.TabIndex = 0;
            // 
            // FixMessageVisualizerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 557);
            this.Controls.Add(this.fixMessageVisualizerControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FixMessageVisualizerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fix Message Visualizer";
            this.Load += new System.EventHandler(this.FixMessageVisualizerDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FixMessageVisualizerControl fixMessageVisualizerControl1;

    }
}