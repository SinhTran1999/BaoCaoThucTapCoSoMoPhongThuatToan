using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace DoAnSapXep
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            this.lbHuy = new System.Windows.Forms.Label();
            this.lbKhoiTao = new System.Windows.Forms.Label();
            this.lbDieuKhien = new System.Windows.Forms.Label();
            this.lbThuatToan = new System.Windows.Forms.Label();
            this.lbSapXep = new System.Windows.Forms.Label();
            this.lbMangChuaSapXep = new System.Windows.Forms.Label();
            this.sapxepPanel = new System.Windows.Forms.Panel();
            this.lbTocDo = new System.Windows.Forms.Label();
            this.chuasapxepPanel = new System.Windows.Forms.Panel();
            this.yTuongTextBox = new System.Windows.Forms.TextBox();
            this.daydangxepListbox = new System.Windows.Forms.ListBox();
            this.thuattoanpanel = new System.Windows.Forms.Panel();
            this.insertionrdbtn = new System.Windows.Forms.RadioButton();
            this.mergerdbtn = new System.Windows.Forms.RadioButton();
            this.shellrdbtn = new System.Windows.Forms.RadioButton();
            this.quickrdbtn = new System.Windows.Forms.RadioButton();
            this.shakerrdbtn = new System.Windows.Forms.RadioButton();
            this.selectionrdbtn = new System.Windows.Forms.RadioButton();
            this.heaprdbtn = new System.Windows.Forms.RadioButton();
            this.bubblerdbtn = new System.Windows.Forms.RadioButton();
            this.binaryinsertionrdbtn = new System.Windows.Forms.RadioButton();
            this.interchangerdbtn = new System.Windows.Forms.RadioButton();
            this.Loaisapxeppanel = new System.Windows.Forms.Panel();
            this.giamrdbtn = new System.Windows.Forms.RadioButton();
            this.tangrdbtn = new System.Windows.Forms.RadioButton();
            this.dieukhienpanel = new System.Windows.Forms.Panel();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.huybnt = new System.Windows.Forms.Button();
            this.batdaubtn = new System.Windows.Forms.Button();
            this.dungbtn = new System.Windows.Forms.Button();
            this.khoitaopanel = new System.Windows.Forms.Panel();
            this.soluongNodetbx = new System.Windows.Forms.TextBox();
            this.nhaptaybtn = new System.Windows.Forms.Button();
            this.lbSoPhanTu = new System.Windows.Forms.Label();
            this.venutbtn = new System.Windows.Forms.Button();
            this.taongaunhienbtn = new System.Windows.Forms.Button();
            this.huypanel = new System.Windows.Forms.Panel();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.xoamangbtn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btndebug = new System.Windows.Forms.Button();
            this.cboxdebug = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HienThiPanel = new System.Windows.Forms.Panel();
            this.ngonngupanel = new System.Windows.Forms.Panel();
            this.btnVi = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            this.lbNgonNgu = new System.Windows.Forms.Label();
            this.tabctlytuong = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chuasapxepPanel.SuspendLayout();
            this.thuattoanpanel.SuspendLayout();
            this.Loaisapxeppanel.SuspendLayout();
            this.dieukhienpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.khoitaopanel.SuspendLayout();
            this.huypanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.HienThiPanel.SuspendLayout();
            this.ngonngupanel.SuspendLayout();
            this.tabctlytuong.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHuy
            // 
            this.lbHuy.AutoSize = true;
            this.lbHuy.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHuy.ForeColor = System.Drawing.Color.Silver;
            this.lbHuy.Location = new System.Drawing.Point(5, 0);
            this.lbHuy.Name = "lbHuy";
            this.lbHuy.Size = new System.Drawing.Size(36, 16);
            this.lbHuy.TabIndex = 12;
            this.lbHuy.Text = "Hủy";
            // 
            // lbKhoiTao
            // 
            this.lbKhoiTao.AutoSize = true;
            this.lbKhoiTao.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoiTao.ForeColor = System.Drawing.Color.Silver;
            this.lbKhoiTao.Location = new System.Drawing.Point(2, 0);
            this.lbKhoiTao.Name = "lbKhoiTao";
            this.lbKhoiTao.Size = new System.Drawing.Size(73, 16);
            this.lbKhoiTao.TabIndex = 13;
            this.lbKhoiTao.Text = "Khởi Tạo";
            // 
            // lbDieuKhien
            // 
            this.lbDieuKhien.AutoSize = true;
            this.lbDieuKhien.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDieuKhien.ForeColor = System.Drawing.Color.Silver;
            this.lbDieuKhien.Location = new System.Drawing.Point(3, 11);
            this.lbDieuKhien.Name = "lbDieuKhien";
            this.lbDieuKhien.Size = new System.Drawing.Size(90, 16);
            this.lbDieuKhien.TabIndex = 14;
            this.lbDieuKhien.Text = "Điều Khiển";
            // 
            // lbThuatToan
            // 
            this.lbThuatToan.AutoSize = true;
            this.lbThuatToan.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuatToan.ForeColor = System.Drawing.Color.Silver;
            this.lbThuatToan.Location = new System.Drawing.Point(-3, -1);
            this.lbThuatToan.Name = "lbThuatToan";
            this.lbThuatToan.Size = new System.Drawing.Size(90, 16);
            this.lbThuatToan.TabIndex = 15;
            this.lbThuatToan.Text = "Thuật Toán";
            // 
            // lbSapXep
            // 
            this.lbSapXep.AutoSize = true;
            this.lbSapXep.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSapXep.ForeColor = System.Drawing.Color.Silver;
            this.lbSapXep.Location = new System.Drawing.Point(3, -1);
            this.lbSapXep.Name = "lbSapXep";
            this.lbSapXep.Size = new System.Drawing.Size(66, 16);
            this.lbSapXep.TabIndex = 16;
            this.lbSapXep.Text = "Sắp Xếp";
            // 
            // lbMangChuaSapXep
            // 
            this.lbMangChuaSapXep.AutoSize = true;
            this.lbMangChuaSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMangChuaSapXep.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMangChuaSapXep.ForeColor = System.Drawing.Color.Silver;
            this.lbMangChuaSapXep.Location = new System.Drawing.Point(7, 10);
            this.lbMangChuaSapXep.Name = "lbMangChuaSapXep";
            this.lbMangChuaSapXep.Size = new System.Drawing.Size(108, 16);
            this.lbMangChuaSapXep.TabIndex = 17;
            this.lbMangChuaSapXep.Text = "Mảng ban đầu\r\n";
            // 
            // sapxepPanel
            // 
            this.sapxepPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sapxepPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sapxepPanel.Location = new System.Drawing.Point(7, 12);
            this.sapxepPanel.Name = "sapxepPanel";
            this.sapxepPanel.Size = new System.Drawing.Size(1144, 298);
            this.sapxepPanel.TabIndex = 18;
            this.sapxepPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sapxepPanel_MouseClick);
            // 
            // lbTocDo
            // 
            this.lbTocDo.AutoSize = true;
            this.lbTocDo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTocDo.ForeColor = System.Drawing.Color.Silver;
            this.lbTocDo.Location = new System.Drawing.Point(226, 39);
            this.lbTocDo.Name = "lbTocDo";
            this.lbTocDo.Size = new System.Drawing.Size(56, 16);
            this.lbTocDo.TabIndex = 4;
            this.lbTocDo.Text = "Tốc độ";
            // 
            // chuasapxepPanel
            // 
            this.chuasapxepPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.chuasapxepPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chuasapxepPanel.Controls.Add(this.lbMangChuaSapXep);
            this.chuasapxepPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuasapxepPanel.Location = new System.Drawing.Point(7, 310);
            this.chuasapxepPanel.Name = "chuasapxepPanel";
            this.chuasapxepPanel.Size = new System.Drawing.Size(1143, 39);
            this.chuasapxepPanel.TabIndex = 19;
            // 
            // yTuongTextBox
            // 
            this.yTuongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.yTuongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yTuongTextBox.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yTuongTextBox.ForeColor = System.Drawing.Color.Silver;
            this.yTuongTextBox.Location = new System.Drawing.Point(2, 1);
            this.yTuongTextBox.Multiline = true;
            this.yTuongTextBox.Name = "yTuongTextBox";
            this.yTuongTextBox.ReadOnly = true;
            this.yTuongTextBox.Size = new System.Drawing.Size(400, 131);
            this.yTuongTextBox.TabIndex = 12;
            // 
            // daydangxepListbox
            // 
            this.daydangxepListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.daydangxepListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daydangxepListbox.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daydangxepListbox.ForeColor = System.Drawing.Color.Silver;
            this.daydangxepListbox.FormattingEnabled = true;
            this.daydangxepListbox.ItemHeight = 15;
            this.daydangxepListbox.Location = new System.Drawing.Point(6, 6);
            this.daydangxepListbox.Name = "daydangxepListbox";
            this.daydangxepListbox.Size = new System.Drawing.Size(385, 120);
            this.daydangxepListbox.TabIndex = 13;
            // 
            // thuattoanpanel
            // 
            this.thuattoanpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.thuattoanpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thuattoanpanel.Controls.Add(this.insertionrdbtn);
            this.thuattoanpanel.Controls.Add(this.mergerdbtn);
            this.thuattoanpanel.Controls.Add(this.shellrdbtn);
            this.thuattoanpanel.Controls.Add(this.quickrdbtn);
            this.thuattoanpanel.Controls.Add(this.shakerrdbtn);
            this.thuattoanpanel.Controls.Add(this.selectionrdbtn);
            this.thuattoanpanel.Controls.Add(this.heaprdbtn);
            this.thuattoanpanel.Controls.Add(this.bubblerdbtn);
            this.thuattoanpanel.Controls.Add(this.binaryinsertionrdbtn);
            this.thuattoanpanel.Controls.Add(this.interchangerdbtn);
            this.thuattoanpanel.Controls.Add(this.lbThuatToan);
            this.thuattoanpanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thuattoanpanel.Location = new System.Drawing.Point(6, 518);
            this.thuattoanpanel.Name = "thuattoanpanel";
            this.thuattoanpanel.Size = new System.Drawing.Size(292, 132);
            this.thuattoanpanel.TabIndex = 4;
            // 
            // insertionrdbtn
            // 
            this.insertionrdbtn.AutoSize = true;
            this.insertionrdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.insertionrdbtn.Location = new System.Drawing.Point(170, 16);
            this.insertionrdbtn.Name = "insertionrdbtn";
            this.insertionrdbtn.Size = new System.Drawing.Size(90, 17);
            this.insertionrdbtn.TabIndex = 12;
            this.insertionrdbtn.Text = "Insertion sort";
            this.insertionrdbtn.UseVisualStyleBackColor = true;
            this.insertionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // mergerdbtn
            // 
            this.mergerdbtn.AutoSize = true;
            this.mergerdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.mergerdbtn.Location = new System.Drawing.Point(34, 108);
            this.mergerdbtn.Name = "mergerdbtn";
            this.mergerdbtn.Size = new System.Drawing.Size(77, 17);
            this.mergerdbtn.TabIndex = 21;
            this.mergerdbtn.Text = "Merge sort";
            this.mergerdbtn.UseVisualStyleBackColor = true;
            this.mergerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // shellrdbtn
            // 
            this.shellrdbtn.AutoSize = true;
            this.shellrdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.shellrdbtn.Location = new System.Drawing.Point(170, 108);
            this.shellrdbtn.Name = "shellrdbtn";
            this.shellrdbtn.Size = new System.Drawing.Size(69, 17);
            this.shellrdbtn.TabIndex = 20;
            this.shellrdbtn.Text = "Shell sort";
            this.shellrdbtn.UseVisualStyleBackColor = true;
            this.shellrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // quickrdbtn
            // 
            this.quickrdbtn.AutoSize = true;
            this.quickrdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.quickrdbtn.Location = new System.Drawing.Point(170, 85);
            this.quickrdbtn.Name = "quickrdbtn";
            this.quickrdbtn.Size = new System.Drawing.Size(73, 17);
            this.quickrdbtn.TabIndex = 19;
            this.quickrdbtn.Text = "Quick sort";
            this.quickrdbtn.UseVisualStyleBackColor = true;
            this.quickrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // shakerrdbtn
            // 
            this.shakerrdbtn.AutoSize = true;
            this.shakerrdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.shakerrdbtn.Location = new System.Drawing.Point(170, 62);
            this.shakerrdbtn.Name = "shakerrdbtn";
            this.shakerrdbtn.Size = new System.Drawing.Size(80, 17);
            this.shakerrdbtn.TabIndex = 18;
            this.shakerrdbtn.Text = "Shaker sort";
            this.shakerrdbtn.UseVisualStyleBackColor = true;
            this.shakerrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // selectionrdbtn
            // 
            this.selectionrdbtn.AutoSize = true;
            this.selectionrdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.selectionrdbtn.Location = new System.Drawing.Point(170, 39);
            this.selectionrdbtn.Name = "selectionrdbtn";
            this.selectionrdbtn.Size = new System.Drawing.Size(90, 17);
            this.selectionrdbtn.TabIndex = 17;
            this.selectionrdbtn.Text = "Selection sort";
            this.selectionrdbtn.UseVisualStyleBackColor = true;
            this.selectionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // heaprdbtn
            // 
            this.heaprdbtn.AutoSize = true;
            this.heaprdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.heaprdbtn.Location = new System.Drawing.Point(34, 85);
            this.heaprdbtn.Name = "heaprdbtn";
            this.heaprdbtn.Size = new System.Drawing.Size(72, 17);
            this.heaprdbtn.TabIndex = 12;
            this.heaprdbtn.Text = "Heap sort";
            this.heaprdbtn.UseVisualStyleBackColor = true;
            this.heaprdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // bubblerdbtn
            // 
            this.bubblerdbtn.AutoSize = true;
            this.bubblerdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.bubblerdbtn.Location = new System.Drawing.Point(34, 62);
            this.bubblerdbtn.Name = "bubblerdbtn";
            this.bubblerdbtn.Size = new System.Drawing.Size(79, 17);
            this.bubblerdbtn.TabIndex = 16;
            this.bubblerdbtn.Text = "Bubble sort";
            this.bubblerdbtn.UseVisualStyleBackColor = true;
            this.bubblerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // binaryinsertionrdbtn
            // 
            this.binaryinsertionrdbtn.AutoSize = true;
            this.binaryinsertionrdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.binaryinsertionrdbtn.Location = new System.Drawing.Point(34, 39);
            this.binaryinsertionrdbtn.Name = "binaryinsertionrdbtn";
            this.binaryinsertionrdbtn.Size = new System.Drawing.Size(121, 17);
            this.binaryinsertionrdbtn.TabIndex = 12;
            this.binaryinsertionrdbtn.Text = "Binary insertion sort";
            this.binaryinsertionrdbtn.UseVisualStyleBackColor = true;
            this.binaryinsertionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // interchangerdbtn
            // 
            this.interchangerdbtn.AutoSize = true;
            this.interchangerdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.interchangerdbtn.Location = new System.Drawing.Point(34, 16);
            this.interchangerdbtn.Name = "interchangerdbtn";
            this.interchangerdbtn.Size = new System.Drawing.Size(106, 17);
            this.interchangerdbtn.TabIndex = 12;
            this.interchangerdbtn.Text = "Interchange sort";
            this.interchangerdbtn.UseVisualStyleBackColor = true;
            this.interchangerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // Loaisapxeppanel
            // 
            this.Loaisapxeppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Loaisapxeppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loaisapxeppanel.Controls.Add(this.giamrdbtn);
            this.Loaisapxeppanel.Controls.Add(this.tangrdbtn);
            this.Loaisapxeppanel.Controls.Add(this.lbSapXep);
            this.Loaisapxeppanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loaisapxeppanel.ForeColor = System.Drawing.Color.DarkGray;
            this.Loaisapxeppanel.Location = new System.Drawing.Point(304, 518);
            this.Loaisapxeppanel.Name = "Loaisapxeppanel";
            this.Loaisapxeppanel.Size = new System.Drawing.Size(104, 60);
            this.Loaisapxeppanel.TabIndex = 21;
            // 
            // giamrdbtn
            // 
            this.giamrdbtn.AutoSize = true;
            this.giamrdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.giamrdbtn.Location = new System.Drawing.Point(20, 39);
            this.giamrdbtn.Name = "giamrdbtn";
            this.giamrdbtn.Size = new System.Drawing.Size(48, 17);
            this.giamrdbtn.TabIndex = 12;
            this.giamrdbtn.TabStop = true;
            this.giamrdbtn.Text = "Giảm";
            this.giamrdbtn.UseVisualStyleBackColor = true;
            this.giamrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // tangrdbtn
            // 
            this.tangrdbtn.AutoSize = true;
            this.tangrdbtn.ForeColor = System.Drawing.Color.DarkGray;
            this.tangrdbtn.Location = new System.Drawing.Point(20, 18);
            this.tangrdbtn.Name = "tangrdbtn";
            this.tangrdbtn.Size = new System.Drawing.Size(49, 17);
            this.tangrdbtn.TabIndex = 13;
            this.tangrdbtn.TabStop = true;
            this.tangrdbtn.Text = "Tăng";
            this.tangrdbtn.UseVisualStyleBackColor = true;
            this.tangrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // dieukhienpanel
            // 
            this.dieukhienpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.dieukhienpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dieukhienpanel.Controls.Add(this.btnCaiDat);
            this.dieukhienpanel.Controls.Add(this.label1);
            this.dieukhienpanel.Controls.Add(this.trackBar1);
            this.dieukhienpanel.Controls.Add(this.label11);
            this.dieukhienpanel.Controls.Add(this.lbTocDo);
            this.dieukhienpanel.Controls.Add(this.huybnt);
            this.dieukhienpanel.Controls.Add(this.batdaubtn);
            this.dieukhienpanel.Controls.Add(this.dungbtn);
            this.dieukhienpanel.Controls.Add(this.lbDieuKhien);
            this.dieukhienpanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieukhienpanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dieukhienpanel.Location = new System.Drawing.Point(847, 355);
            this.dieukhienpanel.Name = "dieukhienpanel";
            this.dieukhienpanel.Size = new System.Drawing.Size(303, 116);
            this.dieukhienpanel.TabIndex = 23;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Location = new System.Drawing.Point(219, 77);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(61, 23);
            this.btnCaiDat.TabIndex = 0;
            this.btnCaiDat.Text = "Cài đặt";
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "5";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(85, 39);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(135, 32);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(136, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "00:00";
            // 
            // huybnt
            // 
            this.huybnt.Location = new System.Drawing.Point(152, 77);
            this.huybnt.Name = "huybnt";
            this.huybnt.Size = new System.Drawing.Size(61, 23);
            this.huybnt.TabIndex = 8;
            this.huybnt.Text = "Hủy";
            this.huybnt.UseVisualStyleBackColor = true;
            this.huybnt.Click += new System.EventHandler(this.huybnt_Click);
            // 
            // batdaubtn
            // 
            this.batdaubtn.Location = new System.Drawing.Point(20, 77);
            this.batdaubtn.Name = "batdaubtn";
            this.batdaubtn.Size = new System.Drawing.Size(61, 23);
            this.batdaubtn.TabIndex = 10;
            this.batdaubtn.Text = "Bắt đầu";
            this.batdaubtn.UseVisualStyleBackColor = true;
            this.batdaubtn.Click += new System.EventHandler(this.batdaubtn_Click);
            // 
            // dungbtn
            // 
            this.dungbtn.Location = new System.Drawing.Point(87, 77);
            this.dungbtn.Name = "dungbtn";
            this.dungbtn.Size = new System.Drawing.Size(61, 23);
            this.dungbtn.TabIndex = 9;
            this.dungbtn.Text = "Dừng";
            this.dungbtn.UseVisualStyleBackColor = true;
            this.dungbtn.Click += new System.EventHandler(this.dungbtn_Click);
            // 
            // khoitaopanel
            // 
            this.khoitaopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.khoitaopanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.khoitaopanel.Controls.Add(this.soluongNodetbx);
            this.khoitaopanel.Controls.Add(this.nhaptaybtn);
            this.khoitaopanel.Controls.Add(this.lbSoPhanTu);
            this.khoitaopanel.Controls.Add(this.venutbtn);
            this.khoitaopanel.Controls.Add(this.taongaunhienbtn);
            this.khoitaopanel.Controls.Add(this.lbKhoiTao);
            this.khoitaopanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoitaopanel.Location = new System.Drawing.Point(847, 477);
            this.khoitaopanel.Name = "khoitaopanel";
            this.khoitaopanel.Size = new System.Drawing.Size(303, 115);
            this.khoitaopanel.TabIndex = 24;
            // 
            // soluongNodetbx
            // 
            this.soluongNodetbx.Location = new System.Drawing.Point(152, 27);
            this.soluongNodetbx.Multiline = true;
            this.soluongNodetbx.Name = "soluongNodetbx";
            this.soluongNodetbx.Size = new System.Drawing.Size(41, 18);
            this.soluongNodetbx.TabIndex = 15;
            this.soluongNodetbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.soluongNodetbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nhaptaybtn
            // 
            this.nhaptaybtn.Location = new System.Drawing.Point(118, 63);
            this.nhaptaybtn.Name = "nhaptaybtn";
            this.nhaptaybtn.Size = new System.Drawing.Size(75, 37);
            this.nhaptaybtn.TabIndex = 6;
            this.nhaptaybtn.Text = "Nhập tay";
            this.nhaptaybtn.UseVisualStyleBackColor = true;
            this.nhaptaybtn.Click += new System.EventHandler(this.nhaptaybtn_Click);
            // 
            // lbSoPhanTu
            // 
            this.lbSoPhanTu.AutoSize = true;
            this.lbSoPhanTu.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhanTu.ForeColor = System.Drawing.Color.Silver;
            this.lbSoPhanTu.Location = new System.Drawing.Point(28, 28);
            this.lbSoPhanTu.Name = "lbSoPhanTu";
            this.lbSoPhanTu.Size = new System.Drawing.Size(85, 16);
            this.lbSoPhanTu.TabIndex = 14;
            this.lbSoPhanTu.Text = "Số phần tử";
            // 
            // venutbtn
            // 
            this.venutbtn.Location = new System.Drawing.Point(216, 63);
            this.venutbtn.Name = "venutbtn";
            this.venutbtn.Size = new System.Drawing.Size(75, 37);
            this.venutbtn.TabIndex = 5;
            this.venutbtn.Text = "Vẽ nút";
            this.venutbtn.UseVisualStyleBackColor = true;
            this.venutbtn.Click += new System.EventHandler(this.venutbtn_Click);
            // 
            // taongaunhienbtn
            // 
            this.taongaunhienbtn.Location = new System.Drawing.Point(20, 63);
            this.taongaunhienbtn.Name = "taongaunhienbtn";
            this.taongaunhienbtn.Size = new System.Drawing.Size(75, 37);
            this.taongaunhienbtn.TabIndex = 7;
            this.taongaunhienbtn.Text = "Ngẫu nhiên";
            this.taongaunhienbtn.UseVisualStyleBackColor = true;
            this.taongaunhienbtn.Click += new System.EventHandler(this.taongaunhienbtn_Click);
            // 
            // huypanel
            // 
            this.huypanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.huypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.huypanel.Controls.Add(this.thoatbtn);
            this.huypanel.Controls.Add(this.xoamangbtn);
            this.huypanel.Controls.Add(this.lbHuy);
            this.huypanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huypanel.Location = new System.Drawing.Point(847, 598);
            this.huypanel.Name = "huypanel";
            this.huypanel.Size = new System.Drawing.Size(171, 52);
            this.huypanel.TabIndex = 25;
            // 
            // thoatbtn
            // 
            this.thoatbtn.Location = new System.Drawing.Point(86, 20);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(76, 23);
            this.thoatbtn.TabIndex = 14;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.thoatbtn_Click);
            // 
            // xoamangbtn
            // 
            this.xoamangbtn.Location = new System.Drawing.Point(5, 20);
            this.xoamangbtn.Name = "xoamangbtn";
            this.xoamangbtn.Size = new System.Drawing.Size(76, 23);
            this.xoamangbtn.TabIndex = 15;
            this.xoamangbtn.Text = "Xóa mảng";
            this.xoamangbtn.UseVisualStyleBackColor = true;
            this.xoamangbtn.Click += new System.EventHandler(this.xoamangbtn_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btndebug);
            this.panel10.Controls.Add(this.cboxdebug);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.ForeColor = System.Drawing.Color.DarkGray;
            this.panel10.Location = new System.Drawing.Point(304, 584);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(104, 66);
            this.panel10.TabIndex = 26;
            // 
            // btndebug
            // 
            this.btndebug.ForeColor = System.Drawing.Color.Black;
            this.btndebug.Location = new System.Drawing.Point(13, 34);
            this.btndebug.Name = "btndebug";
            this.btndebug.Size = new System.Drawing.Size(61, 23);
            this.btndebug.TabIndex = 11;
            this.btndebug.Text = "Debug";
            this.btndebug.UseVisualStyleBackColor = true;
            this.btndebug.Click += new System.EventHandler(this.btndebug_Click);
            // 
            // cboxdebug
            // 
            this.cboxdebug.AutoSize = true;
            this.cboxdebug.ForeColor = System.Drawing.Color.DarkGray;
            this.cboxdebug.Location = new System.Drawing.Point(13, 16);
            this.cboxdebug.Name = "cboxdebug";
            this.cboxdebug.Size = new System.Drawing.Size(57, 17);
            this.cboxdebug.TabIndex = 0;
            this.cboxdebug.Text = "Debug";
            this.cboxdebug.UseVisualStyleBackColor = true;
            this.cboxdebug.CheckedChanged += new System.EventHandler(this.cboxdebug_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Debug mode";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // codeListBox
            // 
            this.codeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.codeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeListBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeListBox.ForeColor = System.Drawing.Color.Silver;
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.ItemHeight = 20;
            this.codeListBox.Location = new System.Drawing.Point(3, 27);
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.ScrollAlwaysVisible = true;
            this.codeListBox.Size = new System.Drawing.Size(471, 240);
            this.codeListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code C++";
            // 
            // HienThiPanel
            // 
            this.HienThiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.HienThiPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HienThiPanel.Controls.Add(this.label2);
            this.HienThiPanel.Controls.Add(this.codeListBox);
            this.HienThiPanel.Font = new System.Drawing.Font("Centaur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HienThiPanel.Location = new System.Drawing.Point(414, 355);
            this.HienThiPanel.Name = "HienThiPanel";
            this.HienThiPanel.Size = new System.Drawing.Size(427, 295);
            this.HienThiPanel.TabIndex = 22;
            // 
            // ngonngupanel
            // 
            this.ngonngupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ngonngupanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ngonngupanel.Controls.Add(this.btnVi);
            this.ngonngupanel.Controls.Add(this.btnEn);
            this.ngonngupanel.Controls.Add(this.lbNgonNgu);
            this.ngonngupanel.Location = new System.Drawing.Point(1024, 598);
            this.ngonngupanel.Name = "ngonngupanel";
            this.ngonngupanel.Size = new System.Drawing.Size(126, 52);
            this.ngonngupanel.TabIndex = 27;
            // 
            // btnVi
            // 
            this.btnVi.BackgroundImage = global::DoAnSapXep.Properties.Resources.vnflag;
            this.btnVi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVi.Location = new System.Drawing.Point(65, 20);
            this.btnVi.Name = "btnVi";
            this.btnVi.Size = new System.Drawing.Size(33, 23);
            this.btnVi.TabIndex = 4;
            this.btnVi.UseVisualStyleBackColor = true;
            this.btnVi.Click += new System.EventHandler(this.btnVi_Click);
            // 
            // btnEn
            // 
            this.btnEn.BackgroundImage = global::DoAnSapXep.Properties.Resources.usaplag;
            this.btnEn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEn.Location = new System.Drawing.Point(27, 20);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(32, 23);
            this.btnEn.TabIndex = 3;
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // lbNgonNgu
            // 
            this.lbNgonNgu.AutoSize = true;
            this.lbNgonNgu.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgonNgu.ForeColor = System.Drawing.Color.Silver;
            this.lbNgonNgu.Location = new System.Drawing.Point(21, 4);
            this.lbNgonNgu.Name = "lbNgonNgu";
            this.lbNgonNgu.Size = new System.Drawing.Size(77, 16);
            this.lbNgonNgu.TabIndex = 0;
            this.lbNgonNgu.Text = "Ngôn Ngữ";
            // 
            // tabctlytuong
            // 
            this.tabctlytuong.Controls.Add(this.tabPage1);
            this.tabctlytuong.Controls.Add(this.tabPage2);
            this.tabctlytuong.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctlytuong.Location = new System.Drawing.Point(6, 355);
            this.tabctlytuong.Name = "tabctlytuong";
            this.tabctlytuong.SelectedIndex = 0;
            this.tabctlytuong.Size = new System.Drawing.Size(402, 157);
            this.tabctlytuong.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.tabPage1.Controls.Add(this.yTuongTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(394, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ý tưởng thuật toán";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.tabPage2.Controls.Add(this.daydangxepListbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(394, 128);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dãy đang sắp xếp";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1162, 658);
            this.Controls.Add(this.tabctlytuong);
            this.Controls.Add(this.sapxepPanel);
            this.Controls.Add(this.ngonngupanel);
            this.Controls.Add(this.Loaisapxeppanel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.thuattoanpanel);
            this.Controls.Add(this.huypanel);
            this.Controls.Add(this.khoitaopanel);
            this.Controls.Add(this.dieukhienpanel);
            this.Controls.Add(this.HienThiPanel);
            this.Controls.Add(this.chuasapxepPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM MÔ PHỎNG THUẬT TOÁN SẮP XẾP v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed_1);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.chuasapxepPanel.ResumeLayout(false);
            this.chuasapxepPanel.PerformLayout();
            this.thuattoanpanel.ResumeLayout(false);
            this.thuattoanpanel.PerformLayout();
            this.Loaisapxeppanel.ResumeLayout(false);
            this.Loaisapxeppanel.PerformLayout();
            this.dieukhienpanel.ResumeLayout(false);
            this.dieukhienpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.khoitaopanel.ResumeLayout(false);
            this.khoitaopanel.PerformLayout();
            this.huypanel.ResumeLayout(false);
            this.huypanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.HienThiPanel.ResumeLayout(false);
            this.HienThiPanel.PerformLayout();
            this.ngonngupanel.ResumeLayout(false);
            this.ngonngupanel.PerformLayout();
            this.tabctlytuong.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHuy;
        private System.Windows.Forms.Label lbKhoiTao;
        private System.Windows.Forms.Label lbDieuKhien;
        private System.Windows.Forms.Label lbThuatToan;
        private System.Windows.Forms.Label lbSapXep;
        private System.Windows.Forms.Label lbMangChuaSapXep;
        private System.Windows.Forms.Panel sapxepPanel;
        private System.Windows.Forms.Panel chuasapxepPanel;
        private System.Windows.Forms.Panel thuattoanpanel;
        private System.Windows.Forms.RadioButton interchangerdbtn;
        private System.Windows.Forms.Panel Loaisapxeppanel;
        private System.Windows.Forms.Panel dieukhienpanel;
        private System.Windows.Forms.Panel khoitaopanel;
        private System.Windows.Forms.Panel huypanel;
        private System.Windows.Forms.RadioButton insertionrdbtn;
        private System.Windows.Forms.RadioButton mergerdbtn;
        private System.Windows.Forms.RadioButton shellrdbtn;
        private System.Windows.Forms.RadioButton quickrdbtn;
        private System.Windows.Forms.RadioButton shakerrdbtn;
        private System.Windows.Forms.RadioButton selectionrdbtn;
        private System.Windows.Forms.RadioButton heaprdbtn;
        private System.Windows.Forms.RadioButton bubblerdbtn;
        private System.Windows.Forms.RadioButton binaryinsertionrdbtn;
        private System.Windows.Forms.RadioButton giamrdbtn;
        private System.Windows.Forms.RadioButton tangrdbtn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button huybnt;
        private System.Windows.Forms.Button dungbtn;
        private System.Windows.Forms.Button batdaubtn;
        private System.Windows.Forms.Label lbSoPhanTu;
        private System.Windows.Forms.Button venutbtn;
        private System.Windows.Forms.Button taongaunhienbtn;
        private System.Windows.Forms.Button thoatbtn;
        private System.Windows.Forms.Button xoamangbtn;
        private System.Windows.Forms.TextBox soluongNodetbx;
        private System.Windows.Forms.Label lbTocDo;
        private TextBox yTuongTextBox;
        private Timer timer1;
        private Label label11;
        private ListBox codeListBox;
        private Label label2;
        private Panel HienThiPanel;
        private Panel ngonngupanel;
        private Button btnVi;
        private Button btnEn;
        private Label lbNgonNgu;
        private TrackBar trackBar1;
        private Label label1;
        private ListBox daydangxepListbox;
        private Button nhaptaybtn;
        private Label label3;
        private CheckBox cboxdebug;
        private Button btnCaiDat;
        private TabControl tabctlytuong;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btndebug;
    }
}

