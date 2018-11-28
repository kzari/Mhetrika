using System;

namespace mhetrika.core.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}