using System;
using System.Collections.Generic;
using System.Text;

namespace mhetrika.core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
