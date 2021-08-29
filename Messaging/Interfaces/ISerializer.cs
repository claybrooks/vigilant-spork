﻿
namespace Messaging.Interfaces
{
    public interface ISerializer
    {
        int Length();
    }

    public interface ISerializer<T> : ISerializer
    {
        byte[] Serialize(T value);

        int Serialize(T value, byte[] data, int offset);

        bool Deserialize(ref T value, byte[] data, int offset);
    }
}