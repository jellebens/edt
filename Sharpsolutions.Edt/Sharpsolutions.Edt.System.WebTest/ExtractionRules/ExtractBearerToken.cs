using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.WebTesting;
using Newtonsoft.Json;

namespace Sharpsolutions.Edt.System.WebTest.ExtractionRules {
    
    [DisplayName("Extract Bearer Token")]
    public class ExtractBearerToken : ExtractionRule {
        private class Respone {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
        }
        [DisplayName("Set to true for use in the header")]
        public bool AsHeaderValue { get; set; }

        public override void Extract(object sender, ExtractionEventArgs e) {
            if (e.Response.BodyString != null)
            {
                if (e.Response.StatusCode == HttpStatusCode.OK)
                {
                    var json = e.Response.BodyString;
                    Respone r = JsonConvert.DeserializeObject<Respone>(json);
                    if (AsHeaderValue)
                    {
                        e.WebTest.Context.Add(this.ContextParameterName, string.Format("Bearer {0}", r.access_token));
                    }
                    else
                    {
                        e.WebTest.Context.Add(this.ContextParameterName, r.access_token);
                    }
                    
                    e.Message = string.Format("Extracted Bearertoken into: {0}",this.ContextParameterName);
                    e.Success = true;
                }
                else
                {
                    e.Message = string.Format("Authentication failed: {0} ", e.Response.BodyString);
                    e.Success = false;
                }

            }
            else
            {
                e.Message = "No response or response empty";
                e.Success = false;
            }
            
        }
    }
}
