using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using Newtonsoft.Json;

namespace Sharpsolutions.Edt.Data.Eddb {
    public abstract class WebImportBase<TDto> : IWebImport<TDto>
    {
        private string _fileName;

        protected WebImportBase(string fileName)
        {
            _fileName = fileName;
        }

        public IList<TDto> Load()
        {
            using (WebClient client = new WebClient()) {
                client.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate, sdch");
                client.BaseAddress = "http://eddb.io/";
                
                byte[] data = client.DownloadData("archive/v3/" + _fileName);
                using (MemoryStream zippedMemoryStream = new MemoryStream(data)) {
                    using (GZipStream unzipped = new GZipStream(zippedMemoryStream, CompressionMode.Decompress))
                    {
                        using (StreamReader sr = new StreamReader(unzipped)) {
                            using (JsonReader reader = new JsonTextReader(sr)) {
                                JsonSerializer serializer = new JsonSerializer();

                                return serializer.Deserialize<List<TDto>>(reader);
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
