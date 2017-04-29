using ExamAdmV23.BaseClasses;

namespace ExamAdmV23.DomainClasses
{
    public class StudentMasterDetailsViewModel : MasterDetailsViewModelBase<Student, string>
    {
        public StudentMasterDetailsViewModel() 
            : base(new StudentViewModelFactory(), new StudentModel())
        {
        }
    }
}