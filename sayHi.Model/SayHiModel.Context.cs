﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace sayHi.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sayHiEntities : DbContext
    {
        public sayHiEntities()
            : base("name=sayHiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sayhi_AdminInfo> sayhi_AdminInfo { get; set; }
        public virtual DbSet<sayHi_BookInfo> sayHi_BookInfo { get; set; }
        public virtual DbSet<sayHi_BookInfo_Chapter> sayHi_BookInfo_Chapter { get; set; }
        public virtual DbSet<sayHi_BookInfo_CharacterDesign> sayHi_BookInfo_CharacterDesign { get; set; }
        public virtual DbSet<sayHi_CharacterDesign> sayHi_CharacterDesign { get; set; }
        public virtual DbSet<sayhi_LikesInfo> sayhi_LikesInfo { get; set; }
        public virtual DbSet<sayHi_MangaInfo> sayHi_MangaInfo { get; set; }
        public virtual DbSet<sayhi_MangaInfo_Chapter> sayhi_MangaInfo_Chapter { get; set; }
        public virtual DbSet<sayhi_MangaInfo_CharacterDesign> sayhi_MangaInfo_CharacterDesign { get; set; }
        public virtual DbSet<sayhi_NoticeInfo> sayhi_NoticeInfo { get; set; }
        public virtual DbSet<sayhi_ParoInfo> sayhi_ParoInfo { get; set; }
        public virtual DbSet<sayhi_ParoInfo_ParticipateInWorks> sayhi_ParoInfo_ParticipateInWorks { get; set; }
        public virtual DbSet<sayhi_PlanningInfo> sayhi_PlanningInfo { get; set; }
        public virtual DbSet<sayhi_PlanningInfo_Chapter> sayhi_PlanningInfo_Chapter { get; set; }
        public virtual DbSet<sayhi_PlanningInfo_ParticipateIn> sayhi_PlanningInfo_ParticipateIn { get; set; }
        public virtual DbSet<sayhi_PlanningInfo_ParticipateInContent> sayhi_PlanningInfo_ParticipateInContent { get; set; }
        public virtual DbSet<sayHi_UserInfo> sayHi_UserInfo { get; set; }
        public virtual DbSet<sayHi_UserInfo_CIF> sayHi_UserInfo_CIF { get; set; }
        public virtual DbSet<sayHi_UserInfo_Honor> sayHi_UserInfo_Honor { get; set; }
        public virtual DbSet<sayHi_UserInfo_Power> sayHi_UserInfo_Power { get; set; }
        public virtual DbSet<sayHi_UserInfo_UID> sayHi_UserInfo_UID { get; set; }
    }
}
