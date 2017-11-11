using System;
using System.ComponentModel.DataAnnotations;

namespace Model.EF
{
    
    [MetadataTypeAttribute(typeof(Category))]
    public partial class Category
    {
        internal sealed class CategoryMetadata
        {
            [Display(Name = "Mã")]
            public int idCategory { get; set; }

            [Display(Name = "Tên")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string name { get; set; }

            [Display(Name = "Miêu tả")]
            public string description { get; set; }
        }
    }
}
