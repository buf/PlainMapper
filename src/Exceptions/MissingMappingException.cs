namespace SimpleMapper.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    internal class MissingMappingException : Exception
    {
        public MissingMappingException(Type sourceType, Type targetType)
            : base($"Missing mapping between source {sourceType.Name} and target {targetType.Name}")
        {
        }

        public MissingMappingException(string message)
            : base(message)
        {
        }

        public MissingMappingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected MissingMappingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}