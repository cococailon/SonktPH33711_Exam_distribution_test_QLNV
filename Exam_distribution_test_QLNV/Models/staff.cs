using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam_distribution_test_QLNV.Models
{
    public partial class staff
    {
        public staff()
        {
            DepartmentFacilities = new HashSet<DepartmentFacility>();
            StaffMajorFacilities = new HashSet<StaffMajorFacility>();
        }

        public byte? Status { get; set; }
        public long? CreatedDate { get; set; }
        public long? LastModifiedDate { get; set; }
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Email FE không được để trống")]
        [RegularExpression(@"^[a-zA-Z0-9._\-+]+@fe\.edu\.vn$",
        ErrorMessage = "Email FE phải kết thúc bằng @fe.edu.vn, không chứa khoảng trắng và không chứa ký tự tiếng Việt có dấu.")]
        [StringLength(100, ErrorMessage = "Email FE không được quá 100 ký tự")]
        public string? AccountFe { get; set; }

        [Required(ErrorMessage = "Email FPT không được để trống")]
        [StringLength(100, ErrorMessage = "Email FPT không được quá 100 ký tự")]
        [RegularExpression(@"^[a-zA-Z0-9._\-+]+@fpt\.edu\.vn$",
        ErrorMessage = "Email FPT phải kết thúc bằng @fpt.edu.vn, không chứa khoảng trắng và không chứa ký tự tiếng Việt có dấu.")]
        public string? AccountFpt { get; set; }

        [Required(ErrorMessage = "Tên nhân viên là bắt buộc")]
        [StringLength(100, ErrorMessage = "Tên nhân viên không được quá 100 ký tự")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Mã nhân viên là bắt buộc")]
        [StringLength(15, ErrorMessage = "Mã nhân viên không được quá 15 ký tự")]
        public string? StaffCode { get; set; }

        public virtual ICollection<DepartmentFacility> DepartmentFacilities { get; set; }
        public virtual ICollection<StaffMajorFacility> StaffMajorFacilities { get; set; }
    }
}
