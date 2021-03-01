using System;
using DecoratorLibrary.DataStorageExample.Components.Common;
using DecoratorLibrary.DataStorageExample.Decorators.Common;

namespace DecoratorLibrary.DataStorageExample.Decorators
{
    /// <summary>
    /// Concrete decorators must call methods on the wrapped object,
    /// but may add something of their own to the result.
    /// Decorators can execute the added behavior either before or after the call to a wrapped object.
    /// </summary>
    public class CompressionDecorator : DataSourceDecorator
    {
        private readonly IDataSource _wrapee;
        private readonly string _compressionBlock;

        public CompressionDecorator(IDataSource wrapee)
            : base(wrapee)
        {
            _wrapee = wrapee;
            _compressionBlock = "--COMPRESSED--";
        }

        public override string Read()
        {
            var compressedData = _wrapee.Read();
            return Decompress(compressedData);
        }

        public override void Write(string data)
        {
            Console.WriteLine("Compression");

            var compressedData = Compress(data);
            _wrapee.Write(compressedData);
        }

        private string Decompress(string data)
        {
            return data.Replace(_compressionBlock, string.Empty);
        }

        private string Compress(string data)
        {
            return $"{_compressionBlock}{data}{_compressionBlock}";
        }
    }
}
