using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Models
{
    public static class MakeDojos
    {
        public static void SetDojoDachi(HttpContext context, Dojo dachi)
        {
            context.Session.SetString("dojo", JsonConvert.SerializeObject(dachi));
        }
        public static Dojo GetDojoDachi(HttpContext context)
        {
            string dojodachi = context.Session.GetString("dojo");
            if(dojodachi == null)
            {
                Dojo dachi = new Dojo();
                context.Session.SetString("dojo", JsonConvert.SerializeObject(dachi));
                return dachi;
            }
            else
            {
                Dojo dachi = JsonConvert.DeserializeObject<Dojo>(dojodachi);
                return dachi;
            }
        }
    }
}
