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
    
    public partial class T_Users
    {
        public T_Users()
        {
            this.DaGoods = new HashSet<DaGoods>();
            this.DaGoodsTypes = new HashSet<DaGoodsType>();
            this.DaInvoices = new HashSet<DaInvoice>();
            this.DaPurchaseContracts = new HashSet<DaPurchaseContract>();
            this.DaSuppliers = new HashSet<DaSupplier>();
            this.DaSupplierContacts = new HashSet<DaSupplierContact>();
            this.DaStockIns = new HashSet<DaStockIn>();
            this.DaContractGoods = new HashSet<DaContractGood>();
            this.DaCompanies = new HashSet<DaCompany>();
            this.DaExpenses = new HashSet<DaExpense>();
            this.DaLoans1 = new HashSet<DaLoan>();
            this.DaExpenseAuditLogs = new HashSet<DaExpenseAuditLog>();
            this.DaPurchaseContractAuditLogs = new HashSet<DaPurchaseContractAuditLog>();
        }
    
        public long id { get; set; }
        public string LoginName { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
        public string OperRight { get; set; }
        public string UserChar { get; set; }
        public string DepartmentName { get; set; }
        public string UserStatus { get; set; }
        public Nullable<int> IntRoleID { get; set; }
        public Nullable<int> IntDepartmentID { get; set; }
    
        public virtual ICollection<DaGoods> DaGoods { get; set; }
        public virtual ICollection<DaGoodsType> DaGoodsTypes { get; set; }
        public virtual ICollection<DaInvoice> DaInvoices { get; set; }
        public virtual ICollection<DaPurchaseContract> DaPurchaseContracts { get; set; }
        public virtual ICollection<DaSupplier> DaSuppliers { get; set; }
        public virtual ICollection<DaSupplierContact> DaSupplierContacts { get; set; }
        public virtual ICollection<DaStockIn> DaStockIns { get; set; }
        public virtual ICollection<DaContractGood> DaContractGoods { get; set; }
        public virtual ICollection<DaCompany> DaCompanies { get; set; }
        public virtual ICollection<DaExpense> DaExpenses { get; set; }
        public virtual ICollection<DaLoan> DaLoans1 { get; set; }
        public virtual ICollection<DaExpenseAuditLog> DaExpenseAuditLogs { get; set; }
        public virtual ICollection<DaPurchaseContractAuditLog> DaPurchaseContractAuditLogs { get; set; }
    }
}
