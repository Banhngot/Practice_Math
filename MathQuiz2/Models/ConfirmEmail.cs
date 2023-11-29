using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class ConfirmEmail
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public int Code { get; set; }

    public DateTime EndTime { get; set; }
}
