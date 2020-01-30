using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DoAnSapXep
{
    public partial class    Node : UserControl
    {
        public Node(int vitrihientai)
        {
            InitializeComponent();
            DatGiaTriMatDinh();
            this.vitriHienTai = vitrihientai;

        }
        private void DatGiaTriMatDinh()
        {
            this.Width = this.Height = btn1.Width = btn1.Height = tbx1.Width = tbx1.Height = ThamSo.KichCoNode;
            tbx1.Location = this.Location;// neu 1 trong 3 thay doi vi tri thi tat ca deu thay doi theo
            btn1.Location = this.Location;
            tbx1.TextAlign = HorizontalAlignment.Center;
            this.Size = new Size(ThamSo.KichCoNode, ThamSo.KichCoNode);
            this.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            btn1.BackColor = Color.Red;
            tbx1.BackColor = Color.White;
            tbx1.MaxLength = 2;// chi nhap toi da la 99
            tbx1.AcceptsReturn = true;
            btn1.Font =tbx1.Font= new Font("Consolas", ThamSo.KichCoNode /4, FontStyle.Bold);
            //this.LostFocus += Node_LostFocus;
            tbx1.LostFocus += Tbx1_LostFocus;
        }

        private void Tbx1_LostFocus(object sender, EventArgs e)
        {
            if (tbx1.Text=="")
            {
                tbx1.Text = "0";
            }
            else
            {
                this.Text = tbx1.Text;
                this.Value = Int32.Parse(this.Text);
            }
            btn1.Visible = true;
            btn1.BringToFront();
            btn1.Focus();
            if (Capnhat != null)
            {
                Capnhat(sender, e);
            }
        }



        private int value;
       //public static ManualResetEvent pauseStatus = new ManualResetEvent(true);
        public static bool IsPause = false;
        public event EventHandler Capnhat;
        public override string Text
        {
            get
            {
                return btn1.Text;
            }

            set
            {

                btn1.Text = value.ToString();
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public int vitriHienTai;

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                btn1.Visible = false;
                tbx1.Text = btn1.Text;
                tbx1.SelectionStart = tbx1.Text.Length;// dat con tro chuot "cusor" qua ben phai neu so da co
                tbx1.BringToFront();
                tbx1.Focus();
              
            }
        }

        private void tbx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbx1_Enter(object sender, EventArgs e)
        {
            if (tbx1.Text!=null)
            {
                btn1.Text = tbx1.Text;
            }
        }

        private void tbx1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                
                btn1.Visible = true;
                btn1.BringToFront();
                btn1.Focus();
            }

        }

        private void tbx1_TextChanged(object sender, EventArgs e)
        {
         
            //if (tbx1.Text != "")
            //{
            //    //  value = Int32.Parse(tbx1.Text);
              
            
          
        
        }
        /// <summary>
        /// Các hàm di chuyển node;
        /// </summary>
        /// <param name="Node"></param>
        public static System.Threading.ManualResetEvent pauseStatus = new System.Threading.ManualResetEvent(true);
        public void ChuyenLen() 
        {
            int y_ViTriMoi = this.Location.Y - ThamSo.DoCaoDiChuyen;
            while (this.Location.Y > y_ViTriMoi)
            {
                pauseStatus.WaitOne(Timeout.Infinite);
                this.Location = new Point(this.Location.X, this.Location.Y - 1);
                Thread.Sleep(ThamSo.ThoiGianDoi);
            }   

        }
        public void ChuyenXuong()
        {
            int y_ViTriMoi = this.Location.Y+ ThamSo.DoCaoDiChuyen;
            while (this.Location.Y < y_ViTriMoi)
            {
                pauseStatus.WaitOne(Timeout.Infinite);
                this.Location = new Point(this.Location.X, this.Location.Y + 1);
                Thread.Sleep(ThamSo.ThoiGianDoi);
            }



        }
        public void ChuyenNgang(int vitriMoi)
        {
            int x_vitririMoi;
            if (vitriMoi > this.vitriHienTai)
            {
                x_vitririMoi = this.Location.X + ((vitriMoi - vitriHienTai) * (ThamSo.KhoangCachCacNode+ThamSo.KichCoNode));
                while (this.Location.X < x_vitririMoi)
                {
                    pauseStatus.WaitOne(Timeout.Infinite);
                    Thread.Sleep(ThamSo.ThoiGianDoi);
                    this.Location = new Point(this.Location.X + 2, this.Location.Y);
                }
            }
            else
            {
                x_vitririMoi = this.Location.X - ((vitriHienTai - vitriMoi) * (ThamSo.KhoangCachCacNode+ThamSo.KichCoNode));
                while (this.Location.X > x_vitririMoi)
                {
                    pauseStatus.WaitOne(Timeout.Infinite);
                    Thread.Sleep(ThamSo.ThoiGianDoi);
                    this.Location = new Point(this.Location.X - 2, this.Location.Y);
                }
            }
        }
        private void TbxBtn_BackColorChanged(object sender, EventArgs e)
        {
            btn1.BackColor = this.BackColor;
        }

        private void TbxBtn_Load(object sender, EventArgs e)
        {
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
