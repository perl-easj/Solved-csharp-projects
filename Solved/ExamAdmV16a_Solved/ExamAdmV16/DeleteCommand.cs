namespace ExamAdmV16
{
    public class DeleteCommand : CommandBase
    {
        private StudentCatalog _studentCatalog;

        public DeleteCommand(StudentCatalog studentCatalog)
        {
            _studentCatalog = studentCatalog;
        }

        public override bool CanExecute(object parameter)
        {
            return _studentCatalog.SelectedStudent != null;
        }

        public override void Execute(object parameter)
        {
            _studentCatalog.Delete(_studentCatalog.SelectedStudent.Name);
        }
    }
}