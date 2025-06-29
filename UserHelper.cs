using System;
using Welcome.Model;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ToUserString(this User user)
        {
            return $"ID: {user.Id}, Name: {user.Names}, Role: {user.Role}, Age: {user.Age}";
        }
    }
}
