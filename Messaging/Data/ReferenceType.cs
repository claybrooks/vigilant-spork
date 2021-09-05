﻿using Messaging.Abstractions;

namespace Messaging.Data
{
    public abstract class ReferenceType<T> : Data<T>
    {
        public ReferenceType(T value) : base(value)
        {

        }
    }
}
