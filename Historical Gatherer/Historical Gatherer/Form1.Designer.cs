
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
            this.btnGenGrind = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPathGrind = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectGrindList = new System.Windows.Forms.Button();
            this.lblPathTrickLine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectTrickLine = new System.Windows.Forms.Button();
            this.btnGenTrickLine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.btnGenFlip.Size = new System.Drawing.Size(180, 23);
            this.btnGenFlip.TabIndex = 3;
            this.btnGenFlip.Text = "Generate Flip List";
            this.btnGenFlip.UseVisualStyleBackColor = true;
            this.btnGenFlip.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnGenGrind
            // 
            this.btnGenGrind.Enabled = false;
            this.btnGenGrind.Location = new System.Drawing.Point(12, 99);
            this.btnGenGrind.Name = "btnGenGrind";
            this.btnGenGrind.Size = new System.Drawing.Size(180, 23);
            this.btnGenGrind.TabIndex = 4;
            this.btnGenGrind.Text = "Generate Grind List";
            this.btnGenGrind.UseVisualStyleBackColor = true;
            this.btnGenGrind.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Desktop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblPathGrind
            // 
            this.lblPathGrind.AutoSize = true;
            this.lblPathGrind.Location = new System.Drawing.Point(125, 75);
            this.lblPathGrind.Name = "lblPathGrind";
            this.lblPathGrind.Size = new System.Drawing.Size(0, 13);
            this.lblPathGrind.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File:";
            // 
            // btnSelectGrindList
            // 
            this.btnSelectGrindList.Location = new System.Drawing.Point(12, 70);
            this.btnSelectGrindList.Name = "btnSelectGrindList";
            this.btnSelectGrindList.Size = new System.Drawing.Size(75, 23);
            this.btnSelectGrindList.TabIndex = 6;
            this.btnSelectGrindList.Text = "Select File";
            this.btnSelectGrindList.UseVisualStyleBackColor = true;
            this.btnSelectGrindList.Click += new System.EventHandler(this.btnSelectGrindList_Click);
            // 
            // lblPathTrickLine
            // 
            this.lblPathTrickLine.AutoSize = true;
            this.lblPathTrickLine.Location = new System.Drawing.Point(125, 133);
            this.lblPathTrickLine.Name = "lblPathTrickLine";
            this.lblPathTrickLine.Size = new System.Drawing.Size(0, 13);
            this.lblPathTrickLine.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "File:";
            // 
            // btnSelectTrickLine
            // 
            this.btnSelectTrickLine.Location = new System.Drawing.Point(12, 128);
            this.btnSelectTrickLine.Name = "btnSelectTrickLine";
            this.btnSelectTrickLine.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTrickLine.TabIndex = 9;
            this.btnSelectTrickLine.Text = "Select File";
            this.btnSelectTrickLine.UseVisualStyleBackColor = true;
            this.btnSelectTrickLine.Click += new System.EventHandler(this.btnSelectTrickLine_Click);
            // 
            // btnGenTrickLine
            // 
            this.btnGenTrickLine.Enabled = false;
            this.btnGenTrickLine.Location = new System.Drawing.Point(12, 157);
            this.btnGenTrickLine.Name = "btnGenTrickLine";
            this.btnGenTrickLine.Size = new System.Drawing.Size(180, 23);
            this.btnGenTrickLine.TabIndex = 12;
            this.btnGenTrickLine.Text = "Generate Grind Trick Line List";
            this.btnGenTrickLine.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Desktop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Desktop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 278);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGenTrickLine);
            this.Controls.Add(this.lblPathTrickLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelectTrickLine);
            this.Controls.Add(this.lblPathGrind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectGrindList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenGrind);
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
        private System.Windows.Forms.Button btnGenGrind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPathGrind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectGrindList;
        private System.Windows.Forms.Label lblPathTrickLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectTrickLine;
        private System.Windows.Forms.Button btnGenTrickLine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

