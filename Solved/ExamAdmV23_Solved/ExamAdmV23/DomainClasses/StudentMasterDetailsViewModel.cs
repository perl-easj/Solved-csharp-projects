using ExamAdmV23.BaseClasses;

namespace ExamAdmV23.DomainClasses
{
    public class StudentMasterDetailsViewModel : MasterDetailsViewModelBase<Student, string>
    {
        #region Constructor
        public StudentMasterDetailsViewModel()
            : base(new StudentViewModelFactory(), new StudentCatalog())
        {
        } 
        #endregion
    }
}