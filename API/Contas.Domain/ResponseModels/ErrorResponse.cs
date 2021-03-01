using System.Collections.Generic;

namespace Contas.Domain.ResponseModels
{
    public class ErrorResponse
    {
        public List<string> Errors { get; set; }

        public ErrorResponse(List<string> errors)
        {
            Errors = errors;
        }
    }
}
