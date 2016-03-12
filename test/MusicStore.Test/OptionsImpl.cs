using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MusicStore;

namespace MusicStore.Test
{
    public class OptionsImpl<TOptions> : IOptions<TOptions> 
        where TOptions: class, new()
    {
        TOptions value;
        public OptionsImpl(TOptions value)
        {
            this.value = value;
        }
        public TOptions Value
        {
            get { return value; }
        }
    }
}
