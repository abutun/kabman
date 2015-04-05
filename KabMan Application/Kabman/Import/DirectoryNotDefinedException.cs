using System;
using System.Runtime.Serialization;

namespace KabMan
{
    [System.Serializable]
    public class DirectoryNotDefinedException : Exception
    {

        public DirectoryNotDefinedException()
        {
        }
        public DirectoryNotDefinedException(string message)
            : base(message)
        {
        }
        public DirectoryNotDefinedException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected DirectoryNotDefinedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }


}
