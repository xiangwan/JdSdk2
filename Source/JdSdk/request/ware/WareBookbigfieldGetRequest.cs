﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareBookbigfieldGetRequest : JdRequestBase<WareBookbigfieldGetResponse>
    {
        public String SkuId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.bookbigfield.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("sku_id" ,this.SkuId);
        }

    }

}
