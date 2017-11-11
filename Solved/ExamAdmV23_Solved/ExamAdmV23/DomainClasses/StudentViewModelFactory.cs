using ExamAdmV23.BaseClasses;

namespace ExamAdmV23.DomainClasses
{
    public class StudentViewModelFactory : ViewModelFactoryBase<Student>
    {
        public override ItemViewModelBase<Student> CreateItemViewModel(Student obj)
        {
            return new StudentItemViewModel(obj);
        }
    }
}