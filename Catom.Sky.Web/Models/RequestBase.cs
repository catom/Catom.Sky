using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catom.Sky.Web.Models
{
    #region Request 请求过滤条件

    /// <summary>
    ///  请求条件封装器，每个Dto写一个继承此类的过滤子类。
    ///  此类是作为Request的成员类。
    /// </summary>
    public abstract class RequestFilter
    {
    }

    /// <summary>
    ///  请求参数封装基类。
    ///  使用方式：
    ///     1. Dto 继承 RequestFilter 封装请求条件参数，DtoRequestFilter；
    ///     2. DtoRequest 继承 BaseRequest，以 DtoRequestFilter 作为泛型实例；
    ///     3. 在 Controller 中以 DtoRequest 作为请求参数。
    ///     
    ///  eg,
    ///            var queryCondition = {};
    ///            queryCondition = {
    ///                filter: {
    ///                    isShowNormal: true
    ///                },
    ///                page: {
    ///                    pageIdx: pageIdx,
    ///                    pageSize: pageSize
    ///                }
    ///            };
    ///            return $http.post("/ClassService/GetClassList", queryCondition);
    ///  eg.
    ///         href="..../request.id=1" 注入给 DtoRequest.request.id 字段。
    /// </summary>
    /// <typeparam name="T">Dto过滤条件</typeparam>
    public abstract class BaseRequest<T> where T : RequestFilter
    {
        // 请求名称
        public string key { get; set; }

        // 请求条件封装实体
        public T filter { get; set; }

        // 分页器
        public PageRequest page { get; set; }

        // 高级搜索实体
        public AdvancedSearch1 advancedSearch { get; set; }

    }

    /// <summary>
    ///  页数参数实体，配合 Helper 中的 PageCondition 使用。
    /// </summary>
    public sealed class PageRequest
    {
        public PageRequest()
        {
        }

        public PageRequest(int pageIdx, int pageSize)
        {
            this.pageIdx = pageIdx;
            this.pageSize = pageSize;
        }

        public int pageIdx { get; set; }

        public int pageSize { get; set; }
    }

    /// <summary>
    ///  分页器。
    /// </summary>
    public class PageCondition
    {
        public PageCondition(int pageIndex, int pageSize)
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
        }

        // Fields with default value;
        private int _itemCount;
        private int _pageSize;
        private int _pageIndex;

        // 总页数
        public int PageCount { get; private set; }

        // 页号
        public int PageIndex
        {
            get
            {
                return this._pageIndex;
            }
            private set
            {
                this._pageIndex = value;
            }
        }

        // 页面量
        public int PageSize
        {
            get
            {
                return this._pageSize;
            }
            private set
            {
                this._pageSize = value;
            }
        }

        // 依据实体属性生成 Limit 的 MySQL 语句。
        public string ToSQLString()
        {
            return string.Format(" limit {0},{1}", (this.PageIndex - 1) * this._pageSize, this._pageSize);
        }

        // 自动设置 PageCount
        public int ItemCount
        {
            get
            {
                return this._itemCount;
            }
            set
            {
                if (value > 0)
                {
                    _itemCount = value;
                    PageCount = ((_itemCount - 1) / this._pageSize) + 1;
                    if (PageIndex > PageCount)
                    {
                        PageIndex = PageCount;
                    }
                }
            }
        }


    }

    #endregion


    #region Response 响应结果参数
    // 基类
    public class ResponseResultBase<T>
    {
        /// <summary>
        /// 执行成功与否。
        /// 1表示成功,0表示失败。
        /// 默认为1.
        /// </summary>
        public short status { get; set; }

        /// <summary>
        /// 错误编码。默认为0，表示没有错误。
        /// 定义在统一的地方。
        /// </summary>
        public int error { get; set; }

        /// <summary>
        /// 错误文案。默认为空字符串。
        /// 直接由后端返回错误原因，一般直接是error对应的错误文案，将来可以由前端再次定义。
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// 最重要的返回数据。
        /// 可以是number,bool,string,array,object
        /// </summary>
        public T data { get; set; }

        public ResponseResultBase()
        {
            status = 1;
            error = 0;
            message = string.Empty;
        }

        public ResponseResultBase(T td)
        {
            status = 1;
            error = 0;
            message = string.Empty;
            data = td;
        }
    }

    // 单对象的返回响应
    public class ResponseResult : ResponseResultBase<object>
    {
    }

    public sealed class ResponseListData
    {
        public Array list { get; set; }
        public ResponsePage page { get; set; }
    }

    // 列表对象的返回响应
    public class ResponseListResult : ResponseResultBase<ResponseListData>
    {
    }
    
    public sealed class ResponsePage
    {
        public int totalCount { get; set; }
        public int currentIdx { get; set; }
        public int itemCount { get; set; }
    }

    #endregion


    #region 高级搜索
    public sealed class AdvancedSearch1
    {
        // 搜索类型（精确、模糊）
        public int searchType { get; set; }

        // 搜索条件
        public string search { get; set; }
    }
    #endregion



}