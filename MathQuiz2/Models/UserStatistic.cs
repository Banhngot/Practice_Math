using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class UserStatistic
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public double Score { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
