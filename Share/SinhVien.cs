﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    public class SinhVien
    {
        [Key] 
        public  int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public int Age {  get; set; }
    }
}
