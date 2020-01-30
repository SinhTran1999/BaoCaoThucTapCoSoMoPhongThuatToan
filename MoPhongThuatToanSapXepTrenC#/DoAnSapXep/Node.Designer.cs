namespace DoAnSapXep
{
    partial class Node
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
            this.btn1 = new System.Windows.Forms.Button();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(38, 68);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseDown);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(38, 32);
            this.tbx1.Multiline = true;
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 20);
            this.tbx1.TabIndex = 1;
            this.tbx1.TextChanged += new System.EventHandler(this.tbx1_TextChanged);
            this.tbx1.Enter += new System.EventHandler(this.tbx1_Enter);
            this.tbx1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx1_KeyDown);
            this.tbx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
            // 
            // Node
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbx1);
            this.Name = "Node";
            this.Load += new System.EventHandler(this.TbxBtn_Load);
            this.BackColorChanged += new System.EventHandler(this.TbxBtn_BackColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox tbx1;
    }
}
