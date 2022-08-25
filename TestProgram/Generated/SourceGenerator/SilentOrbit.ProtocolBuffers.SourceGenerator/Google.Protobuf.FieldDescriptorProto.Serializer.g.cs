﻿﻿
// Generated by ProtocolBuffer
// - a pure c# code generation implementation of protocol buffers
// Report bugs to: https://silentorbit.com/protobuf/

// DO NOT EDIT
// This file will be overwritten when CodeGenerator is run.
// To make custom modifications, edit the .proto file and add //:external before the message line
// then write the code and the changes in a separate file.

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

using SilentOrbit.ProtocolBuffers;
using static SilentOrbit.ProtocolBuffers.ProtocolParser;

// This is the backend code for reading and writing
namespace Google.Protobuf;

public partial class FieldDescriptorProto
{
    /// <summary>Helper: create a new instance to deserializing into</summary>
    public static FieldDescriptorProto Deserialize(Stream stream)
    {
        var instance = new FieldDescriptorProto();
        Deserialize(stream, instance);
        return instance;
    }

    /// <summary>Helper: create a new instance to deserializing into</summary>
    public static FieldDescriptorProto DeserializeLengthDelimited(Stream stream)
    {
        var instance = new FieldDescriptorProto();
        DeserializeLengthDelimited(stream, instance);
        return instance;
    }

    /// <summary>Helper: create a new instance to deserializing into</summary>
    public static FieldDescriptorProto DeserializeLength(Stream stream, int length)
    {
        var instance = new FieldDescriptorProto();
        DeserializeLength(stream, length, instance);
        return instance;
    }

    /// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
    public static FieldDescriptorProto Deserialize(byte[] buffer)
    {
        var instance = new FieldDescriptorProto();
        using (var ms = new MemoryStream(buffer))
            Deserialize(ms, instance);
        return instance;
    }

    /// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
    public static global::Google.Protobuf.FieldDescriptorProto Deserialize(byte[] buffer, global::Google.Protobuf.FieldDescriptorProto instance)
    {
        using (var ms = new MemoryStream(buffer))
            Deserialize(ms, instance);
        return instance;
    }

    /// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
    public static global::Google.Protobuf.FieldDescriptorProto Deserialize(Stream stream, global::Google.Protobuf.FieldDescriptorProto instance)
    {
        instance.label = global::Google.Protobuf.FieldDescriptorProto.Label.LABEL_OPTIONAL;
        instance.type = global::Google.Protobuf.FieldDescriptorProto.Type.TYPE_DOUBLE;
        while (true)
        {
            int keyByte = stream.ReadByte();
            if (keyByte == -1)
                break;
            // Optimized reading of known fields with field ID < 16
            switch (keyByte)
            {
                // Field 1 LengthDelimited
                case 10:
                    instance.Name = ReadString(stream);
                    continue;
                // Field 3 Varint
                case 24:
                    instance.Number = (int)ReadUInt64(stream);
                    continue;
                // Field 4 Varint
                case 32:
                    instance.label = (global::Google.Protobuf.FieldDescriptorProto.Label)ReadUInt64(stream);
                    continue;
                // Field 5 Varint
                case 40:
                    instance.type = (global::Google.Protobuf.FieldDescriptorProto.Type)ReadUInt64(stream);
                    continue;
                // Field 6 LengthDelimited
                case 50:
                    instance.TypeName = ReadString(stream);
                    continue;
                // Field 2 LengthDelimited
                case 18:
                    instance.Extendee = ReadString(stream);
                    continue;
                // Field 7 LengthDelimited
                case 58:
                    instance.DefaultValue = ReadString(stream);
                    continue;
                // Field 8 LengthDelimited
                case 66:
                    if (instance.Options == null)
                        instance.Options = global::Google.Protobuf.FieldOptions.DeserializeLengthDelimited(stream);
                    else
                        global::Google.Protobuf.FieldOptions.DeserializeLengthDelimited(stream, instance.Options);
                    continue;
            }

            var key = ReadKey((byte)keyByte, stream);

            // Reading field ID > 16 and unknown field ID/wire type combinations
            switch (key.Field)
            {
                case 0:
                    throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
                default:
                    SkipKey(stream, key);
                    break;
            }
        }

        return instance;
    }

    /// <summary>Read the VarInt length prefix and the given number of bytes from the stream and deserialze it into the instance.</summary>
    public static global::Google.Protobuf.FieldDescriptorProto DeserializeLengthDelimited(Stream stream, global::Google.Protobuf.FieldDescriptorProto instance)
    {
        instance.label = global::Google.Protobuf.FieldDescriptorProto.Label.LABEL_OPTIONAL;
        instance.type = global::Google.Protobuf.FieldDescriptorProto.Type.TYPE_DOUBLE;
        long limit = ReadUInt32(stream);
        limit += stream.Position;
        while (true)
        {
            if (stream.Position >= limit)
            {
                if (stream.Position == limit)
                    break;
                else
                    throw new ProtocolBufferException("Read past max limit");
            }
            int keyByte = stream.ReadByte();
            if (keyByte == -1)
                throw new System.IO.EndOfStreamException();
            // Optimized reading of known fields with field ID < 16
            switch (keyByte)
            {
                // Field 1 LengthDelimited
                case 10:
                    instance.Name = ReadString(stream);
                    continue;
                // Field 3 Varint
                case 24:
                    instance.Number = (int)ReadUInt64(stream);
                    continue;
                // Field 4 Varint
                case 32:
                    instance.label = (global::Google.Protobuf.FieldDescriptorProto.Label)ReadUInt64(stream);
                    continue;
                // Field 5 Varint
                case 40:
                    instance.type = (global::Google.Protobuf.FieldDescriptorProto.Type)ReadUInt64(stream);
                    continue;
                // Field 6 LengthDelimited
                case 50:
                    instance.TypeName = ReadString(stream);
                    continue;
                // Field 2 LengthDelimited
                case 18:
                    instance.Extendee = ReadString(stream);
                    continue;
                // Field 7 LengthDelimited
                case 58:
                    instance.DefaultValue = ReadString(stream);
                    continue;
                // Field 8 LengthDelimited
                case 66:
                    if (instance.Options == null)
                        instance.Options = global::Google.Protobuf.FieldOptions.DeserializeLengthDelimited(stream);
                    else
                        global::Google.Protobuf.FieldOptions.DeserializeLengthDelimited(stream, instance.Options);
                    continue;
            }

            var key = ReadKey((byte)keyByte, stream);

            // Reading field ID > 16 and unknown field ID/wire type combinations
            switch (key.Field)
            {
                case 0:
                    throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
                default:
                    SkipKey(stream, key);
                    break;
            }
        }

        return instance;
    }

    /// <summary>Read the given number of bytes from the stream and deserialze it into the instance.</summary>
    public static global::Google.Protobuf.FieldDescriptorProto DeserializeLength(Stream stream, int length, global::Google.Protobuf.FieldDescriptorProto instance)
    {
        instance.label = global::Google.Protobuf.FieldDescriptorProto.Label.LABEL_OPTIONAL;
        instance.type = global::Google.Protobuf.FieldDescriptorProto.Type.TYPE_DOUBLE;
        long limit = stream.Position + length;
        while (true)
        {
            if (stream.Position >= limit)
            {
                if (stream.Position == limit)
                    break;
                else
                    throw new ProtocolBufferException("Read past max limit");
            }
            int keyByte = stream.ReadByte();
            if (keyByte == -1)
                throw new System.IO.EndOfStreamException();
            // Optimized reading of known fields with field ID < 16
            switch (keyByte)
            {
                // Field 1 LengthDelimited
                case 10:
                    instance.Name = ReadString(stream);
                    continue;
                // Field 3 Varint
                case 24:
                    instance.Number = (int)ReadUInt64(stream);
                    continue;
                // Field 4 Varint
                case 32:
                    instance.label = (global::Google.Protobuf.FieldDescriptorProto.Label)ReadUInt64(stream);
                    continue;
                // Field 5 Varint
                case 40:
                    instance.type = (global::Google.Protobuf.FieldDescriptorProto.Type)ReadUInt64(stream);
                    continue;
                // Field 6 LengthDelimited
                case 50:
                    instance.TypeName = ReadString(stream);
                    continue;
                // Field 2 LengthDelimited
                case 18:
                    instance.Extendee = ReadString(stream);
                    continue;
                // Field 7 LengthDelimited
                case 58:
                    instance.DefaultValue = ReadString(stream);
                    continue;
                // Field 8 LengthDelimited
                case 66:
                    if (instance.Options == null)
                        instance.Options = global::Google.Protobuf.FieldOptions.DeserializeLengthDelimited(stream);
                    else
                        global::Google.Protobuf.FieldOptions.DeserializeLengthDelimited(stream, instance.Options);
                    continue;
            }

            var key = ReadKey((byte)keyByte, stream);

            // Reading field ID > 16 and unknown field ID/wire type combinations
            switch (key.Field)
            {
                case 0:
                    throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
                default:
                    SkipKey(stream, key);
                    break;
            }
        }

        return instance;
    }

    /// <summary>Serialize the instance into the stream</summary>
    public static void Serialize(Stream stream, FieldDescriptorProto instance)
    {
        using (var msField = new MemoryStream())
        {
            if (instance.Name != null)
            {
                // Key for field: 1, LengthDelimited
                stream.WriteByte(10);
                WriteBytes(stream, Encoding.UTF8.GetBytes(instance.Name));
            }
            // Key for field: 3, Varint
            stream.WriteByte(24);
            WriteUInt64(stream,(ulong)instance.Number);
            // Key for field: 4, Varint
            stream.WriteByte(32);
            WriteUInt64(stream,(ulong)instance.label);
            // Key for field: 5, Varint
            stream.WriteByte(40);
            WriteUInt64(stream,(ulong)instance.type);
            if (instance.TypeName != null)
            {
                // Key for field: 6, LengthDelimited
                stream.WriteByte(50);
                WriteBytes(stream, Encoding.UTF8.GetBytes(instance.TypeName));
            }
            if (instance.Extendee != null)
            {
                // Key for field: 2, LengthDelimited
                stream.WriteByte(18);
                WriteBytes(stream, Encoding.UTF8.GetBytes(instance.Extendee));
            }
            if (instance.DefaultValue != null)
            {
                // Key for field: 7, LengthDelimited
                stream.WriteByte(58);
                WriteBytes(stream, Encoding.UTF8.GetBytes(instance.DefaultValue));
            }
            if (instance.Options != null)
            {
                // Key for field: 8, LengthDelimited
                stream.WriteByte(66);
                ﻿msField.SetLength(0);
                global::Google.Protobuf.FieldOptions.Serialize(msField, instance.Options);
                // Length delimited byte array
                uint length8 = (uint)msField.Length;
                WriteUInt32(stream, length8);
                msField.WriteTo(stream);

            }
        }
    }

    /// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
    public static byte[] SerializeToBytes(FieldDescriptorProto instance)
    {
        using (var ms = new MemoryStream())
        {
            Serialize(ms, instance);
            return ms.ToArray();
        }
    }
    /// <summary>Helper: Serialize with a varint length prefix</summary>
    public static void SerializeLengthDelimited(Stream stream, FieldDescriptorProto instance)
    {
        var data = SerializeToBytes(instance);
        WriteUInt32(stream, (uint)data.Length);
        stream.Write(data, 0, data.Length);
    }
}
