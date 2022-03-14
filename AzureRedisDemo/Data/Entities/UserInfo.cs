using System;

namespace AzureRedisDemo.Data.Entities
{
    [Serializable]
    public class UserInfo
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
