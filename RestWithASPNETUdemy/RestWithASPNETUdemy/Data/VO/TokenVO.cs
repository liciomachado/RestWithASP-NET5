namespace RestWithASPNETUdemy.Data.VO
{
    public class TokenVO
    {
        public TokenVO(bool authenticated, string created, string username, string expiration, string accessToken, string refreshToken)
        {
            Authenticated = authenticated;
            Created = created;
            Username = username;
            Expiration = expiration;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
        
        public bool Authenticated { get; set; }
        public string Created { get; set; }
        public string Username { get; set; }
        public string Expiration { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
