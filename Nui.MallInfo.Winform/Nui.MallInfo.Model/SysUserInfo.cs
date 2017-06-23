using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nui.MallInfo.Model
{
   public class SysUserInfo
    {
       /// <summary>
       /// 用户编号
       /// </summary>
       public int UserId { get; set; }
       /// <summary>
       /// 用户账号
       /// </summary>
       public string U_Account { get; set; }
       /// <summary>
       /// 用户名称
       /// </summary>
       public string U_Name { get; set; }
       /// <summary>
       /// 密码
       /// </summary>
       public string U_PassWord { get; set; }
       /// <summary>
       /// 手机电话
       /// </summary>
       public string U_Phone { get; set; }
       /// <summary>
       /// 邮箱
       /// </summary>
       public string U_Email { get; set; }
       /// <summary>
       /// 角色Id
       /// </summary>
       public int U_RoleId { get; set; }
       /// <summary>
       /// 角色名称
       /// </summary>
       public string U_RoleName { get; set; }
       /// <summary>
       /// 创建日期
       /// </summary>
       public DateTime CREATE_DATE { get; set; }
       public int U_Type { get; set; }
       public int U_Status { get; set; }
       /// <summary>
       /// 编辑备注
       /// </summary>
       public string MemoText { get; set; }
       /// <summary>
       /// 编辑人
       /// </summary>
       public string EditUser { get; set; }
       /// <summary>
       /// 编辑日期
       /// </summary>
       public DateTime? EditDate { get; set; }
    }
}
