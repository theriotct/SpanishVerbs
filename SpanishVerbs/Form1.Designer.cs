using System;

namespace SpanishVerbs
{
    partial class SpanishVerbs
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radEng = new System.Windows.Forms.RadioButton();
            this.radSpan = new System.Windows.Forms.RadioButton();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Questions:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.LostFocus += new System.EventHandler(this.textBox1_LostFocus);
            // 
            // radEng
            // 
            this.radEng.AutoSize = true;
            this.radEng.Location = new System.Drawing.Point(207, 152);
            this.radEng.Name = "radEng";
            this.radEng.Size = new System.Drawing.Size(59, 17);
            this.radEng.TabIndex = 2;
            this.radEng.TabStop = true;
            this.radEng.Text = "English";
            this.radEng.UseVisualStyleBackColor = true;
            this.radEng.CheckedChanged += new System.EventHandler(this.radEng_CheckedChanged);
            // 
            // radSpan
            // 
            this.radSpan.AutoSize = true;
            this.radSpan.Location = new System.Drawing.Point(207, 175);
            this.radSpan.Name = "radSpan";
            this.radSpan.Size = new System.Drawing.Size(63, 17);
            this.radSpan.TabIndex = 2;
            this.radSpan.TabStop = true;
            this.radSpan.Text = "Spanish";
            this.radSpan.UseVisualStyleBackColor = true;
            this.radSpan.CheckedChanged += new System.EventHandler(this.radEng_CheckedChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(119, 166);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(70, 13);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "Answer With:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(114, 216);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(195, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SpanishVerbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.radSpan);
            this.Controls.Add(this.radEng);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpanishVerbs";
            this.ShowIcon = false;
            this.Text = "Spanish Verbs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpanishVerbs_FormClosed);
            this.Load += new System.EventHandler(this.SpanishVerbs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radEng;
        private System.Windows.Forms.RadioButton radSpan;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
    }
}

