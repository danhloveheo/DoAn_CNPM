using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_User
    {
        // 0: Tạo mới thành công
        // 1: Đã tồn tại
        public static int Register(string userName, string passWord, string email)
        {
            if (DAO_User.SearchUser(userName) != null)
            {
                return 1;
            }
            DTO_User newUser = new DTO_User();
            newUser.Username = userName;
            newUser.Password = MD5Hash(passWord);
            newUser.Email = email;

            DAO_User.InsertUser(newUser);
            return 0;
        }

        // 0: Đăng nhập thành công
        // 1: Tài khoản không tồn tại
        // 2: Mật khẩu sai
        public static int Login(string userName, string password)
        {
            DTO_User user = DAO_User.SearchUser(userName);

            if (user == null)
            {
                return 1;
            }

            if (user.Password != MD5Hash(password))
            {
                return 2;
            }

            return 0;
        }

        private static string MD5Hash (string password)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(password));

            for(int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }

            return hash.ToString();
        }
    }
}
