using System;
using System.Collections.Generic;

namespace MathQuiz2.Models;

public partial class Notification
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Message { get; set; }

    public bool IsViewed { get; set; }

    public int NotificationType { get; set; }

    public DateTime NotificationDateTime { get; set; }

    public virtual AspNetUser? User { get; set; }
}
