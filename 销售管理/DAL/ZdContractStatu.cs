//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 销售管理.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZdContractStatu
    {
        public ZdContractStatu()
        {
            this.DaPurchaseContracts = new HashSet<DaPurchaseContract>();
            this.DaPurchaseContractAuditLogs = new HashSet<DaPurchaseContractAuditLog>();
        }
    
        public int ID { get; set; }
        public string VcDesc { get; set; }
    
        public virtual ICollection<DaPurchaseContract> DaPurchaseContracts { get; set; }
        public virtual ICollection<DaPurchaseContractAuditLog> DaPurchaseContractAuditLogs { get; set; }
    }
}
