using System;
using System.IO;
using System.Net;

namespace SistemasDistribuidos.FormsApp
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class ClienteRestCSharp
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public ClienteRestCSharp()
        {
            endPoint = String.Empty;
            httpMethod = httpVerb.GET;
        }
        public string FazerSolicitacao()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            return strResponseValue;
        }
    }

    class ClienteRestCSharpPost
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public ClienteRestCSharpPost()
        {
            endPoint = String.Empty;
            httpMethod = httpVerb.POST;
        }
        public string FazerSolicitacao()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            return strResponseValue;
        }
    }

    class ClienteRestCSharpPostCpf
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public ClienteRestCSharpPostCpf()
        {
            endPoint = String.Empty;
            httpMethod = httpVerb.POST;
        }
        public string FazerSolicitacao()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            return strResponseValue;
        }
    }

}
