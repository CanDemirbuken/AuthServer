using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.DTOs
{
    public class TokenDto
    {
        // JSON Token base64 encoded bir string olduğundan dolayı string olarak tanımlanır
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpiration { get; set; }

        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}
