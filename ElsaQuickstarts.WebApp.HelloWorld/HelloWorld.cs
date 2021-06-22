using Elsa.Activities.Http;
using Elsa.Builders;
using System.Net;

namespace ElsaQuickstarts.WebApp.HelloWorld
{
    /// <summary>
    /// A workflow that is triggered when HTTP requests are made to /hello-world and writes a response.
    /// </summary>
    public class HelloWorld : IWorkflow
    {
        public void Build(IWorkflowBuilder builder)
        {
            builder
                .HttpEndpoint("/hello-world")
                .WriteHttpResponse(HttpStatusCode.OK, "<h1>Hello World!</h1>", "text/html");
        }
    }
}
