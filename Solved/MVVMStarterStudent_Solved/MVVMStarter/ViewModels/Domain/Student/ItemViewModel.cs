using MVVMStarter.ViewModels.Base;
using StudentClass = MVVMStarter.Models.Domain.Student.Student;

namespace MVVMStarter.ViewModels.Domain.Student
{
    public class ItemViewModel : ItemViewModelBase<StudentClass>
    {
        public override string Description
        {
            get { return DomainObject.Name + " from " + DomainObject.Country; }
        }

        public override int FontSize
        {
            get { return 24; }
        }

        public override string ImageSource
        {
            get { return DomainObject.ImageSource; }
        }

        public ItemViewModel(StudentClass obj) : base(obj)
        {
        }
    }
}
