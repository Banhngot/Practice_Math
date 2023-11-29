using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class Class
{
    public int Id { get; set; }

    public string? ClassName { get; set; }

    public bool IsRemoved { get; set; }

    public DateTime DateCreate { get; set; }

    public string? UserIdCreate { get; set; }

    public DateTime DateUpdate { get; set; }

    public string? UserIdUpdate { get; set; }

    public DateTime DateRemove { get; set; }

    public string? UserIdRemove { get; set; }

    public virtual ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();

    public virtual AspNetUser? UserIdCreateNavigation { get; set; }

    public virtual AspNetUser? UserIdRemoveNavigation { get; set; }

    public virtual AspNetUser? UserIdUpdateNavigation { get; set; }
}
