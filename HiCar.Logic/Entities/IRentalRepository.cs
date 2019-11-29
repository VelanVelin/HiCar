using HiCar.Logic.Common;

namespace HiCar.Logic.Entities
{
    public interface IRentalRepository <T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}