using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class Chapter
{
    public int Id { get; set; }

    public string? ChapterName { get; set; }

    public string? ChapterDescription { get; set; }

    public bool IsRemoved { get; set; }

    public DateTime DateCreate { get; set; }

    public string? UserIdCreate { get; set; }

    public DateTime DateUpdate { get; set; }

    public string? UserIdUpdate { get; set; }

    public DateTime DateRemove { get; set; }

    public string? UserIdRemove { get; set; }

    public int ClassId { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual ICollection<ComponentChapter> ComponentChapters { get; set; } = new List<ComponentChapter>();

    public virtual ICollection<ExamMatrixDetail> ExamMatrixDetails { get; set; } = new List<ExamMatrixDetail>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual AspNetUser? UserIdCreateNavigation { get; set; }

    public virtual AspNetUser? UserIdRemoveNavigation { get; set; }

    public virtual AspNetUser? UserIdUpdateNavigation { get; set; }
}
