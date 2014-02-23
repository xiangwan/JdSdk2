﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class EccItemListingRequest : JdRequestBase<EccItemListingResponse>
    {
        public Nullable<Int64> ItemId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.item.listing"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("item_id" ,this.ItemId);
        }

    }

}
