using System;
using System.ComponentModel.DataAnnotations;

namespace HiCar.Logic.Entities
{
    public abstract class Entity
    {
        private int _Id;
        public virtual int Id
        {
            get { return _Id; }
            protected set { _Id = value; }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Entity other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetRealType() != other.GetRealType())
                return false;

            if (Id == 0 || other.Id == 0)
                return false;

            return Id == other.Id;
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetRealType().ToString() + Id).GetHashCode();
        }

        private Type GetRealType()
        {
            throw new NotImplementedException();
            //return NHibernateProxyHelper.GetClassWithoutInitializingProxy(this);
        }
    }
}
