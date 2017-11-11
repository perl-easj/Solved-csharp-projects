using ExamAdmV23.BaseClasses;

namespace ExamAdmV23.DomainClasses
{
    public class DeleteCommand : DeleteCommandBase<Student, StudentMasterDetailsViewModel>
    {
        public DeleteCommand(StudentCatalog catalog, StudentMasterDetailsViewModel viewModel)
            : base(catalog, viewModel)
        {
        }
    }
}