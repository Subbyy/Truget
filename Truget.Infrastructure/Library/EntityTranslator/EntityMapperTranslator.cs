using System;
using System.Collections.Generic;
using System.Text;
using Truget.Infrastructure.Library.EntityTranslator.Interfaces;

namespace Truget.Infrastructure.Library.EntityTranslator
{
    public abstract class EntityMapperTranslator<TBusinessEntity, TServiceEntity> : BaseTranslator
    {
        public override bool CanTranslate(Type targetType, Type sourceType)
        {
            return (targetType == typeof(TBusinessEntity) && sourceType == typeof(TServiceEntity)) ||
                (targetType == typeof(TServiceEntity) && sourceType == typeof(TBusinessEntity));
        }

        public override object Translate(Type targetType, object source)
        {
            if (targetType == typeof(TBusinessEntity))
                return ServiceToBusiness((TServiceEntity)source);
            if (targetType == typeof(TServiceEntity))
                return BusinessToService((TBusinessEntity)source);

            throw new EntityTranslatorException();
        }

        protected abstract TServiceEntity BusinessToService(TBusinessEntity from);
        protected abstract TBusinessEntity ServiceToBusiness(TServiceEntity from);
    }
}
