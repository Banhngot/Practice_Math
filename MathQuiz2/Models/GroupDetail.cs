using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class GroupDetail
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public string? UserId { get; set; }

    public DateTime DateJoin { get; set; }

    public bool? IsLeader { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual AspNetUser? User { get; set; }
}
