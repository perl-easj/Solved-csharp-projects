using System.Collections.Generic;

namespace ExamAdmV21
{
    public class StudentMasterDetailsViewModel
    {
        #region Instance fields
        private StudentCatalog _studentCatalog;
        #endregion

        #region Constructor
        public StudentMasterDetailsViewModel()
        {
            _studentCatalog = new StudentCatalog();
        }
        #endregion

        #region Properties
        public List<StudentItemViewModel> StudentItemViewModelCollection
        {
            get { return CreateStudentItemViewModelCollection(); }
        }
        #endregion

        private List<StudentItemViewModel> CreateStudentItemViewModelCollection()
        {
            List<StudentItemViewModel>  vmCollection = new List<StudentItemViewModel>();

            foreach (Student s in _studentCatalog.Students)
            {
                vmCollection.Add(new StudentItemViewModel(s));
            }

            return vmCollection;
        }
    }
}