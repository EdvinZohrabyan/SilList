﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SO.SilList.Manager.Models.ValueObjects
{
     
    [Table("Site", Schema = "app" )]
    [Serializable]
    public partial class SiteVo
    {
    		
    	[DisplayName("site Id")]
    	[Key]
        public int siteId { get; set; }
    		
    	[DisplayName("name")]
    	[StringLength(250)]
        public string name { get; set; }
    		
    	[DisplayName("domain")]
    	[StringLength(250)]
        public string domain { get; set; }

        [DisplayName("description")]
        public string description { get; set; }

        [DisplayName("logo")]
        [StringLength(250)]
        public string logo { get; set; }

        [DisplayName("logo Url")]
        public string logoUrl { get; set; }

        [DisplayName("created")]
        [Required]
        public System.DateTime created { get; set; }

        [DisplayName("modified")]
        [Required]
        public System.DateTime modified { get; set; }

        [DisplayName("created By")]
        public Nullable<int> createdBy { get; set; }

        [DisplayName("modified By")]
        public Nullable<int> modifiedBy { get; set; }

        [DisplayName("is Active")]
        public Nullable<bool> isActive { get; set; }

        //[Association("Site_Business", "siteId", "siteId", IsForeignKey = true)]
        //public List<BusinessVo> businesses { get; set; }
        
        //[Association("Site_Car", "siteId", "siteId", IsForeignKey = true)]
        //public List<CarVo> car { get; set; }

        //[Association("Site_Member", "siteId", "siteId", IsForeignKey = true)]
        //public List<MemberVo> member { get; set; }
    }
}
