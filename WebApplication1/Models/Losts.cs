//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Losts
    {
        public string LostID { get; set; }
        public string DepotID { get; set; }
        public Nullable<System.DateTime> LostDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public string LostDesc { get; set; }
        public Nullable<int> LostState { get; set; }
    }
}
