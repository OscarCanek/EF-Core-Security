﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFCoreSecurityODataService.Models {
    public class ContactTask {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ContactId")]
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
        [ForeignKey("TaskId")]
        public int TaskId { get; set; }
        public virtual DemoTask Task { get; set; }
    }
}