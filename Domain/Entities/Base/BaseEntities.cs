using System.Diagnostics;

namespace Domain.Entities.Base
{
     public class BaseEntities
    {
        public virtual string Id { get; set; }
        private  DateTime creationDate { get; set; }
    }
}
