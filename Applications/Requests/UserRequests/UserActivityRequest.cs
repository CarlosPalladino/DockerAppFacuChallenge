using System;

namespace Applications.Request.UserRequest
{
    public class UserActivityRequest
    {
        public Guid UserId { get; set; }
        public string Activity { get; set; }
        public string Status { get; set; }

    }
}
