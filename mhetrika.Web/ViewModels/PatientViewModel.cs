using System;

namespace Mhetrika.Web.ViewModels
{
    public class PatientViewModel
    {
        private DateTime creationDate;
        private DateTime modifiedDate;

        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreationDate
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
                this.creationDate = value;
            }
        }
        public DateTime ModifiedDate
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
                this.modifiedDate = value;
            }
        }
        public AddressViewModel AddressViewModel { get; set; }
    }
}
