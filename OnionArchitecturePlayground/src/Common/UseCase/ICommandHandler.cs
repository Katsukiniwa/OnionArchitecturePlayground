namespace OnionArchitecturePlayground.src.Common.UseCase
{
    public interface ICommandHandler<C>
    {
        void Handle(C command);
    }
}
