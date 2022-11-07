namespace ToolCheckSHD
{
    partial class FrmToolCheck
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
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ImageView = new System.Windows.Forms.PictureBox();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.txtNameImage = new System.Windows.Forms.TextBox();
            this.lblValueIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(13, 13);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(54, 31);
            this.btnChoosePath.TabIndex = 0;
            this.btnChoosePath.Text = "...";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(85, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(690, 29);
            this.txtPath.TabIndex = 1;
            this.txtPath.TabStop = false;
            // 
            // ImageView
            // 
            this.ImageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageView.Location = new System.Drawing.Point(13, 51);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(762, 618);
            this.ImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageView.TabIndex = 2;
            this.ImageView.TabStop = false;
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(781, 111);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(471, 29);
            this.txtEntry.TabIndex = 1;
            this.txtEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntry_KeyDown);
            // 
            // txtNameImage
            // 
            this.txtNameImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameImage.Location = new System.Drawing.Point(781, 337);
            this.txtNameImage.Name = "txtNameImage";
            this.txtNameImage.ReadOnly = true;
            this.txtNameImage.Size = new System.Drawing.Size(354, 40);
            this.txtNameImage.TabIndex = 6;
            this.txtNameImage.TabStop = false;
            // 
            // lblValueIndex
            // 
            this.lblValueIndex.AutoSize = true;
            this.lblValueIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblValueIndex.Location = new System.Drawing.Point(1160, 640);
            this.lblValueIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueIndex.Name = "lblValueIndex";
            this.lblValueIndex.Size = new System.Drawing.Size(20, 29);
            this.lblValueIndex.TabIndex = 7;
            this.lblValueIndex.Text = "/";
            // 
            // FrmToolCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 681);
            this.Controls.Add(this.lblValueIndex);
            this.Controls.Add(this.txtNameImage);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.ImageView);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnChoosePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmToolCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check SHD";
            this.Load += new System.EventHandler(this.FrmToolCheck_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmToolCheck_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.PictureBox ImageView;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.TextBox txtNameImage;
        private System.Windows.Forms.Label lblValueIndex;
    }
}

