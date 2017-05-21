namespace LeetcodeManager.View
{
    partial class ProblemInputForm
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
            this.titleTxtbox = new System.Windows.Forms.TextBox();
            this.LtCodeTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contentTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CsdnTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // titleTxtbox
            // 
            this.titleTxtbox.Location = new System.Drawing.Point(170, 55);
            this.titleTxtbox.Multiline = true;
            this.titleTxtbox.Name = "titleTxtbox";
            this.titleTxtbox.Size = new System.Drawing.Size(364, 22);
            this.titleTxtbox.TabIndex = 1;
            this.titleTxtbox.Text = "Leetcode problem title";
            // 
            // LtCodeTxtbox
            // 
            this.LtCodeTxtbox.Location = new System.Drawing.Point(170, 104);
            this.LtCodeTxtbox.Multiline = true;
            this.LtCodeTxtbox.Name = "LtCodeTxtbox";
            this.LtCodeTxtbox.Size = new System.Drawing.Size(364, 22);
            this.LtCodeTxtbox.TabIndex = 3;
            this.LtCodeTxtbox.Text = "LeetCode problem Website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "LeetCode Website";
            // 
            // contentTxtbox
            // 
            this.contentTxtbox.Location = new System.Drawing.Point(33, 154);
            this.contentTxtbox.Multiline = true;
            this.contentTxtbox.Name = "contentTxtbox";
            this.contentTxtbox.Size = new System.Drawing.Size(501, 245);
            this.contentTxtbox.TabIndex = 4;
            this.contentTxtbox.Text = "content of problem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Content";
            // 
            // CsdnTxtbox
            // 
            this.CsdnTxtbox.Location = new System.Drawing.Point(173, 424);
            this.CsdnTxtbox.Multiline = true;
            this.CsdnTxtbox.Name = "CsdnTxtbox";
            this.CsdnTxtbox.Size = new System.Drawing.Size(361, 22);
            this.CsdnTxtbox.TabIndex = 7;
            this.CsdnTxtbox.Text = "CSDN WebSite Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "CSDN Website";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tags";
            // 
            // ProblemInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 510);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CsdnTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contentTxtbox);
            this.Controls.Add(this.LtCodeTxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleTxtbox);
            this.Controls.Add(this.label1);
            this.Name = "ProblemInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problem Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTxtbox;
        private System.Windows.Forms.TextBox LtCodeTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contentTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CsdnTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}