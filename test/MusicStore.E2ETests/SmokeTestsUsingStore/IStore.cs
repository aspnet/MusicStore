using System;
using Microsoft.Extensions.Logging;

namespace E2ETests
{
    internal interface IStore : IDisposable
    {
        string CreateStore(bool createInDefaultLocation);
    }
}
