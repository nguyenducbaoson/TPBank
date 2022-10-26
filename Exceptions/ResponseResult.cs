using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ResponseResult
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public static bool IsLogin { get; set; }
        public ResponseResult()
        {
            this.IsSuccess = true;
        }
        public ResponseResult(string errorMessage)
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
