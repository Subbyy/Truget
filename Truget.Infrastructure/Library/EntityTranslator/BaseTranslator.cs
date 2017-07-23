using System;
using Truget.Infrastructure.Library.EntityTranslator.Interfaces;

namespace Truget.Infrastructure.Library.EntityTranslator
{
    public abstract class BaseTranslator : IEntityTranslator
    {
        public abstract bool CanTranslate(Type targetType, Type sourceType);

        public bool CanTranslate<TTarget, TSource>()
        {
            return CanTranslate(typeof(TTarget), typeof(TSource));
        }

        public TTarget Translate<TTarget>(object source)
        {
            return (TTarget)Translate(typeof(TTarget), source);
        }

        public abstract object Translate(Type targetType, object source);
    }
}
