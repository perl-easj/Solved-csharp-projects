using ExamAdmV23.BaseClasses;

namespace ExamAdmV23.DomainClasses
{
    public class StudentMasterDetailsViewModel : MasterDetailsViewModelBase<Student>
    {
        #region Constructor
        public StudentMasterDetailsViewModel() 
            : base(new StudentCatalog(), new StudentViewModelFactory())
        {
        }
        #endregion
    }
}