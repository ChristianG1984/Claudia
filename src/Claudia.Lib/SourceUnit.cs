using System;
using System.Collections.Generic;
using System.Text;

namespace Claudia.Lib.Interface
{
    public interface SourceUnit
    {
        string PreprocessorResult();
    }
}

namespace Claudia.Lib.Default
{
    public sealed class SourceUnit : Interface.SourceUnit
    {
        private readonly string source;
        private readonly string environment;

        public SourceUnit(string source, string environment)
        {
            this.source = source
                ?? throw new ArgumentNullException(nameof(source));
            this.environment = environment
                ?? throw new ArgumentNullException(nameof(environment));
        }

        public string PreprocessorResult()
        {
            throw new NotImplementedException();
        }
    }
}