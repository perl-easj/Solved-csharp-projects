using ExamAdmV23.BaseClasses;

namespace ExamAdmV23.DomainClasses
{
    public class StudentItemViewModel : ItemViewModelBase<Student>
    {
        public StudentItemViewModel(Student obj) 
            : base(obj)
        {
        }

        public string Name
        {
            get { return DomainObject.Name; }
        }

        public string ImageSource
        {
            get { return DomainObject.ImageSource; }
        }

        public string CountryStr
        {
            get { return "From " + DomainObject.Country; }
        }

        public string BirthStr
        {
            get { return "(Born " + DomainObject.YearOfBirth + ")"; }
        }
    }
}
