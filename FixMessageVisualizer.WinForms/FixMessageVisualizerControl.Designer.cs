namespace FixMessageVisualizer.WinForms
{
    partial class FixMessageVisualizerControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.lblMessageName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewMain
            // 
            this.treeViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewMain.Location = new System.Drawing.Point(0, 26);
            this.treeViewMain.Name = "treeViewMain";
            this.treeViewMain.Size = new System.Drawing.Size(305, 416);
            this.treeViewMain.TabIndex = 0;
            this.treeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMain_AfterSelect);
            // 
            // lblMessageName
            // 
            this.lblMessageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageName.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMessageName.Location = new System.Drawing.Point(3, 0);
            this.lblMessageName.Name = "lblMessageName";
            this.lblMessageName.Size = new System.Drawing.Size(302, 24);
            this.lblMessageName.TabIndex = 1;
            this.lblMessageName.Text = "Unknown Fix Message";
            this.lblMessageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FixMessageVisualizerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblMessageName);
            this.Controls.Add(this.treeViewMain);
            this.Name = "FixMessageVisualizerControl";
            this.Size = new System.Drawing.Size(305, 442);
            this.Load += new System.EventHandler(this.FixMessageVisualizerControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.Label lblMessageName;
    }
}
