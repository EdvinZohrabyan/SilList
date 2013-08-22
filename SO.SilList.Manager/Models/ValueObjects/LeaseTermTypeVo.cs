
using System;
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
     
    [Table("LeaseTermType", Schema = "app" )]
    [Serializable]
    public partial class LeaseTermTypeVo
    {
    		
    	[DisplayName("lease Term Type Id")]
    	[Key]
        public int leaseTermTypeId { get; set; }
    		
    	[DisplayName("name")]
    	[StringLength(50)]
        public string name { get; set; }
    		
    	[DisplayName("description")]
        public string description { get; set; }
    		
    	[DisplayName("modified By")]
        public Nullable<int> modifiedBy { get; set; }
    		
    	[DisplayName("modified")]
    	[Required]
        public System.DateTime modified { get; set; }
    		
    	[DisplayName("created By")]
        public Nullable<int> createdBy { get; set; }
    		
    	[DisplayName("created")]
    	[Required]
        public System.DateTime created { get; set; }
    		
    	[DisplayName("is Active")]
    	[Required]
        public bool isActive { get; set; }

        [Association("LeaseTermType_Rental", "leaseTermTypeId", "leaseTermTypeId", IsForeignKey = true)]
        public List<RentalVo> rental { get; set; }
      
    	public LeaseTermTypeVo(){
    			this.isActive = true;
    	}
    }
}
