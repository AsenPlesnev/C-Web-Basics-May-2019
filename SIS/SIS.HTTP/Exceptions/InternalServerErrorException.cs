namespace SIS.HTTP.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class InternalServerErrorException : Exception
    {
        private const string InternalServerErrorExceptionDefaultMessage = "The Server has encountered an error.";

        public InternalServerErrorException() : this(InternalServerErrorExceptionDefaultMessage)
        {

        }

        public InternalServerErrorException(string name) : base(name)
        {

        }
    }
}
