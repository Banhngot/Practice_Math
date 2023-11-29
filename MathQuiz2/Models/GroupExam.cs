using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class GroupExam
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int ExamId { get; set; }

    public bool IsModeOn { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Group Group { get; set; } = null!;
}
