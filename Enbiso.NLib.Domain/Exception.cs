﻿using System;

namespace Enbiso.NLib.Domain
{
    /// <inheritdoc />
    /// <summary>
    /// Domain Exception
    /// </summary>
    public class DomainException: Exception
    {
        public DomainException()
        {
        }

        public DomainException(string message) : base(message)
        {
        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}