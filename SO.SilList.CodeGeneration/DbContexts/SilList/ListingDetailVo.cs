
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

namespace SO.SilList.CodeGeneration.DbContexts.SilList
{
     
    [Table("ListingDetail", Schema = "dbo" )]
    [Serializable]
    public partial class ListingDetailVo
    {
    		
    	[DisplayName("listing Detail Id")]
    	[Required]
        public System.Guid listingDetailId { get; set; }
    		
    	[DisplayName("start Date")]
    	[Required]
        public System.DateTime startDate { get; set; }
    		
    	[DisplayName("end Date")]
    	[Required]
        public System.DateTime endDate { get; set; }
    		
    	[DisplayName("is Approved")]
        public Nullable<bool> isApproved { get; set; }
    		
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
      
    	public ListingDetailVo(){
    			
    		this.listingDetailId = Guid.NewGuid();
    	
    	 //this.isActive = true;
    	}
    }
}