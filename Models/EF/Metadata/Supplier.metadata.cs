using System;
using System.ComponentModel.DataAnnotations;

namespace Model.EF
{

    [MetadataTypeAttribute(typeof(Supplier))]
    public partial class Supplier
    {
        internal sealed class SupplierMetadata
        {
            [Display(Name = "Mã")]
            public int idSupplier { get; set; }

            [Display(Name = "Tên")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string name { get; set; }

            [Display(Name = "Địa chỉ")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string location { get; set; }

            [Display(Name = "Miêu tả")]
            public string description { get; set; }

            [Display(Name = "Điện thoại")]
            [RegularExpression(@"^0([0-9]{9,10})$", ErrorMessage = "Điện thoại không đúng định dạng.")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string phone { get; set; }

            [Display(Name = "Mã số thuế")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string codeTax { get; set; }

            [Display(Name = "Email")]
            [EmailAddress(ErrorMessage = "Email không chính xác.")]
            public string email { get; set; }
        }
    }
}





