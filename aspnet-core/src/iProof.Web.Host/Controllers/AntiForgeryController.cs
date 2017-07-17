using iProof.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace iProof.Web.Host.Controllers
{
    public class AntiForgeryController : iProofControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}