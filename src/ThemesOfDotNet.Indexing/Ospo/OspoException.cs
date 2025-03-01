﻿using System.Net;
using System.Runtime.Serialization;

namespace ThemesOfDotNet.Indexing.Ospo;

[Serializable]
public class OspoException : Exception
{
    public OspoException()
    {
    }

    public OspoException(string? message)
        : base(message)
    {
    }

    public OspoException(string? message, Exception? inner)
        : base(message, inner)
    {
    }

    protected OspoException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }

    public OspoException(string? message, HttpStatusCode code)
        : this(message)
    {
        Code = code;
    }

    public HttpStatusCode Code { get; }
}
