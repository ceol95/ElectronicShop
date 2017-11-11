using System;
using System.ComponentModel.DataAnnotations;

namespace Model.EF
{

    [MetadataTypeAttribute(typeof(Bill))]
    public partial class Bill
    {
        internal sealed class BillMetadata
        {
            [Display(Name = "")]
            public int idBill { get; set; }

            [Display(Name = "")]
            public Nullable<System.DateTime> createDate { get; set; }

            [Display(Name = "")]
            public Nullable<int> status { get; set; }

            [Display(Name = "")]
            public Nullable<int> idCustomer { get; set; }

            [Display(Name = "")]
            public Nullable<int> idShipper { get; set; }

            [Display(Name = "")]
            public Nullable<decimal> totalMoney { get; set; }

            [Display(Name = "")]
            public Nullable<System.DateTime> finishDate { get; set; }

            [Display(Name = "")]
            public Nullable<decimal> promotionCustomer { get; set; }

            [Display(Name = "")]
            public Nullable<decimal> feeShip { get; set; }
        }
    }
}


