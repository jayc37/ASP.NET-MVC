namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        public long ID { get; set; }

        [StringLength(250)]
        [DisplayName("Tên sách")]
        public string Name { get; set; }
        [DisplayName("Mã sách")]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }
        [DisplayName("Mô tả")]
        [StringLength(250)]
        public string Description { get; set; }
        [DisplayName("Hình ảnh hiển thị")]
        [StringLength(250)]
        [DataType(DataType.Upload)]
        [Required(ErrorMessage = "Chọn ảnh cần upload")]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        [DisplayName("Những hình ảnh liên quan")]
        public string MoreImages { get; set; }
        [DisplayName("Giá bán")]
        public decimal? Price { get; set; }
        [DisplayName("Giá ưu đãi")]
        public decimal? PromotionPrice { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
      
        [Column(TypeName = "ntext")]
        [DisplayName("Mô tả chi tiết")]
        public string Detail { get; set; }
        public DateTime? CreatedDate { get; set; }
        [DisplayName("tạo bởi")]
        [StringLength(250)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }  
        public bool? Status { get; set; }
        [DisplayName("hot hiện hành (số tăng dần mô tả ưu tiên giảm dần)")]
        public DateTime? TopHot { get; set; }

        public int? ViewCount { get; set; }
    }
}
