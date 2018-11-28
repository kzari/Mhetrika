using System;

namespace mhetrika.core.Entities
{
    public class Cardio
    {
        public int Id { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
        public int Pas { get; set; }
        public int Ldl_c { get; set; }
        public int Hdl_c { get; set; }
        public int Ct { get; set; }
        public bool Status { get; set; }
        public bool Smokes { get; set; }
        public bool Statin { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
