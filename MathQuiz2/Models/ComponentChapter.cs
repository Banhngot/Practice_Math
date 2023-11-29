using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class ComponentChapter
{
    public int Id { get; set; }

    public string? ComponentName { get; set; }

    public int ChapterId { get; set; }

    public bool IsRemoved { get; set; }

    public DateTime DateCreate { get; set; }

    public string? UserIdCreate { get; set; }

    public DateTime DateUpdate { get; set; }

    public string? UserIdUpdate { get; set; }

    public DateTime DateRemove { get; set; }

    public string? UserIdRemove { get; set; }

    public virtual Chapter Chapter { get; set; } = null!;

    public virtual ICollection<ExamMatrixDetail> ExamMatrixDetails { get; set; } = new List<ExamMatrixDetail>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual AspNetUser? UserIdCreateNavigation { get; set; }

    public virtual AspNetUser? UserIdRemoveNavigation { get; set; }

    public virtual AspNetUser? UserIdUpdateNavigation { get; set; }
}
