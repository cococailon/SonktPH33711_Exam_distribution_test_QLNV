﻿using System;
using System.Collections.Generic;

namespace Exam_distribution_test_QLNV.Models
{
    public partial class Major
    {
        public Major()
        {
            MajorFacilities = new HashSet<MajorFacility>();
        }

        public byte? Status { get; set; }
        public long? CreatedDate { get; set; }
        public long? LastModifiedDate { get; set; }
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }

        public virtual ICollection<MajorFacility> MajorFacilities { get; set; }
    }
}
