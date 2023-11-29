using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class ExamMatrix
{
    public int Id { get; set; }

    public string? NameMatrix { get; set; }

    public string? DescriptionMatrix { get; set; }

    public int Total { get; set; }

    public bool IsRemoved { get; set; }

    public DateTime DateCreate { get; set; }

    public string? UserIdCreate { get; set; }

    public DateTime DateUpdate { get; set; }

    public string? UserIdUpdate { get; set; }

    public DateTime DateRemove { get; set; }

    public string? UserIdRemove { get; set; }

    public bool? IsDefault { get; set; }

    public string? UserRemoveId { get; set; }

    public virtual ICollection<ExamMatrixDetail> ExamMatrixDetails { get; set; } = new List<ExamMatrixDetail>();

    public virtual AspNetUser? UserIdCreateNavigation { get; set; }

    public virtual AspNetUser? UserIdUpdateNavigation { get; set; }

    public virtual AspNetUser? UserRemove { get; set; }
}
