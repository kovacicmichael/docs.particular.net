﻿namespace Snippets6.Headers
{
    using System.Threading.Tasks;
    using NServiceBus.MessageMutator;

    #region header-outgoing-mutator

    public class MutateOutgoingTransportMessages : IMutateOutgoingTransportMessages
    {
        public Task MutateOutgoing(MutateOutgoingTransportMessageContext context)
        {
            context.OutgoingHeaders["MyCustomHeader"] = "My custom value";
            return Task.FromResult(0);
        }
    }

    #endregion
}