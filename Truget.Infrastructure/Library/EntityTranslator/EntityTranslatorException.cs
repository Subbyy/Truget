using System;

namespace Truget.Infrastructure.Library.EntityTranslator
{
    public class EntityTranslatorException : Exception
    {
        public EntityTranslatorException() : base() { }
        public EntityTranslatorException(string message) : base(message) { }
        public EntityTranslatorException(string message, Exception innerException) : base(message, innerException) { }
    }
}
