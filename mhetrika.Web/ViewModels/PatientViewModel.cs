using System;

namespace Mhetrika.Web.ViewModels
{
    public class PatientViewModel
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cep { get; set; }
        public byte Number { get; set; }
        public string Street { get; set; }
        public string Neighbourhood { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }
    }
}
