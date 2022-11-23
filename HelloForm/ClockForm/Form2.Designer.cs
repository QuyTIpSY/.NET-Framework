namespace ClockForm
{
    partial class Form2
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
            this.numsophut = new System.Windows.Forms.NumericUpDown();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndongy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numsophut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thời gian: ";
            // 
            // numsophut
            // 
            this.numsophut.Location = new System.Drawing.Point(193, 114);
            this.numsophut.Name = "numsophut";
            this.numsophut.Size = new System.Drawing.Size(120, 22);
            this.numsophut.TabIndex = 1;
            // 
            // btnboqua
            // 
            this.btnboqua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnboqua.Location = new System.Drawing.Point(238, 166);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 2;
            this.btnboqua.Text = "Cancel";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // btndongy
            // 
            this.btndongy.Location = new System.Drawing.Point(128, 166);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(75, 23);
            this.btndongy.TabIndex = 2;
            this.btndongy.Text = "OK";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnboqua;
            this.ClientSize = new System.Drawing.Size(501, 303);
            this.ControlBox = false;
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.numsophut);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numsophut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numsophut;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndongy;
    }
}