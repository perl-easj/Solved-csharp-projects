using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Popups;
#pragma warning disable CS4014

namespace NoteBook
{
    public class NoteDetailsViewModel : INotifyPropertyChanged
    {
        public Note DomainObject;
        private NoteMasterDetailsViewModel _masterDetailsViewModel;

        public NoteDetailsViewModel(Note obj, NoteMasterDetailsViewModel masterDetailsViewModel)
        {
            DomainObject = obj;
            _masterDetailsViewModel = masterDetailsViewModel;
        }

        public string Title
        {
            get { return DomainObject.Title; }
            set
            {
                _masterDetailsViewModel.UpdateTitle(value);
            }
        }

        public string Content
        {
            get { return DomainObject.Content; }
            set
            {
                DomainObject.Content = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}