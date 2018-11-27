﻿using System;

namespace mhetrika.core.Entities
{
    class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Crm { get; set; }
        public string Phone { get; set; }
        public string Specialty { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
