namespace SealedPerformance
{
    public class BaseClass
    {
        public virtual void VoidMethod() { }

        public virtual int IntMethod() => 0;
    }

    public class OpenClass : BaseClass
    {
        public override void VoidMethod() { }

        public override int IntMethod() => 10;
    }

    public sealed class SealedClass : BaseClass
    {
        public override void VoidMethod() { }

        public override int IntMethod() => 20;
    }
}