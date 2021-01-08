namespace Api.Domain.Utils
{
    public class ForgotPassworBodyEmail
    {
        private string token;
        public string FORGOT_PASSWORD_BODY;
        public ForgotPassworBodyEmail(string token)
        {
            this.token = token;
            this.FORGOT_PASSWORD_BODY = "<head>" +
            "<title> Recuperação de Senha </title>" +
            "</head>" +
            "<body>" +
            "<h3> Clique no link abaixo para recuperar sua senha</h3>" +
            "http://localhost:3333/recoveryPassword"+$"?token={token}" +
            "</body>";
        }

    }
}
