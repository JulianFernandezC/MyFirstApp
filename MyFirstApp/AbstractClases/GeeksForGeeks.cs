using System;

namespace MyFirstApp.AbstractClases
{
    abstract class GeeksForGeeks : ICloneable
    {
        public abstract object Clone();
        public abstract void gfg();
        public string Test()
        {
            return "We are testing";
        }
        public virtual string VirtualMethod()
        {
            return "This is a virtual method"; 
        }
    }
}
