﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WKT.Model
{
	/// <summary>
	///  表'ReviewBill'的查询实体表示.
	/// </summary>
	/// <remarks>
	/// 该实体由工具生成，请根据实际需求修改本类
	/// </remarks>
	[DataContract]
	public partial class ReviewBillQuery :QueryBase
	{
        /// <summary>
        /// 父级编号
        /// </summary>
        [DataMember]
        public Int64? PItemID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [DataMember]
        public Int64 ItemID { get; set; }
		
	    public ReviewBillQuery()
        {
        }
	}
}
