using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class UserExam
{
    public int Id { get; set; }

    public int ExamId { get; set; }

    public int LevelType { get; set; }

    public int Score { get; set; }

    public bool IsRemoved { get; set; }

    public bool IsComplete { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string? UserId { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual AspNetUser? User { get; set; }

    public virtual ICollection<UserExamDetail> UserExamDetails { get; set; } = new List<UserExamDetail>();
}
