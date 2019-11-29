using System;
using System.Collections.Generic;
using System.Text;

namespace HiCar.Logic.Common
{
    /// <summary>
    /// Used in the infrastructure project, specified in logic project to not make the logic project dependent on infrastructure
    /// interface separation pattern
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
