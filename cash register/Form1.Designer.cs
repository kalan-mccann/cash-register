namespace cash_register
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
            this.discript1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.glombsinput = new System.Windows.Forms.TextBox();
            this.glackinput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pretaxOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.discript2 = new System.Windows.Forms.Label();
            this.REPCIPTE = new System.Windows.Forms.Label();
            this.priceReveal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.premoney = new System.Windows.Forms.Label();
            this.taxmoney = new System.Windows.Forms.Label();
            this.totalmoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // discript1
            // 
            this.discript1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.discript1.Location = new System.Drawing.Point(0, 98);
            this.discript1.Name = "discript1";
            this.discript1.Size = new System.Drawing.Size(100, 23);
            this.discript1.TabIndex = 0;
            this.discript1.Text = "glacks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // glombsinput
            // 
            this.glombsinput.Location = new System.Drawing.Point(109, 101);
            this.glombsinput.Name = "glombsinput";
            this.glombsinput.Size = new System.Drawing.Size(100, 20);
            this.glombsinput.TabIndex = 2;
            this.glombsinput.Text = "0";
            this.glombsinput.TextChanged += new System.EventHandler(this.glombsinput_TextChanged);
            // 
            // glackinput
            // 
            this.glackinput.Location = new System.Drawing.Point(109, 145);
            this.glackinput.Name = "glackinput";
            this.glackinput.Size = new System.Drawing.Size(100, 20);
            this.glackinput.TabIndex = 3;
            this.glackinput.Text = "0";
            this.glackinput.TextChanged += new System.EventHandler(this.glackinput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // pretaxOutput
            // 
            this.pretaxOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pretaxOutput.Location = new System.Drawing.Point(0, 255);
            this.pretaxOutput.Name = "pretaxOutput";
            this.pretaxOutput.Size = new System.Drawing.Size(100, 23);
            this.pretaxOutput.TabIndex = 8;
            this.pretaxOutput.Text = "Pretax :";
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxOutput.Location = new System.Drawing.Point(0, 294);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 23);
            this.taxOutput.TabIndex = 9;
            this.taxOutput.Text = "Tax :";
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalOutput.Location = new System.Drawing.Point(6, 334);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 10;
            this.totalOutput.Text = "Total:";
            // 
            // discript2
            // 
            this.discript2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.discript2.Location = new System.Drawing.Point(0, 142);
            this.discript2.Name = "discript2";
            this.discript2.Size = new System.Drawing.Size(100, 23);
            this.discript2.TabIndex = 11;
            this.discript2.Text = "glombs";
            // 
            // REPCIPTE
            // 
            this.REPCIPTE.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.REPCIPTE.Location = new System.Drawing.Point(502, 98);
            this.REPCIPTE.Name = "REPCIPTE";
            this.REPCIPTE.Size = new System.Drawing.Size(180, 177);
            this.REPCIPTE.TabIndex = 12;
            this.REPCIPTE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceReveal
            // 
            this.priceReveal.Location = new System.Drawing.Point(67, 204);
            this.priceReveal.Name = "priceReveal";
            this.priceReveal.Size = new System.Drawing.Size(75, 23);
            this.priceReveal.TabIndex = 13;
            this.priceReveal.Text = "price";
            this.priceReveal.UseVisualStyleBackColor = true;
            this.priceReveal.Click += new System.EventHandler(this.priceReveal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 62);
            this.button2.TabIndex = 14;
            this.button2.Text = "Pay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // premoney
            // 
            this.premoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.premoney.Location = new System.Drawing.Point(116, 255);
            this.premoney.Name = "premoney";
            this.premoney.Size = new System.Drawing.Size(100, 23);
            this.premoney.TabIndex = 15;
            this.premoney.Click += new System.EventHandler(this.premoney_Click);
            // 
            // taxmoney
            // 
            this.taxmoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxmoney.Location = new System.Drawing.Point(116, 295);
            this.taxmoney.Name = "taxmoney";
            this.taxmoney.Size = new System.Drawing.Size(100, 23);
            this.taxmoney.TabIndex = 16;
            this.taxmoney.Click += new System.EventHandler(this.taxmoney_Click);
            // 
            // totalmoney
            // 
            this.totalmoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalmoney.Location = new System.Drawing.Point(116, 334);
            this.totalmoney.Name = "totalmoney";
            this.totalmoney.Size = new System.Drawing.Size(100, 23);
            this.totalmoney.TabIndex = 17;
            this.totalmoney.Click += new System.EventHandler(this.totalmoney_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 74);
            this.label1.TabIndex = 18;
            this.label1.Text = "NOT SUSPICOUS AT ALL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalmoney);
            this.Controls.Add(this.taxmoney);
            this.Controls.Add(this.premoney);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.priceReveal);
            this.Controls.Add(this.REPCIPTE);
            this.Controls.Add(this.discript2);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.pretaxOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.glackinput);
            this.Controls.Add(this.glombsinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discript1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label discript1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox glombsinput;
        private System.Windows.Forms.TextBox glackinput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pretaxOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label discript2;
        private System.Windows.Forms.Label REPCIPTE;
        private System.Windows.Forms.Button priceReveal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label premoney;
        private System.Windows.Forms.Label taxmoney;
        private System.Windows.Forms.Label totalmoney;
        private System.Windows.Forms.Label label1;
    }
}

