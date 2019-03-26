﻿namespace SoundCloud.Api.Web
{
    internal sealed class SuccessWebResult<T> : WebResult<T>
    {
        internal SuccessWebResult(T data) : base(true, data)
        {
        }
    }
}