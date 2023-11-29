using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class Answer
{
    public int Id { get; set; }

    public string AnswerName { get; set; } = null!;

    public bool IsCorrect { get; set; }

    public bool IsRemoved { get; set; }

    public DateTime DateCreate { get; set; }

    public string? UserIdCreate { get; set; }

    public DateTime DateUpdate { get; set; }

    public string? UserIdUpdate { get; set; }

    public DateTime DateRemove { get; set; }

    public string? UserIdRemove { get; set; }

    public int QuestionId { get; set; }

    public virtual Question Question { get; set; } = null!;

    public virtual ICollection<UserExamDetail> UserExamDetails { get; set; } = new List<UserExamDetail>();

    public virtual AspNetUser? UserIdCreateNavigation { get; set; }

    public virtual AspNetUser? UserIdRemoveNavigation { get; set; }

    public virtual AspNetUser? UserIdUpdateNavigation { get; set; }
}
