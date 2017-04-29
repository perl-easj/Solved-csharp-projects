using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Models.Domain.Student
{
    public class DomainModel : DomainModelBase<Student>
    {
        #region Model Singleton implementation
        private static DomainModel _instance = null;

        public static DomainModel Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new DomainModel();
                return _instance;
            }
        }

        /// <summary>
        /// Use a file-based persistent source
        /// </summary>
        private DomainModel() : base(new CollectionBase<Student>(), new FileSourceBase<Student>())
        {
        }
        #endregion
    }
}
