//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SO.LocalClub.CodeGeneration.Model.DefaultTT
{
    using System;
    using System.Collections.Generic;
    
    public partial class Club
    {
        public Club()
        {
            this.ClubEvents = new HashSet<ClubEvent>();
            this.ClubMembers = new HashSet<ClubMember>();
            this.Discussions = new HashSet<Discussion>();
        }
    
        public System.Guid clubId { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public Nullable<int> cityId { get; set; }
        public Nullable<int> clubCategoryTypeId { get; set; }
        public System.DateTime modified { get; set; }
        public System.DateTime created { get; set; }
    
        public virtual City City { get; set; }
        public virtual ClubCategoryType ClubCategoryType { get; set; }
        public virtual ICollection<ClubEvent> ClubEvents { get; set; }
        public virtual ICollection<ClubMember> ClubMembers { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
    }
}