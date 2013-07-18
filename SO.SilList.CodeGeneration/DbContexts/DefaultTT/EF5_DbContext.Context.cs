﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LocalClubEntities : DbContext
    {
        public LocalClubEntities()
            : base("name=LocalClubEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Admin> Admins { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ClubCategoryType> ClubCategoryTypes { get; set; }
        public DbSet<ClubMemberRoleType> ClubMemberRoleTypes { get; set; }
        public DbSet<ZipCode> ZipCodes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEventMember> ClubEventMembers { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }
        public DbSet<ClubMember> ClubMembers { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<DiscussionMessage> DiscussionMessages { get; set; }
        public DbSet<MemberFileLink> MemberFileLinks { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
