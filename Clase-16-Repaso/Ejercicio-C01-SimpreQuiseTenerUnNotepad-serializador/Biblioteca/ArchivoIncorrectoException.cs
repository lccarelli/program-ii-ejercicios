using System;

namespace IO
{
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(string message)
            :base(message)
        {
        }
    }
}
