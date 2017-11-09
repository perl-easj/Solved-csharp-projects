using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ExamAdmV22
{
    public class StudentMasterDetailsViewModel : INotifyPropertyChanged
    {
        #region Instance fields
        private StudentCatalog _studentCollection;
        private StudentItemViewModel _studentItemViewModelSelected;
        private StudentMasterViewModel _studentMasterViewModel;
        private DeleteCommand _deleteCommand;
        #endregion

        #region Constructor
        public StudentMasterDetailsViewModel()
        {
            _studentCollection = new StudentCatalog();
            _studentMasterViewModel = new StudentMasterViewModel();
            _studentItemViewModelSelected = null;

            _deleteCommand = new DeleteCommand(this);  // Changed
        }
        #endregion

        #region Properties for Data Binding
        // Added
        public ICommand DeletionCommand
        {
            get { return _deleteCommand; }
        }

        public List<StudentItemViewModel> StudentItemViewModelCollection
        {
            get { return _studentMasterViewModel.GetStudentItemViewModelCollection(_studentCollection); }
        }

        public StudentItemViewModel StudentItemViewModelSelected
        {
            get { return _studentItemViewModelSelected; }
            set
            {
                _studentItemViewModelSelected = value;
                _deleteCommand.RaiseCanExecuteChanged();  // Added
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        public void Delete(string name)
        {
            // Delete from model collection
            _studentCollection.Delete(name);

            // Set selection to null
            StudentItemViewModelSelected = null;

            // Refresh the item list
            OnPropertyChanged(nameof(StudentItemViewModelCollection));
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
