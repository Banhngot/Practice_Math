using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class Group
{
    public int Id { get; set; }

    public string? GroupName { get; set; }

    public string? GroupDescription { get; set; }

    public DateTime DateCreate { get; set; }

    public string? UserIdLeader { get; set; }

    public DateTime DateUpdate { get; set; }

    public string? UserIdUpdate { get; set; }

    public DateTime DateRemove { get; set; }

    public string? UserIdRemove { get; set; }

    public bool IsRemoved { get; set; }

    public virtual ICollection<GroupDetail> GroupDetails { get; set; } = new List<GroupDetail>();

    public virtual ICollection<GroupExam> GroupExams { get; set; } = new List<GroupExam>();

    public virtual AspNetUser? UserIdLeaderNavigation { get; set; }

    public virtual AspNetUser? UserIdRemoveNavigation { get; set; }

    public virtual AspNetUser? UserIdUpdateNavigation { get; set; }
}
