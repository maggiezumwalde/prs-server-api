﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeSuppliesCapstone
{
    public partial class Vendor
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Code { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Address { get; set; }
        [Required]
        [StringLength(30)]
        public string City { get; set; }
        [Required]
        [StringLength(2)]
        public string State { get; set; }
        [Required]
        [StringLength(12)]
        public string Zip { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }

        public Vendor() {
        }

    }
}