using BenchmarkDotNet.Attributes;

namespace SealedPerformance
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        private readonly BaseClass _baseClass = new();
        private readonly OpenClass _openClass = new();
        private readonly SealedClass _sealedClass = new();

        private readonly OpenClass[] _openClasses = new OpenClass[1];
        private readonly SealedClass[] _sealedClasses = new SealedClass[1];

            [Benchmark]
        public void OpenVoid() => _openClass.VoidMethod();
        
        [Benchmark]
        public void SealedVoid() => _sealedClass.VoidMethod();
        
        [Benchmark]
        public int OpenInt() => _openClass.IntMethod() + 9999;
        
        [Benchmark]
        public int SealedInt() => _sealedClass.IntMethod() + 9999;

        [Benchmark]
        public bool IsCheckOpen() => _baseClass is OpenClass;
        
        [Benchmark]
        public bool IsCheckSealed() => _baseClass is SealedClass;

        [Benchmark]
        public void StoreOpen() => _openClasses[0] = _openClass;
        
        [Benchmark]
        public void StoreSealed() => _sealedClasses[0] = _sealedClass;
    }
}