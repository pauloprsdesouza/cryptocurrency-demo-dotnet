﻿using System.Collections.Generic;

namespace Cryptocurrency.Quotation.Contracts
{
    public class ResponseError
    {
        public List<string> Errors { get; set; }

        public ResponseError() { }

        public ResponseError(List<string> errors)
        {
            Errors = errors;
        }

        public ResponseError(string error)
        {
            Errors = new List<string>() { error };
        }
    }
}
