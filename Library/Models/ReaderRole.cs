using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 读者角色实体类
    /// </summary>
    [Serializable]
    public class ReaderRole
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public int AllowDay { get; set; }

        public int AllowCounts { get; set; }
    }
}
