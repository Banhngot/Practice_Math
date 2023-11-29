using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class ExamMatrixDetail
{
    public int Id { get; set; }

    public int ChappterId { get; set; }

    public int NumberOfQuestion { get; set; }

    public int ExamMatrixId { get; set; }

    public int ComponentChapterId { get; set; }

    public virtual Chapter Chappter { get; set; } = null!;

    public virtual ComponentChapter ComponentChapter { get; set; } = null!;

    public virtual ExamMatrix ExamMatrix { get; set; } = null!;
}
