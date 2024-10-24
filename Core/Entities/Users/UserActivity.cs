using System;

namespace Core.Entities
{
    public record UserActivity
    {
        public Guid Id { get; init; }
        public Guid UserId { get; init; }
        public string Activity { get; init; }
        public DateTime ActivityAt { get; init; }
        public string Status { get; init; }
        public User User { get; init; }

    }
}
