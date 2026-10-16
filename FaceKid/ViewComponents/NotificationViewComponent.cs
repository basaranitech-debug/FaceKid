using FaceKid.Entities;
using FaceKid.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FaceKid.ViewComponents
{
    public class NotificationViewComponent : ViewComponent
    {
        private readonly INotificationService _service;
        private readonly UserManager<ApplicationUser> _userManager;

        public NotificationViewComponent(INotificationService service, UserManager<ApplicationUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = _userManager.GetUserId(UserClaimsPrincipal);
            if (string.IsNullOrEmpty(userId))
            {
                return Content(string.Empty);
            }
            var notification = await _service.GetByUserIdAsync(userId);
            return View(notification);
        }
    }
}
