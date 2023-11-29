using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class ShuffleAnswerViewModel
{
    public int Id { get; set; }

    public string? AnswerName { get; set; }

    public int QuestionId { get; set; }

    public bool IsCorrect { get; set; }

    public int? UserExamDetailId { get; set; }

    public virtual UserExamDetail? UserExamDetail { get; set; }
}
