using System;

namespace Truget.Infrastructure.Library.EntityTranslator.Interfaces
{
    public interface IEntityTranslator
    {
        bool CanTranslate(Type targetType, Type sourceType);
        bool CanTranslate<TTarget, TSource>();
        object Translate(Type targetType, object source);
        TTarget Translate<TTarget>(object source);
    }
}