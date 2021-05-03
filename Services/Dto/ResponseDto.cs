using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Services.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class ResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ProjectId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ResponseDto Created(int id)
        {
            Success = true;
            ProjectId = id;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ResponseDto Executed()
        {
            Success = true;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        public ResponseDto BadRequest(string validationMessage)
        {
            Success = false;
            ErrorMessage = validationMessage;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        public ResponseDto NotFound(string validationMessage)
        {
            Success = false;
            ErrorMessage = validationMessage;
            return this;
        }
    }
}
