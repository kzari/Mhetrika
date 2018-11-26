using System;

namespace mhetrika.core.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
