﻿using Messaging.Interfaces;
using Messaging.Serializer;

namespace Messaging.Types
{
    public class ValueType<T> : Data<T>
        where T : struct
    {
        public ValueType() : base(default, new ValueTypeSerializer<T>())
        {

        }

        public ValueType(T value) : base(value, new ValueTypeSerializer<T>())
        {

        }

        public ValueType(T value, ISerializer<T> serializer) : base(value, serializer)
        {

        }
        
        public override void Clear()
        {
            Value = default;
        }
    }
}
