﻿using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AbpMauiBlazorClient.Services
{
    //AuthProvider.cs
    public class AuthProvider : AuthenticationStateProvider
    {
        private readonly HttpClient HttpClient;
        public string UserName { get; set; }

        public AuthProvider(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //这里获得用户登录状态
            var result = await HttpClient.GetFromJsonAsync<string>($"api/Auth/GetUser");

            if (result == null)
            {
                MarkUserAsLoggedOut();
                return new AuthenticationState(new ClaimsPrincipal());
            }
            else
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, result));
                var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "apiauth"));
                return new AuthenticationState(authenticatedUser);
            }
        }

        /// <summary>
        /// 标记授权
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public void MarkUserAsAuthenticated(string userDto)
        {
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", userDto);
            UserName = userDto;

            //此处应该根据服务器的返回的内容进行配置本地策略，作为演示，默认添加了“Admin”
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, userDto));
            claims.Add(new Claim("Admin", "Admin"));

            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "apiauth"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);

            //慈湖可以可以将Token存储在本地存储中，实现页面刷新无需登录
        }

        /// <summary>
        /// 标记注销
        /// </summary>
        public void MarkUserAsLoggedOut()
        {
            HttpClient.DefaultRequestHeaders.Authorization = null;
            UserName = null;

            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(anonymousUser));
            NotifyAuthenticationStateChanged(authState);
        }
    }

}
