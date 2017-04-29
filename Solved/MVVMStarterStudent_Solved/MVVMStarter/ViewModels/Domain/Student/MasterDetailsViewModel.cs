using System.Collections.Generic;
using MVVMStarter.ViewModels.Base;
using StudentClass = MVVMStarter.Models.Domain.Student.Student;

namespace MVVMStarter.ViewModels.Domain.Student
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<StudentClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Student.DomainModel.Instance)
        {
            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add(nameof(StudentClass.Name));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(StudentClass.Country));
            nonFixedKeyProperties.Add(nameof(StudentClass.YearOfBirth));
            nonFixedKeyProperties.Add(nameof(StudentClass.City));
            nonFixedKeyProperties.Add(nameof(StudentClass.ZipCode));
            nonFixedKeyProperties.Add(nameof(StudentClass.PhotoID));

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
