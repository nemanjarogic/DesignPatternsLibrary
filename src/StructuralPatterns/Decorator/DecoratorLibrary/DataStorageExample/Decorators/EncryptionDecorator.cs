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
    public class EncryptionDecorator : DataSourceDecorator
    {
        private readonly IDataSource _wrapee;
        private readonly string _encryptionBlock;

        public EncryptionDecorator(IDataSource wrapee)
            : base(wrapee)
        {
            _wrapee = wrapee;
            _encryptionBlock = "##3NCRYPT3D##";
        }

        public override string Read()
        {
            var encryptedData = _wrapee.Read();
            return Decrypt(encryptedData);
        }

        public override void Write(string data)
        {
            Console.WriteLine("Encryption");

            var encryptedData = Encrypt(data);
            _wrapee.Write(encryptedData);
        }

        private string Decrypt(string data)
        {
            return data.Replace(_encryptionBlock, string.Empty);
        }

        private string Encrypt(string data)
        {
            return $"{_encryptionBlock}{data}{_encryptionBlock}";
        }
    }
}
