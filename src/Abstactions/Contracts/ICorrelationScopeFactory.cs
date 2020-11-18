namespace CorrelationId.Abstractions.Contracts
{
    public interface ICorrelationScopeFactory
    {
        CorrelationScope Create(string correlationId = default);
    }
}