namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int ID { get; set; }
        [DisplayName("Tên đăng nhập")]
        [StringLength(50)]
        public string UserName { get; set; }
        [DisplayName("Mật khẩu")]
        [StringLength(32)]
        public string PassWord { get; set; }
        [DisplayName("Tên người dùng")]
        [StringLength(10)]
        public string Name { get; set; }
        [DisplayName("Địa chỉ")]
        [StringLength(10)]
        public string Address { get; set; }
        [DisplayName("Email người dùng")]
        [StringLength(10)]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        [StringLength(10)]
        public string Phone { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(250)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}
