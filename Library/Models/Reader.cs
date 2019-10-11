using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 读者实体类
    /// </summary>
    [Serializable]
    public class Reader
    {
        public int ReaderId { get; set; }
        public string ReadingCard { get; set; }
        public string ReaderName { get; set; }
        public string Gender { get; set; }
        public string IDCard { get; set; }
        public string ReaderAddress { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public string ReaderImage { get; set; }
        public DateTime RegTime { get; set; }
        public string ReaderPwd { get; set; }
        public int AdminId { get; set; }
        public int StatusId { get; set; }


        public string StatusDesc { get; set; }
        public string RoleName { get; set; }

        public int AllowCounts { get; set; }
        public int AllowDay { get; set; }

    }
}
