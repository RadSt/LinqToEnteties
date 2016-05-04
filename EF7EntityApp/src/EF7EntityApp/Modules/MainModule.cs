using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Nancy;

namespace EF7EntityApp.Modules
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = (_, ctx) => Task.FromResult<dynamic>(View["index.html"]);
            Get["/hello"] = (_, ctx) => Task.FromResult<dynamic>(Response.AsText("Hello"));
        }
    }
}