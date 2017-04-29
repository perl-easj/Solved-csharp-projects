using MVVMStarter.ViewModels.Base;
using StudentClass = MVVMStarter.Models.Domain.Student.Student;

namespace MVVMStarter.ViewModels.Domain.Student
{
    public class ViewModelFactory : ViewModelFactoryBase<StudentClass>
    {
        public override DetailsViewModelBase<StudentClass> CreateDetailsViewModel(StudentClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<StudentClass> CreateItemViewModel(StudentClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<StudentClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
