

namespace TiendaOnline.Shared.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class ValueObject
    {
        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object obj)
        {
            if (obj is null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (IdValueObject)obj;
            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Aggregate(1, (current, obj) => current * 31 + (obj?.GetHashCode() ?? 0));
        }

        public static bool operator ==(IdValueObject left, IdValueObject right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        public static bool operator !=(IdValueObject left, IdValueObject right)
        {
            return !(left == right);
        }
    }

}
