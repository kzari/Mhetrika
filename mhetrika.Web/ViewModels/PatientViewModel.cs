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
        public AddressViewModel AddressViewModel { get; set; }
    }
}
