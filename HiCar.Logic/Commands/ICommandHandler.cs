using CSharpFunctionalExtensions;

namespace HiCar.Logic.Commands
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}