using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class HubConnection
{
    public int Id { get; set; }

    public string? ConnectionId { get; set; }

    public string? UserId { get; set; }

    public virtual AspNetUser? User { get; set; }
}
