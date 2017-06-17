using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;
using CharacterGen.Common.Exceptions;

namespace CharacterGen.Api.Filters
{
    //TODO: Make a unit test for this
    public class GlobalExceptionHandler : ExceptionHandler
    {
        private static Dictionary<Type, HttpStatusCode> StatusCodeMapping;

        public GlobalExceptionHandler()
        {
            StatusCodeMapping = new Dictionary<Type, HttpStatusCode>()
            {
                { typeof(ArgumentException), HttpStatusCode.BadRequest },
                { typeof(ResourceNotFoundException), HttpStatusCode.NotFound },
                { typeof(ResourceNotFoundException), HttpStatusCode.NotFound },
            };
        }

        public override void Handle(ExceptionHandlerContext context)
        {
            var exception = context.Exception;
            var message = exception.Message;
            var stackTrace = exception.StackTrace;
            var statusCode = HttpStatusCode.InternalServerError; //Default to 500


            StatusCodeMapping.TryGetValue(context.Exception.GetType(), out statusCode);

            //Return a DTO representing what happened
            context.Result = new ResponseMessageResult(context.Request.CreateResponse(statusCode, 
                new ExceptionResult()
                {
                    Exception = exception.ToString(),
                    Message = message,
                    StackTrace = stackTrace
                })
            );
        }
    }

    public class ExceptionResult
    {
        public string Exception { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}