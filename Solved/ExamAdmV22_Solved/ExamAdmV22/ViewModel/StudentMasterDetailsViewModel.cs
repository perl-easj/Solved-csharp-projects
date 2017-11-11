using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ExamAdmV22.Model;

namespace ExamAdmV22.ViewModel
{
    public class StudentMasterDetailsViewModel : INotifyPropertyChanged
    {
        #region Instance fields
        private StudentCatalog _studentCatalog;
        private StudentItemViewModel _studentItemViewModelSelected;
        private StudentDetailsViewModel _studentDetailsViewModel;
        private DeleteCommand _deleteCommand;
        #endregion

        #region Constructor
        public StudentMasterDetailsViewModel()
        {
            _studentCatalog = new StudentCatalog();
            _studentItemViewModelSelected = null;
            _studentDetailsViewModel = null;

            _deleteCommand = new DeleteCommand(_studentCatalog, this);
        }
        #endregion

        #region Properties for Data Binding
        public List<StudentItemViewModel> StudentItemViewModelCollection
        {
            get { return GetStudentItemViewModelCollection(); }
        }

        public StudentItemViewModel StudentItemViewModelSelected
        {
            get { return _studentItemViewModelSelected; }
            set
            {
                _studentItemViewModelSelected = value;

                if (_studentItemViewModelSelected == null)
                {
                    StudentDetailsViewModel = null;
                }
                else
                {
                    StudentDetailsViewModel = new StudentDetailsViewModel(_studentItemViewModelSelected.DomainObject);
                }

                OnPropertyChanged();
                _deleteCommand.RaiseCanExecuteChanged();
            }
        }

        public StudentDetailsViewModel StudentDetailsViewModel
        {
            get { return _studentDetailsViewModel; }
            private set
            {
                _studentDetailsViewModel = value;
                OnPropertyChanged();
            }
        }

        public ICommand DeletionCommand
        {
            get { return _deleteCommand; }
        }
        #endregion

        #region Methods
        public void RefreshStudentItemViewModelCollection()
        {
            OnPropertyChanged(nameof(StudentItemViewModelCollection));
        }

        private List<StudentItemViewModel> GetStudentItemViewModelCollection()
        {
            List<StudentItemViewModel> items = new List<StudentItemViewModel>();

            foreach (Student s in _studentCatalog.Students)
            {
                items.Add(new StudentItemViewModel(s));
            }

            return items;
        }
        #endregion

        #region OnPropertyChanged code
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
