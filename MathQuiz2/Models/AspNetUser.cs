using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int Gender { get; set; }

    public string? Address { get; set; }

    public int? AvatarId { get; set; }

    public int? BackgroundId { get; set; }

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string? TokenHash { get; set; }

    public int Roletype { get; set; }

    public virtual ICollection<Answer> AnswerUserIdCreateNavigations { get; set; } = new List<Answer>();

    public virtual ICollection<Answer> AnswerUserIdRemoveNavigations { get; set; } = new List<Answer>();

    public virtual ICollection<Answer> AnswerUserIdUpdateNavigations { get; set; } = new List<Answer>();

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; } = new List<AspNetUserToken>();

    public virtual Image? Avatar { get; set; }

    public virtual Image? Background { get; set; }

    public virtual ICollection<Chapter> ChapterUserIdCreateNavigations { get; set; } = new List<Chapter>();

    public virtual ICollection<Chapter> ChapterUserIdRemoveNavigations { get; set; } = new List<Chapter>();

    public virtual ICollection<Chapter> ChapterUserIdUpdateNavigations { get; set; } = new List<Chapter>();

    public virtual ICollection<Class> ClassUserIdCreateNavigations { get; set; } = new List<Class>();

    public virtual ICollection<Class> ClassUserIdRemoveNavigations { get; set; } = new List<Class>();

    public virtual ICollection<Class> ClassUserIdUpdateNavigations { get; set; } = new List<Class>();

    public virtual ICollection<ComponentChapter> ComponentChapterUserIdCreateNavigations { get; set; } = new List<ComponentChapter>();

    public virtual ICollection<ComponentChapter> ComponentChapterUserIdRemoveNavigations { get; set; } = new List<ComponentChapter>();

    public virtual ICollection<ComponentChapter> ComponentChapterUserIdUpdateNavigations { get; set; } = new List<ComponentChapter>();

    public virtual ICollection<ExamMatrix> ExamMatrixUserIdCreateNavigations { get; set; } = new List<ExamMatrix>();

    public virtual ICollection<ExamMatrix> ExamMatrixUserIdUpdateNavigations { get; set; } = new List<ExamMatrix>();

    public virtual ICollection<ExamMatrix> ExamMatrixUserRemoves { get; set; } = new List<ExamMatrix>();

    public virtual ICollection<Exam> ExamUserIdCreateNavigations { get; set; } = new List<Exam>();

    public virtual ICollection<Exam> ExamUserIdRemoveNavigations { get; set; } = new List<Exam>();

    public virtual ICollection<Exam> ExamUserIdUpdateNavigations { get; set; } = new List<Exam>();

    public virtual ICollection<GroupDetail> GroupDetails { get; set; } = new List<GroupDetail>();

    public virtual ICollection<Group> GroupUserIdLeaderNavigations { get; set; } = new List<Group>();

    public virtual ICollection<Group> GroupUserIdRemoveNavigations { get; set; } = new List<Group>();

    public virtual ICollection<Group> GroupUserIdUpdateNavigations { get; set; } = new List<Group>();

    public virtual ICollection<HubConnection> HubConnections { get; set; } = new List<HubConnection>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<Question> QuestionUserIdCreateNavigations { get; set; } = new List<Question>();

    public virtual ICollection<Question> QuestionUserIdRemoveNavigations { get; set; } = new List<Question>();

    public virtual ICollection<Question> QuestionUserIdUpdateNavigations { get; set; } = new List<Question>();

    public virtual ICollection<UserExam> UserExams { get; set; } = new List<UserExam>();

    public virtual ICollection<UserStatistic> UserStatistics { get; set; } = new List<UserStatistic>();

    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();
}
