using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catom.Sky.Services
{
    /// <summary>
    ///  业务处理结果信息。
    ///  用法：new ServiceResult(true, "获取成功") { Data = user };
    /// </summary>
    public class ServiceResult
    {
        #region fileds
        // 业务处理状态
        public bool Status { get; set; }

        // 错误码
        public string Code { get; set; }

        // 业务处理信息
        public string Message { get; set; }

        // 数据，可以是实体或者实体集
        public object Data { get; set; }
        #endregion

        #region constructor
        public ServiceResult() : base() { }

        public ServiceResult(bool status, string code, string message)
        {
            this.Status = status;
            this.Code = code;
            this.Message = message;
        }

        public ServiceResult(bool status, string message)
        {
            this.Status = status;
            this.Message = message;
        }
        #endregion
    }
}
