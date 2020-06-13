﻿// Classes and structures being serialized

// Generated by ProtocolBuffer
// - a pure c# code generation implementation of protocol buffers
// Report bugs to: https://silentorbit.com/protobuf/

// DO NOT EDIT
// This file will be overwritten when CodeGenerator is run.
// To make custom modifications, edit the .proto file and add //:external before the message line
// then write the code and the changes in a separate file.
using System;
using System.Collections.Generic;

namespace Local
{
    /// <summary>This is a demonstration of features only present in ProtoBuf Code Generator</summary>
    internal partial class LocalFeatures
    {
        /// <summary>Make class field of type TimeSpan, serialized to Ticks</summary>
        public TimeSpan Uptime { get; set; }

        /// <summary>Make class field of type DateTime, serialized to Ticks</summary>
        public DateTime DueDate { get; set; }

        /// <summary>Do not generate class field, must be implemented in other partial class</summary>
        //public double Amount { get; set; } // Implemented by user elsewhere

        /// <summary>Custom field access types. Default: public</summary>
        private string Denial { get; set; }

        protected string Secret { get; set; }

        internal string Internal { get; set; }

        public string PR { get; set; }

        /// <summary>Generate a c# readonly field</summary>
        public readonly global::Mine.MyMessageV1 TestingReadOnly = new global::Mine.MyMessageV1();

        /// <summary>When deserializing this one must be set to a class before</summary>
        public global::LocalFeatureTest.InterfaceTest MyInterface { get; set; }

        public global::LocalFeatureTest.StructTest MyStruct;

        public global::TestB.ExternalStruct MyExtStruct;

        public global::TestB.ExternalClass MyExtClass { get; set; }

        public global::LocalFeatureTest.TopEnum MyEnum { get; set; }

        // protected virtual void BeforeSerialize() {}
        // protected virtual void AfterDeserialize() {}

    }

}
namespace LocalFeatureTest
{
    /// <summary>Testing local struct serialization</summary>
    public partial interface InterfaceTest
    {
    }

    /// <summary>Testing local struct serialization</summary>
    public partial struct StructTest
    {
    }

}
namespace TestB
{
    // Written elsewhere
    // public struct ExternalStruct {}

    // Written elsewhere
    // public class ExternalClass {}

}
namespace Mine
{


}
namespace Yours
{

}
namespace Theirs
{

}
namespace Proto.Test
{




}
namespace LocalFeatureTest
{
    [global::System.FlagsAttribute]
    public enum TopEnum
    {
        First = 1,
        Last = 1000000,
    }


    // Written elsewhere
    //
    // public enum ExternalEnum
    // {
    //     First = 1,
    //     Last = 1000000,
    // }

}
namespace Proto.Test
{

    public static class TestRpcNames
    {
        public const string Method = "Test_Method";
    }

    public interface ITestSupporter
    {
        proto.test.MyMessage Method(proto.test.MyMessage request);
    }

}
