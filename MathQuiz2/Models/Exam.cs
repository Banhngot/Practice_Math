using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class Exam
{
    public int Id { get; set; }

    public string? ExamName { get; set; }

    public string? ExamDescription { get; set; }

    public int NumberOfQuestion { get; set; }

    public double ExamTime { get; set; }

    public int LevelType { get; set; }

    public bool IsRemoved { get; set; }

    public DateTime DateCreate { get; set; }

    public string? UserIdCreate { get; set; }

    public DateTime DateUpdate { get; set; }

    public string? UserIdUpdate { get; set; }

    public DateTime DateRemove { get; set; }

    public string? UserIdRemove { get; set; }

    public bool IsUserCreate { get; set; }

    public int TotalUserExam { get; set; }

    public virtual ICollection<ExamDetail> ExamDetails { get; set; } = new List<ExamDetail>();

    public virtual ICollection<GroupExam> GroupExams { get; set; } = new List<GroupExam>();

    public virtual ICollection<UserExam> UserExams { get; set; } = new List<UserExam>();

    public virtual AspNetUser? UserIdCreateNavigation { get; set; }

    public virtual AspNetUser? UserIdRemoveNavigation { get; set; }

    public virtual AspNetUser? UserIdUpdateNavigation { get; set; }
}
