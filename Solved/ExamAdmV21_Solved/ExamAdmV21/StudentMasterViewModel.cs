using System.Collections.ObjectModel;

namespace ExamAdmV21
{
    public class StudentMasterViewModel
    {
        #region Instance fields
        private StudentCatalog _studentCatalog;
        private ObservableCollection<StudentItemViewModel> _studentItemViewModelCollection;
        #endregion

        #region Constructor
        public StudentMasterViewModel()
        {
            _studentCatalog = new StudentCatalog();
            _studentItemViewModelCollection = new ObservableCollection<StudentItemViewModel>();

            foreach (Student s in _studentCatalog.Students)
            {
                _studentItemViewModelCollection.Add(new StudentItemViewModel(s));
            }
        }
        #endregion

        #region Properties
        public ObservableCollection<StudentItemViewModel> StudentItemViewModelCollection
        {
            get { return _studentItemViewModelCollection; }
        } 
        #endregion
    }
}