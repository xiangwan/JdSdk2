﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Imgzone
{
﻿    [Serializable]
    public class ImgzoneCategoryAddResponse : JdResponse
    {
        [JsonProperty("return_code")]
        public Nullable<Int32> ReturnCode
        {
            get;
            set;
        }

        [JsonProperty("desc")]
        public String Desc
        {
            get;
            set;
        }

        [JsonProperty("cate_id")]
        public Nullable<Int32> CateId
        {
            get;
            set;
        }

    }

}