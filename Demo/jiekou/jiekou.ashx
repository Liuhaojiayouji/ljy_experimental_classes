<%@ WebHandler Language="C#" Class="jiekou" %>

using System;
using System.Web;
using Model;
using Newtonsoft.Json;
public class jiekou : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        AccNum accNum = new AccNum()
        {
            ID = 10,
            accNumber = "asd",
            password = "qwe"
        };
        context.Response.Write(JsonConvert.SerializeObject(accNum));
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}