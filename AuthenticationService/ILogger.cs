using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AuthenticationService
{
    public interface ILogger
    {
        void WriteEvent(string eventMessage);

        void WriteError(string errorMessage);


    }
}
