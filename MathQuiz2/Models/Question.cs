using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class Question
{
    public int Id { get; set; }

    public string QuestionName { get; set; } = null!;

    public int LevelType { get; set; }

    public string? QuestionSolution { get; set; }

    public string? QuestionHints { get; set; }

    public int NumberTimes { get; set; }

    public int NumberCorrect { get; set; }

    public bool IsRemoved { get; set; }

    public DateTime DateCreate { get; set; }

    public string? UserIdCreate { get; set; }

    public DateTime DateUpdate { get; set; }

    public string? UserIdUpdate { get; set; }

    public DateTime DateRemove { get; set; }

    public string? UserIdRemove { get; set; }

    public int ChappterId { get; set; }

    public string? IsImage { get; set; }

    public int ComponentChapterId { get; set; }

    public string? IsImageSolution { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Chapter Chappter { get; set; } = null!;

    public virtual ComponentChapter ComponentChapter { get; set; } = null!;

    public virtual ICollection<ExamDetail> ExamDetails { get; set; } = new List<ExamDetail>();

    public virtual ICollection<UserExamDetail> UserExamDetails { get; set; } = new List<UserExamDetail>();

    public virtual AspNetUser? UserIdCreateNavigation { get; set; }

    public virtual AspNetUser? UserIdRemoveNavigation { get; set; }

    public virtual AspNetUser? UserIdUpdateNavigation { get; set; }
}
