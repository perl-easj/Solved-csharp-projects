using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExamAdmV20
{
    class StudentViewModel : INotifyPropertyChanged
    {
        private Student _student;

        #region Constructor
        public StudentViewModel()
        {
            _student = new Student();
        }
        #endregion

        #region Properties for Data Binding
        public string TopLineText
        {
            get
            {
                return string.Format("{0} scored {1} in the {2} test", _student.Name, _student.Score, _student.Subject);
            }
        }

        public string Name
        {
            get { return _student.Name; }
            set
            {
                _student.Name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TopLineText));
            }
        }

        public string Subject
        {
            get { return _student.Subject; }
            set
            {
                _student.Subject = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TopLineText));
            }
        }

        public int Score
        {
            get { return _student.Score; }
            set
            {
                _student.Score = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TopLineText));
            }
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
