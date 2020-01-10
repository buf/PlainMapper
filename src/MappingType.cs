namespace SimpleMapper
{
    using System;

    public class MappingType
    {
        public MappingType(Type classType, Type interfaceType)
        {
            ClassType = classType;
            InterfaceType = interfaceType;
        }

        public Type ClassType { get; }

        public Type InterfaceType { get; }
    }
}