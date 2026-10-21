namespace AdoNet_Lab4
{
    partial class victorform
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
            this.labevictor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addvform = new System.Windows.Forms.Button();
            this.cancelv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labevictor
            // 
            this.labevictor.AutoSize = true;
            this.labevictor.Location = new System.Drawing.Point(203, 92);
            this.labevictor.Name = "labevictor";
            this.labevictor.Size = new System.Drawing.Size(76, 13);
            this.labevictor.TabIndex = 0;
            this.labevictor.Text = "Enter Keyword";
            this.labevictor.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 1;
            // 
            // addvform
            // 
            this.addvform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addvform.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addvform.Location = new System.Drawing.Point(65, 183);
            this.addvform.Name = "addvform";
            this.addvform.Size = new System.Drawing.Size(75, 23);
            this.addvform.TabIndex = 2;
            this.addvform.Text = "Ok";
            this.addvform.UseVisualStyleBackColor = true;
            // 
            // cancelv
            // 
            this.cancelv.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelv.Location = new System.Drawing.Point(317, 183);
            this.cancelv.Name = "cancelv";
            this.cancelv.Size = new System.Drawing.Size(75, 23);
            this.cancelv.TabIndex = 3;
            this.cancelv.Text = "Cancel";
            this.cancelv.UseVisualStyleBackColor = true;
            // 
            // victorform
            // 
            this.AcceptButton = this.addvform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelv;
            this.ClientSize = new System.Drawing.Size(458, 252);
            this.Controls.Add(this.cancelv);
            this.Controls.Add(this.addvform);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labevictor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "victorform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Keyword";
            this.Load += new System.EventHandler(this.victorform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labevictor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addvform;
        private System.Windows.Forms.Button cancelv;
    }
}