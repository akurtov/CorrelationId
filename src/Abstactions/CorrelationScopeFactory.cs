using System;
using CorrelationId.Abstractions.Contracts;

namespace CorrelationId.Abstractions
{
    public sealed class CorrelationScopeFactory : ICorrelationScopeFactory
    {
        public CorrelationScope Create(string correlationId = default)
        {
            if (CorrelationScope.CorrelationId != null)
            {
                throw new InvalidOperationException("Correlation scope already initialized");
            }
            
            return new CorrelationScope(correlationId);
        }
    }
}