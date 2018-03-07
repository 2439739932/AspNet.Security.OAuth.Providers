﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OAuth.Weibo
{
    /// <summary>
    /// Defines a set of options used by <see cref="WeiboAuthenticationHandler"/>.
    /// </summary>
    public class WeiboAuthenticationOptions : OAuthOptions
    {
        public WeiboAuthenticationOptions()
        {
            AuthenticationScheme = WeiboAuthenticationDefaults.AuthenticationScheme;
            DisplayName = WeiboAuthenticationDefaults.DisplayName;
            ClaimsIssuer = WeiboAuthenticationDefaults.Issuer;
            CallbackPath = new PathString(WeiboAuthenticationDefaults.CallbackPath);

            AuthorizationEndpoint = WeiboAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = WeiboAuthenticationDefaults.TokenEndpoint;           
            UserInformationEndpoint = WeiboAuthenticationDefaults.UserInformationEndpoint;

            Scope.Add("email");
        }

        /// <summary>
        /// Gets or sets the address of the endpoint exposing
        /// the email addresses associated with the logged in user.
        /// </summary>
        public string UserEmailsEndpoint { get; set; } = WeiboAuthenticationDefaults.UserEmailsEndpoint;
    }
}
