using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class UserExamDetail
{
    public int Id { get; set; }

    public int UserExamId { get; set; }

    public int QuestionId { get; set; }

    public string? ShuffleAnswersJson { get; set; }

    public int? SelectAnswer { get; set; }

    public virtual Question Question { get; set; } = null!;

    public virtual Answer? SelectAnswerNavigation { get; set; }

    public virtual ICollection<ShuffleAnswerViewModel> ShuffleAnswerViewModels { get; set; } = new List<ShuffleAnswerViewModel>();

    public virtual UserExam UserExam { get; set; } = null!;
}
