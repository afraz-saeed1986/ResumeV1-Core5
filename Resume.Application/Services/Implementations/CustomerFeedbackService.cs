using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.CustomerFeedback;
using Resume.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class CustomerFeedbackService : ICustomerFeedbackService
    {
        #region Constructor
        private readonly AppDbContext _context;
        public CustomerFeedbackService(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        public async Task<List<CustomerFeedbackViewModel>> GetCustomerFeedbackForIndex()
        {
            List<CustomerFeedbackViewModel> customerFeedbacks = await _context.CustomerFeedbacks.OrderBy(c => c.Order).Select(c => new CustomerFeedbackViewModel()
            {
                Order = c.Order,
                Avatar = c.Avatar,
                Description = c.Description,
                Id = c.Id,
                Name = c.Name
            }).ToListAsync();

            return customerFeedbacks;
        }
    }
}
