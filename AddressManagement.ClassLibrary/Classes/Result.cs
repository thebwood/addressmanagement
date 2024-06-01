﻿using System.Net;

namespace AddressManagement.ClassLibrary.Classes
{
    public class Result
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class Result<TValue> : Result
    {
        private readonly TValue? _value;

        protected internal Result(TValue? value, bool isSuccess, Error error)
        {
            _value = value;
        }
    }
}
