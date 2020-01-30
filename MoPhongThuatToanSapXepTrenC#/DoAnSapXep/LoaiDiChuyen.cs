using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAnSapXep
{ 
        public enum LoaiDiChuyen
        {
            Di_LEN_DI_XUONG,QUA_PHAI_QUA_TRAI,DI_XUONG_DI_LEN,DUNG
        }
        public class status
        {
            public LoaiDiChuyen Type { get; set; }
            public int vt1 { get; set; }
            public int vt2 { get; set; }
        }
    
}
