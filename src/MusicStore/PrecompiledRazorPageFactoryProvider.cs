using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Primitives;

namespace MusicStore
{
    public class PrecompiledRazorPageFactoryProvider : IRazorPageFactoryProvider
    {
        private readonly Assembly _assembly = typeof(PrecompiledRazorPageFactoryProvider).GetTypeInfo().Assembly;

        public RazorPageFactoryResult CreateFactory(string relativePath)
        {
            var typeName = new StringBuilder("MusicStore");
            var tokens = relativePath.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                typeName.Append('.');
                typeName.Append(token);
            }

            typeName.Length = typeName.Length - (".cshtml").Length;

            var type = _assembly.GetType(typeName.ToString());
            if (type == null)
            {
                return new RazorPageFactoryResult();
            }

            return new RazorPageFactoryResult(() => (IRazorPage)Activator.CreateInstance(type), new List<IChangeToken>());
        }
    }
}
