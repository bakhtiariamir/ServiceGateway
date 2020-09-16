using System;

namespace Service.Gateway.DataModel
{
    public interface IEntity
    {
        Guid Id
        {
            get;
            set;
        }
    }
}
