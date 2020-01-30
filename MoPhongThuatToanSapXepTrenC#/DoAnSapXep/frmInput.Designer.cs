namespace DoAnSapXep
{
    partial class frmInput
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
            this.lbNhapMotDay = new System.Windows.Forms.Label();
            this.tbxdayso = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbSoNodeToiDa = new System.Windows.Forms.Label();
            this.lbDaySo = new System.Windows.Forms.Label();
            this.btnnhap = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNhapMotDay
            // 
            this.lbNhapMotDay.AutoSize = true;
            this.lbNhapMotDay.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapMotDay.ForeColor = System.Drawing.Color.Blue;
            this.lbNhapMotDay.Location = new System.Drawing.Point(199, 31);
            this.lbNhapMotDay.Name = "lbNhapMotDay";
            this.lbNhapMotDay.Size = new System.Drawing.Size(215, 31);
            this.lbNhapMotDay.TabIndex = 0;
            this.lbNhapMotDay.Text = "NHẬP MỘT DÃY";
            // 
            // tbxdayso
            // 
            this.tbxdayso.Location = new System.Drawing.Point(112, 120);
            this.tbxdayso.Multiline = true;
            this.tbxdayso.Name = "tbxdayso";
            this.tbxdayso.Size = new System.Drawing.Size(425, 34);
            this.tbxdayso.TabIndex = 1;
            this.tbxdayso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxdayso_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(280, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lbSoNodeToiDa
            // 
            this.lbSoNodeToiDa.AutoSize = true;
            this.lbSoNodeToiDa.Location = new System.Drawing.Point(109, 71);
            this.lbSoNodeToiDa.Name = "lbSoNodeToiDa";
            this.lbSoNodeToiDa.Size = new System.Drawing.Size(84, 13);
            this.lbSoNodeToiDa.TabIndex = 3;
            this.lbSoNodeToiDa.Text = "Số Node Tối Đa";
            // 
            // lbDaySo
            // 
            this.lbDaySo.AutoSize = true;
            this.lbDaySo.Location = new System.Drawing.Point(27, 132);
            this.lbDaySo.Name = "lbDaySo";
            this.lbDaySo.Size = new System.Drawing.Size(42, 13);
            this.lbDaySo.TabIndex = 4;
            this.lbDaySo.Text = "Dãy Số";
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(174, 199);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(76, 34);
            this.btnnhap.TabIndex = 5;
            this.btnnhap.Text = "OK";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(369, 199);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 34);
            this.btnhuy.TabIndex = 6;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb1.Enabled = false;
            this.lb1.ForeColor = System.Drawing.Color.Gray;
            this.lb1.Location = new System.Drawing.Point(249, 157);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(124, 13);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "Cách nhau bởi dấu cách";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Enabled = false;
            this.lb2.ForeColor = System.Drawing.Color.DarkGray;
            this.lb2.Location = new System.Drawing.Point(249, 183);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(131, 13);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "Giá trị phần tử từ 0 đến 99";
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 245);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.lbDaySo);
            this.Controls.Add(this.lbSoNodeToiDa);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbxdayso);
            this.Controls.Add(this.lbNhapMotDay);
            this.Name = "frmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.Load += new System.EventHandler(this.frmInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapMotDay;
        private System.Windows.Forms.TextBox tbxdayso;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbSoNodeToiDa;
        private System.Windows.Forms.Label lbDaySo;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
    }
}