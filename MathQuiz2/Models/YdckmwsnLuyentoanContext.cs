using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MathQuiz2.Models;

public partial class YdckmwsnLuyentoanContext : DbContext
{
    public YdckmwsnLuyentoanContext()
    {
    }

    public YdckmwsnLuyentoanContext(DbContextOptions<YdckmwsnLuyentoanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Answer> Answers { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Chapter> Chapters { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ComponentChapter> ComponentChapters { get; set; }

    public virtual DbSet<ConfirmEmail> ConfirmEmails { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<ExamDetail> ExamDetails { get; set; }

    public virtual DbSet<ExamMatrix> ExamMatrices { get; set; }

    public virtual DbSet<ExamMatrixDetail> ExamMatrixDetails { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupDetail> GroupDetails { get; set; }

    public virtual DbSet<GroupExam> GroupExams { get; set; }

    public virtual DbSet<HubConnection> HubConnections { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<ShuffleAnswerViewModel> ShuffleAnswerViewModels { get; set; }

    public virtual DbSet<UserExam> UserExams { get; set; }

    public virtual DbSet<UserExamDetail> UserExamDetails { get; set; }

    public virtual DbSet<UserStatistic> UserStatistics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=125.212.218.93\\MSSQLSERVER2017;Initial Catalog=ydckmwsn_luyentoan;User ID=ydckmwsn_luyentoansa;Password=luyentoan@1234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("ydckmwsn_luyentoansa");

        modelBuilder.Entity<Answer>(entity =>
        {
            entity.ToTable("Answer");

            entity.HasIndex(e => e.QuestionId, "IX_Answer_QuestionId");

            entity.HasIndex(e => e.UserIdCreate, "IX_Answer_UserIdCreate");

            entity.HasIndex(e => e.UserIdRemove, "IX_Answer_UserIdRemove");

            entity.HasIndex(e => e.UserIdUpdate, "IX_Answer_UserIdUpdate");

            entity.HasOne(d => d.Question).WithMany(p => p.Answers).HasForeignKey(d => d.QuestionId);

            entity.HasOne(d => d.UserIdCreateNavigation).WithMany(p => p.AnswerUserIdCreateNavigations).HasForeignKey(d => d.UserIdCreate);

            entity.HasOne(d => d.UserIdRemoveNavigation).WithMany(p => p.AnswerUserIdRemoveNavigations).HasForeignKey(d => d.UserIdRemove);

            entity.HasOne(d => d.UserIdUpdateNavigation).WithMany(p => p.AnswerUserIdUpdateNavigations).HasForeignKey(d => d.UserIdUpdate);
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.AvatarId, "IX_AspNetUsers_AvatarId");

            entity.HasIndex(e => e.BackgroundId, "IX_AspNetUsers_BackgroundId");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Roletype).HasColumnName("roletype");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Avatar).WithMany(p => p.AspNetUserAvatars).HasForeignKey(d => d.AvatarId);

            entity.HasOne(d => d.Background).WithMany(p => p.AspNetUserBackgrounds).HasForeignKey(d => d.BackgroundId);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Chapter>(entity =>
        {
            entity.ToTable("Chapter");

            entity.HasIndex(e => e.ClassId, "IX_Chapter_ClassId");

            entity.HasIndex(e => e.UserIdCreate, "IX_Chapter_UserIdCreate");

            entity.HasIndex(e => e.UserIdRemove, "IX_Chapter_UserIdRemove");

            entity.HasIndex(e => e.UserIdUpdate, "IX_Chapter_UserIdUpdate");

            entity.HasOne(d => d.Class).WithMany(p => p.Chapters).HasForeignKey(d => d.ClassId);

            entity.HasOne(d => d.UserIdCreateNavigation).WithMany(p => p.ChapterUserIdCreateNavigations).HasForeignKey(d => d.UserIdCreate);

            entity.HasOne(d => d.UserIdRemoveNavigation).WithMany(p => p.ChapterUserIdRemoveNavigations).HasForeignKey(d => d.UserIdRemove);

            entity.HasOne(d => d.UserIdUpdateNavigation).WithMany(p => p.ChapterUserIdUpdateNavigations).HasForeignKey(d => d.UserIdUpdate);
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.ToTable("Class");

            entity.HasIndex(e => e.UserIdCreate, "IX_Class_UserIdCreate");

            entity.HasIndex(e => e.UserIdRemove, "IX_Class_UserIdRemove");

            entity.HasIndex(e => e.UserIdUpdate, "IX_Class_UserIdUpdate");

            entity.HasOne(d => d.UserIdCreateNavigation).WithMany(p => p.ClassUserIdCreateNavigations).HasForeignKey(d => d.UserIdCreate);

            entity.HasOne(d => d.UserIdRemoveNavigation).WithMany(p => p.ClassUserIdRemoveNavigations).HasForeignKey(d => d.UserIdRemove);

            entity.HasOne(d => d.UserIdUpdateNavigation).WithMany(p => p.ClassUserIdUpdateNavigations).HasForeignKey(d => d.UserIdUpdate);
        });

        modelBuilder.Entity<ComponentChapter>(entity =>
        {
            entity.ToTable("ComponentChapter");

            entity.HasIndex(e => e.ChapterId, "IX_ComponentChapter_ChapterId");

            entity.HasIndex(e => e.UserIdCreate, "IX_ComponentChapter_UserIdCreate");

            entity.HasIndex(e => e.UserIdRemove, "IX_ComponentChapter_UserIdRemove");

            entity.HasIndex(e => e.UserIdUpdate, "IX_ComponentChapter_UserIdUpdate");

            entity.HasOne(d => d.Chapter).WithMany(p => p.ComponentChapters).HasForeignKey(d => d.ChapterId);

            entity.HasOne(d => d.UserIdCreateNavigation).WithMany(p => p.ComponentChapterUserIdCreateNavigations).HasForeignKey(d => d.UserIdCreate);

            entity.HasOne(d => d.UserIdRemoveNavigation).WithMany(p => p.ComponentChapterUserIdRemoveNavigations).HasForeignKey(d => d.UserIdRemove);

            entity.HasOne(d => d.UserIdUpdateNavigation).WithMany(p => p.ComponentChapterUserIdUpdateNavigations).HasForeignKey(d => d.UserIdUpdate);
        });

        modelBuilder.Entity<ConfirmEmail>(entity =>
        {
            entity.ToTable("ConfirmEmail");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.ToTable("Exam");

            entity.HasIndex(e => e.UserIdCreate, "IX_Exam_UserIdCreate");

            entity.HasIndex(e => e.UserIdRemove, "IX_Exam_UserIdRemove");

            entity.HasIndex(e => e.UserIdUpdate, "IX_Exam_UserIdUpdate");

            entity.HasOne(d => d.UserIdCreateNavigation).WithMany(p => p.ExamUserIdCreateNavigations).HasForeignKey(d => d.UserIdCreate);

            entity.HasOne(d => d.UserIdRemoveNavigation).WithMany(p => p.ExamUserIdRemoveNavigations).HasForeignKey(d => d.UserIdRemove);

            entity.HasOne(d => d.UserIdUpdateNavigation).WithMany(p => p.ExamUserIdUpdateNavigations).HasForeignKey(d => d.UserIdUpdate);
        });

        modelBuilder.Entity<ExamDetail>(entity =>
        {
            entity.ToTable("ExamDetail");

            entity.HasIndex(e => e.ExamId, "IX_ExamDetail_ExamId");

            entity.HasIndex(e => e.QuestionId, "IX_ExamDetail_QuestionId");

            entity.HasOne(d => d.Exam).WithMany(p => p.ExamDetails).HasForeignKey(d => d.ExamId);

            entity.HasOne(d => d.Question).WithMany(p => p.ExamDetails).HasForeignKey(d => d.QuestionId);
        });

        modelBuilder.Entity<ExamMatrix>(entity =>
        {
            entity.HasIndex(e => e.UserIdCreate, "IX_ExamMatrices_UserIdCreate");

            entity.HasIndex(e => e.UserIdUpdate, "IX_ExamMatrices_UserIdUpdate");

            entity.HasIndex(e => e.UserRemoveId, "IX_ExamMatrices_UserRemoveId");

            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.UserIdCreateNavigation).WithMany(p => p.ExamMatrixUserIdCreateNavigations).HasForeignKey(d => d.UserIdCreate);

            entity.HasOne(d => d.UserIdUpdateNavigation).WithMany(p => p.ExamMatrixUserIdUpdateNavigations).HasForeignKey(d => d.UserIdUpdate);

            entity.HasOne(d => d.UserRemove).WithMany(p => p.ExamMatrixUserRemoves).HasForeignKey(d => d.UserRemoveId);
        });

        modelBuilder.Entity<ExamMatrixDetail>(entity =>
        {
            entity.HasIndex(e => e.ChappterId, "IX_ExamMatrixDetails_ChappterId");

            entity.HasIndex(e => e.ComponentChapterId, "IX_ExamMatrixDetails_ComponentChapterId");

            entity.HasIndex(e => e.ExamMatrixId, "IX_ExamMatrixDetails_ExamMatrixId");

            entity.HasOne(d => d.Chappter).WithMany(p => p.ExamMatrixDetails).HasForeignKey(d => d.ChappterId);

            entity.HasOne(d => d.ComponentChapter).WithMany(p => p.ExamMatrixDetails)
                .HasForeignKey(d => d.ComponentChapterId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ExamMatrix).WithMany(p => p.ExamMatrixDetails).HasForeignKey(d => d.ExamMatrixId);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable("Group");

            entity.HasIndex(e => e.UserIdLeader, "IX_Group_UserIdLeader");

            entity.HasIndex(e => e.UserIdRemove, "IX_Group_UserIdRemove");

            entity.HasIndex(e => e.UserIdUpdate, "IX_Group_UserIdUpdate");

            entity.HasOne(d => d.UserIdLeaderNavigation).WithMany(p => p.GroupUserIdLeaderNavigations).HasForeignKey(d => d.UserIdLeader);

            entity.HasOne(d => d.UserIdRemoveNavigation).WithMany(p => p.GroupUserIdRemoveNavigations).HasForeignKey(d => d.UserIdRemove);

            entity.HasOne(d => d.UserIdUpdateNavigation).WithMany(p => p.GroupUserIdUpdateNavigations).HasForeignKey(d => d.UserIdUpdate);
        });

        modelBuilder.Entity<GroupDetail>(entity =>
        {
            entity.ToTable("GroupDetail");

            entity.HasIndex(e => e.GroupId, "IX_GroupDetail_GroupId");

            entity.HasIndex(e => e.UserId, "IX_GroupDetail_UserId");

            entity.Property(e => e.IsLeader)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupDetails).HasForeignKey(d => d.GroupId);

            entity.HasOne(d => d.User).WithMany(p => p.GroupDetails).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<GroupExam>(entity =>
        {
            entity.ToTable("GroupExam");

            entity.HasIndex(e => e.ExamId, "IX_GroupExam_ExamId");

            entity.HasIndex(e => e.GroupId, "IX_GroupExam_GroupId");

            entity.HasOne(d => d.Exam).WithMany(p => p.GroupExams).HasForeignKey(d => d.ExamId);

            entity.HasOne(d => d.Group).WithMany(p => p.GroupExams).HasForeignKey(d => d.GroupId);
        });

        modelBuilder.Entity<HubConnection>(entity =>
        {
            entity.ToTable("HubConnection");

            entity.HasIndex(e => e.UserId, "IX_HubConnection_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.HubConnections).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Notifications_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.ToTable("Question");

            entity.HasIndex(e => e.ChappterId, "IX_Question_ChappterId");

            entity.HasIndex(e => e.ComponentChapterId, "IX_Question_ComponentChapterId");

            entity.HasIndex(e => e.UserIdCreate, "IX_Question_UserIdCreate");

            entity.HasIndex(e => e.UserIdRemove, "IX_Question_UserIdRemove");

            entity.HasIndex(e => e.UserIdUpdate, "IX_Question_UserIdUpdate");

            entity.HasOne(d => d.Chappter).WithMany(p => p.Questions).HasForeignKey(d => d.ChappterId);

            entity.HasOne(d => d.ComponentChapter).WithMany(p => p.Questions)
                .HasForeignKey(d => d.ComponentChapterId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UserIdCreateNavigation).WithMany(p => p.QuestionUserIdCreateNavigations).HasForeignKey(d => d.UserIdCreate);

            entity.HasOne(d => d.UserIdRemoveNavigation).WithMany(p => p.QuestionUserIdRemoveNavigations).HasForeignKey(d => d.UserIdRemove);

            entity.HasOne(d => d.UserIdUpdateNavigation).WithMany(p => p.QuestionUserIdUpdateNavigations).HasForeignKey(d => d.UserIdUpdate);
        });

        modelBuilder.Entity<ShuffleAnswerViewModel>(entity =>
        {
            entity.ToTable("ShuffleAnswerViewModel");

            entity.HasIndex(e => e.UserExamDetailId, "IX_ShuffleAnswerViewModel_UserExamDetailId");

            entity.HasOne(d => d.UserExamDetail).WithMany(p => p.ShuffleAnswerViewModels).HasForeignKey(d => d.UserExamDetailId);
        });

        modelBuilder.Entity<UserExam>(entity =>
        {
            entity.ToTable("UserExam");

            entity.HasIndex(e => e.ExamId, "IX_UserExam_ExamId");

            entity.HasIndex(e => e.UserId, "IX_UserExam_UserId");

            entity.HasOne(d => d.Exam).WithMany(p => p.UserExams).HasForeignKey(d => d.ExamId);

            entity.HasOne(d => d.User).WithMany(p => p.UserExams).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserExamDetail>(entity =>
        {
            entity.ToTable("UserExamDetail");

            entity.HasIndex(e => e.QuestionId, "IX_UserExamDetail_QuestionId");

            entity.HasIndex(e => e.SelectAnswer, "IX_UserExamDetail_SelectAnswer");

            entity.HasIndex(e => e.UserExamId, "IX_UserExamDetail_UserExamId");

            entity.HasOne(d => d.Question).WithMany(p => p.UserExamDetails).HasForeignKey(d => d.QuestionId);

            entity.HasOne(d => d.SelectAnswerNavigation).WithMany(p => p.UserExamDetails).HasForeignKey(d => d.SelectAnswer);

            entity.HasOne(d => d.UserExam).WithMany(p => p.UserExamDetails).HasForeignKey(d => d.UserExamId);
        });

        modelBuilder.Entity<UserStatistic>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_UserStatistics_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.UserStatistics).HasForeignKey(d => d.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
