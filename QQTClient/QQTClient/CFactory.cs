using System;
using System.Collections.Generic;
using System.Text;
using OpenTSDK.Tencent;

namespace QQTClient.Logic
{
    public class CFactory
    {
        private static string _appKey = "474173220d3443748d4caf9a84d9c5b5";
        private static string _appSecret = "c18c32903485c9a54b9f76e997fcac0f";
        private static OAuth _Auth;

        /// <summary>
        /// 应用key
        /// </summary>
        public static string appKey
        {
            get
            {
                return _appKey;
            }
        }

        /// <summary>
        /// 应用secret
        /// </summary>
        public static string appSecret
        {
            get
            {
                return _appSecret;
            }
        }

        /// <summary>
        /// 验证对象
        /// </summary>
        public static OAuth Auth
        {
            get
            {
                if (null == _Auth)
                    _Auth =  new OAuth(_appKey, _appSecret);
                return _Auth;
            }
        }
    }
}
