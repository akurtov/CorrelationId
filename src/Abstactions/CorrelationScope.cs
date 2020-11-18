using System;
using System.Threading;

namespace CorrelationId.Abstractions
{
    public sealed class CorrelationScope : IDisposable
    {
        private static readonly AsyncLocal<string> _asyncCorrelationId = new AsyncLocal<string>();

        public static string CorrelationId => _asyncCorrelationId.Value;

        internal CorrelationScope(string correlationId = default)
        {
            correlationId ??= CreateId();
            _asyncCorrelationId.Value = correlationId;
        }

        public void Dispose()
        {
            _asyncCorrelationId.Value = null;
        }

        private static string CreateId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}