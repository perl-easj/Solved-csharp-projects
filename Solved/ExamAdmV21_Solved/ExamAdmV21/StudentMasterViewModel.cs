using System.Collections.ObjectModel;

namespace ExamAdmV21
{
    public class StudentMasterViewModel
    {
        private StudentCollection _studentCollection;
        private ObservableCollection<StudentItemViewModel> _studentItemViewModelCollection;

        public StudentMasterViewModel()
        {
            _studentCollection = new StudentCollection();
            _studentItemViewModelCollection = new ObservableCollection<StudentItemViewModel>();

            foreach (Student s in _studentCollection.Students)
            {
                _studentItemViewModelCollection.Add(new StudentItemViewModel(s));
            }
        }

        public ObservableCollection<StudentItemViewModel> StudentItemViewModelCollection
        {
            get { return _studentItemViewModelCollection; }
        }
    }
}