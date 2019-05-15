namespace SIS.HTTP.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class BadRequestException : Exception
    {
        private const string BadRequestExceptionDefaultMessage = "The Request was malformed or contains unsupported elements.";

        public BadRequestException() : this(BadRequestExceptionDefaultMessage)
        {

        }

        public BadRequestException(string name) : base(name)
        {
           
        }
    }
}
