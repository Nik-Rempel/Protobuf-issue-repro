using System;
using System.IO;
using ProtoBuf;

namespace Library
{
    public static class ProtoBufTest
    {
        public static void Serialize(Stream stream)
        {
            ProtoBuf.Serializer.Serialize(stream, new EnumWrapper
            {
                TestTuple = (EnumKey.Key0, EnumValue.Test2)
            });
        }
    }

    [ProtoContract]
    public class EnumWrapper
    {
        [ProtoMember(1)] public (EnumKey, EnumValue) TestTuple;

    }

    [ProtoContract(EnumPassthru = true)]
    public enum EnumValue
    {
        Test0,
        Test1,
        Test2
    }

    [ProtoContract(EnumPassthru = true)]
    public enum EnumKey
    {
        Key0,
        Key1,
        Key2
    }
}