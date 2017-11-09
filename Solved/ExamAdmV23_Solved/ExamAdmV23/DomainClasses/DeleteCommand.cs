using ExamAdmV23.BaseClasses;

namespace ExamAdmV23.DomainClasses
{
    public class DeleteCommand : DeleteCommandBase<Student, StudentMasterDetailsViewModel, string>
    {
        public DeleteCommand(StudentMasterDetailsViewModel viewModel) 
            : base(viewModel)
        {
        }
    }
}