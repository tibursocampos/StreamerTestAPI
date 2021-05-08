namespace SS_API.Services.Dto
{
    /// <summary>
    /// Classe para padronizar as respostas da API
    /// </summary>
    public class ResponseDto
    {
        /// <summary>
        /// Booleano para retorno verdadeiro ou falso
        /// </summary>
        public bool Success { get; set; }
       
        /// <summary>
        /// Inteiro para retorno do ID do projeto
        /// </summary>
        public int ProjectId { get; set; }
        
        /// <summary>
        /// Mensagem de erro
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Envia True e o ID do registro criado
        /// </summary>
        /// <returns></returns>
        public ResponseDto Created(int id)
        {
            Success = true;
            ProjectId = id;
            return this;
        }

        /// <summary>
        /// Envia True quando executada a ação
        /// </summary>
        /// <returns></returns>
        public ResponseDto Executed()
        {
            Success = true;
            return this;
        }

        /// <summary>
        /// Retorna Falso e a mensagem de erro
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
        /// Retorna Falso e a mensagem de erro
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
