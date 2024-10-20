using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class UserActivity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Activity { get; set; } // Ej: "Login", "UpdatedProfile", etc.
        public DateTime ActivityAt { get; set; }
        public string Status { get; set; } // Ej: Success, Failed, etc.

        public virtual User User { get; set; }

    }

}
