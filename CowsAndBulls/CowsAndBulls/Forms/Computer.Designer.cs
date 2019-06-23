namespace Cs_Tech.Forms
{
    partial class Computer
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
            this.BtnGuess = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.NumericUpDown();
            this.digit1 = new System.Windows.Forms.NumericUpDown();
            this.actionsLogPanel = new System.Windows.Forms.GroupBox();
            this.actionsLogComputer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).BeginInit();
            this.actionsLogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuess
            // 
            this.BtnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGuess.Location = new System.Drawing.Point(499, 468);
            this.BtnGuess.Name = "BtnGuess";
            this.BtnGuess.Size = new System.Drawing.Size(246, 50);
            this.BtnGuess.TabIndex = 12;
            this.BtnGuess.Text = "Tahmin Al";
            this.BtnGuess.UseVisualStyleBackColor = true;
            this.BtnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // digit2
            // 
            this.digit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit2.Location = new System.Drawing.Point(625, 375);
            this.digit2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.digit2.Name = "digit2";
            this.digit2.ReadOnly = true;
            this.digit2.Size = new System.Drawing.Size(120, 49);
            this.digit2.TabIndex = 9;
            // 
            // digit1
            // 
            this.digit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit1.Location = new System.Drawing.Point(499, 375);
            this.digit1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.digit1.Name = "digit1";
            this.digit1.ReadOnly = true;
            this.digit1.Size = new System.Drawing.Size(120, 49);
            this.digit1.TabIndex = 8;
            // 
            // actionsLogPanel
            // 
            this.actionsLogPanel.Controls.Add(this.actionsLogComputer);
            this.actionsLogPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionsLogPanel.Location = new System.Drawing.Point(25, 12);
            this.actionsLogPanel.Name = "actionsLogPanel";
            this.actionsLogPanel.Size = new System.Drawing.Size(1239, 300);
            this.actionsLogPanel.TabIndex = 7;
            this.actionsLogPanel.TabStop = false;
            this.actionsLogPanel.Text = "Uygulama Logları";
            // 
            // actionsLogComputer
            // 
            this.actionsLogComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionsLogComputer.Location = new System.Drawing.Point(7, 26);
            this.actionsLogComputer.Multiline = true;
            this.actionsLogComputer.Name = "actionsLogComputer";
            this.actionsLogComputer.ReadOnly = true;
            this.actionsLogComputer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actionsLogComputer.Size = new System.Drawing.Size(1226, 268);
            this.actionsLogComputer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 55);
            this.label2.TabIndex = 14;
            this.label2.Text = "-";
            // 
            // Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuess);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.actionsLogPanel);
            this.Name = "Computer";
            this.Text = "Computer";
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).EndInit();
            this.actionsLogPanel.ResumeLayout(false);
            this.actionsLogPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuess;
        private System.Windows.Forms.NumericUpDown digit2;
        private System.Windows.Forms.NumericUpDown digit1;
        private System.Windows.Forms.GroupBox actionsLogPanel;
        private System.Windows.Forms.TextBox actionsLogComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}