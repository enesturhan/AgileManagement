using AgileManagement.Core.Dtos;
using Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.Services
{

    /// <summary>
    /// Kullanıcın e-posta parola ve oturum açık kalsın seçeneğine göre sisteme giriş yapmasını oturum açmasını sağlayan servis. Bu servis üzerinden sisteme login olacağız. Task yazmamızın sebebi ise bir sistemde oturum açma istediği farklı servisler üzerinden olabilir Google,Facebook vs gibi bu durumda başka bir servise uygulamamız içerisinden bağlandığımız için bir müddet süre geçeceğinden asenkron bir iş yapılması daha doğtu olacaktır.
    /// </summary>
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);

        Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

        //refresh token silme null icin set etmek icin kullanılabilir.
        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);

        //5 taneye kadar app setting dosyasında tutulaiblir fazlası ise databasede tutmak mantıklıdır.
        Response<ClientTokenDto> CreteTokenByClient(ClientLoginDto clientLoginDto);

    }



}
