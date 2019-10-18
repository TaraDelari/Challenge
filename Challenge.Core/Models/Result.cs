using System;

namespace Challenge.Core.Models
{
    public class Result
    {
        protected string _error;

        public bool Succeeded { get; set; }

        public string Error
        {
            get
            {
                return _error;
            }
            set
            {
                Succeeded = false;
                _error = value;
            }
        }

        public Result()
        {
            Succeeded = true;
        }
    }

    public class Result<T> : Result
    {
        public T Data { get; set; }

        public Result() : base() { }

        public Result(T data) : base()
        {
            Data = data;
        }
    }
}
