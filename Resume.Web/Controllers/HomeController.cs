using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.Page;

using System.Threading.Tasks;

namespace Resume.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Constructor
        private readonly IThingIDoService _thingIDoService;
        private readonly ICustomerFeedbackService _customerFeedbackService;

        public HomeController(IThingIDoService thingIDoService, ICustomerFeedbackService customerFeedbackService)
        {
            _thingIDoService = thingIDoService;
            _customerFeedbackService = customerFeedbackService;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            IndexPageViewModel model = new IndexPageViewModel()
            {
                ThingIDoList = await _thingIDoService.GetAllThingIDoForIndex(),
                CustomerFeedbackList = await _customerFeedbackService.GetCustomerFeedbackForIndex()
            };


            return View(model);
        }
    }
}
