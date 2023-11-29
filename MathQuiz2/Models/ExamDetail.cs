using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class ExamDetail
{
    public int Id { get; set; }

    public int ExamId { get; set; }

    public int QuestionId { get; set; }

    public bool IsRemoved { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;
}
