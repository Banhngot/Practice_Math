using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class Image
{
    public int Id { get; set; }

    public string? ImageName { get; set; }

    public string? ImagePath { get; set; }

    public virtual ICollection<AspNetUser> AspNetUserAvatars { get; set; } = new List<AspNetUser>();

    public virtual ICollection<AspNetUser> AspNetUserBackgrounds { get; set; } = new List<AspNetUser>();
}
