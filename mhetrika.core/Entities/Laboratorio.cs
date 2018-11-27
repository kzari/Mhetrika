using System;

namespace mhetrika.core.Entities
{
    public class Laboratorio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int AddresId { get; set; }
        public virtual Address Address { get; set; }
    }
}
