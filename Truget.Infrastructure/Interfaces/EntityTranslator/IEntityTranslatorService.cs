using System;

namespace Truget.Infrastructure.Library.EntityTranslator.Interfaces
{
    public interface IEntityTranslatorService
    {
        TTarget Translate<TTarget>(object source);
    }
}