using System;

namespace mhetrika.core.Entities
{
    public class Fibrosis
    {
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public double AST { get; set; }
        public double ALT { get; set; }
        public double IMC { get; set; }
        public double platelets { get; set; }
        public double Albumin { get; set; }
        public bool Diabetic { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
