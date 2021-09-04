using System;
using System.Collections.Generic;

namespace OnionArchitecturePlayground.src.Common.Domain
{
    public abstract class Entity
    {
        string _Id;
        public virtual string Id
        {
            get
            {
                return _Id;
            }
            protected set
            {
                _Id = value;
            }
        }

        private List<INotification> _domainEvents;
        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents?.AsReadOnly();
    }
}
