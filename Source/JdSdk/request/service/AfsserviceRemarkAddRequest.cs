﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceRemarkAddRequest : JdRequestBase<AfsserviceRemarkAddResponse>
    {
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        public String Remark
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.remark.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("afsServiceId" ,this.AfsServiceId);
            paramters.Add("remark" ,this.Remark);
        }

    }

}
