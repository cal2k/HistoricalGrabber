
namespace Historical_Gatherer
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
            this.btnSelectFlipList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnGenFlip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFlipList
            // 
            this.btnSelectFlipList.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFlipList.Name = "btnSelectFlipList";
            this.btnSelectFlipList.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFlipList.TabIndex = 0;
            this.btnSelectFlipList.Text = "Select File";
            this.btnSelectFlipList.UseVisualStyleBackColor = true;
            this.btnSelectFlipList.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(125, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 2;
            // 
            // btnGenFlip
            // 
            this.btnGenFlip.Enabled = false;
            this.btnGenFlip.Location = new System.Drawing.Point(12, 41);
            this.btnGenFlip.Name = "btnGenFlip";
            this.btnGenFlip.Size = new System.Drawing.Size(180, 31);
            this.btnGenFlip.TabIndex = 3;
            this.btnGenFlip.Text = "Generate Flip and Grind list";
            this.btnGenFlip.UseVisualStyleBackColor = true;
            this.btnGenFlip.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 278);
            this.Controls.Add(this.btnGenFlip);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFlipList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFlipList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnGenFlip;
    }
}

