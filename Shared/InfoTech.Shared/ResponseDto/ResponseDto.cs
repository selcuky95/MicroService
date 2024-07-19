using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTech.Shared.ResponseDto
{
    // Factory Design Pattern
    public class ResponseDto<T>
    {
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        [JsonIgnore]
        public bool isSucceed { get; set; }

        public static ResponseDto<T> Success(T data, int statusCode){
            return new ResponseDto<T> { 
                Data = data,
                StatusCode = statusCode,
                isSucceed = true
            };
        }

        public static ResponseDto<T> Success(int statusCode){
            return new ResponseDto<T>{
                Data = default(T),
                StatusCode = statusCode,
                isSuccess = true
            };
        }

        public static ResponseDto<T> Fail(List<string> errors, int statusCode){
            return new ResponseDto<T>{
                Errors = errors,
                StatusCode = statusCode,
                isSucceed = false
            };
        }

        public static ResponseDto<T> Fail(string error, int statusCode){
            return new ResponseDto<T>{
                Errors = new List<string>{error},
                StatusCode = statusCode,
                isSucceed = false
            };
        }
     }
}