using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace DoAnSapXep
{
    public partial class frmInput : Form
    {

        public frmInput()
        {
            InitializeComponent();
            if (Mainform.isEnglish == true)
            {
                setLang("en-US");
            }
            else
                setLang("vi-VN");
            textBox2.Text = ThamSo.SoluongNodeLonNhat.ToString();
        }
        //public string DayInput;
        public List<int> DayInput;
        public bool isNhap;


        CultureInfo culture;
        private void setLang(string cultureName)
        {
            culture = new CultureInfo(cultureName);
            ResourceManager rm = new ResourceManager("DoAnSapXep.Lang.myResource", typeof(Mainform).Assembly);
            lbNhapMotDay.Text = rm.GetString("nhapmotday", culture);
            lbDaySo.Text = rm.GetString("dayso", culture);
            lbSoNodeToiDa.Text = rm.GetString("sonodetoida", culture);
            lb1.Text = rm.GetString("lb1", culture);
            lb2.Text = rm.GetString("lb2", culture);
            btnhuy.Text = rm.GetString("huy", culture);
        }
        //xong
        // m xem cái slide chỉnh lại đi , t làm cái báo cáo

        private void frmInput_Load(object sender, EventArgs e)
        {

            DayInput = new List<int>();
            isNhap = false;

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            // xoa day cũ nếu đã tạo ở phiên trước
            DayInput.Clear();
            foreach (string item in tbxdayso.Text.Split(' '))
            {
                if (item==" ")
                {
                }
                else
                {
                    int temp = 10;
                    bool result = int.TryParse(item, out temp);
                    if (result == true && (temp < 0 || temp > 99))
                    {
                        MessageBox.Show("Phần tử có giá trị nhỏ hơn 0 hoặc lớn hơn 99");
                        return;
                    }
                    if (result == true)
                    {
                        DayInput.Add(temp);
                    }
                }
             
            }

            if (DayInput.Count>ThamSo.SoluongNodeLonNhat)
            {
                MessageBox.Show("Dãy vừa nhập vượt quá "+ThamSo.SoluongNodeLonNhat);
                return;
            }
            if (DayInput==null)
            {
                MessageBox.Show("Dãy nhập rỗng");
                return;
            }
            isNhap = true;
            this.Close();
        }
       
        private void tbxdayso_KeyPress(object sender, KeyPressEventArgs e)
        {

          
            // chặn người dùng nhập chữ nhưng cho phép nhập backspace để xóa
            if (e.KeyChar != '\b' && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
            //if (char.IsWhiteSpace(e.KeyChar))
            //{
               
            //    if (countspace > 1)
            //    {
            //        e.Handled = true;
            //        countspace = 0;
            //    }
            //    countspace++;
            //}
         

        }
    }
}
