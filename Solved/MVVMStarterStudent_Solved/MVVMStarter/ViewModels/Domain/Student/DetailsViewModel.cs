using MVVMStarter.ViewModels.Base;
using StudentClass = MVVMStarter.Models.Domain.Student.Student;

namespace MVVMStarter.ViewModels.Domain.Student
{
    public class DetailsViewModel : DetailsViewModelBase<StudentClass>
    {
        public string Name
        {
            get { return DomainObject.Name; }
            set
            {
                DomainObject.Name = value;
                OnPropertyChanged();
            }
        }

        public int YearOfBirth
        {
            get { return DomainObject.YearOfBirth; }
            set
            {
                DomainObject.YearOfBirth = value;
                OnPropertyChanged();
            }
        }

        public string Country
        {
            get { return DomainObject.Country; }
            set
            {
                DomainObject.Country = value;
                OnPropertyChanged();
            }
        }

        public int ZipCode
        {
            get { return DomainObject.ZipCode; }
            set
            {
                DomainObject.ZipCode = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get { return DomainObject.City; }
            set
            {
                DomainObject.City = value;
                OnPropertyChanged();
            }
        }

        public string PhotoID
        {
            get { return DomainObject.PhotoID; }
            set
            {
                DomainObject.PhotoID = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(StudentClass obj) : base(obj)
        {
        }
    }
}
