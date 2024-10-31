using BDO.Core.DataAccessObjects.Models;
using FluentValidation;
using Web.Core.Frame.Dto.UseCaseRequests;

namespace Web.Api.Models.Validation
{
    /// <summary>
    /// NotificationRegisteredApplicationInfoRequestValidator
    /// </summary>
    public class NotificationRegisteredApplicationInfoRequestValidator : AbstractValidator<notificationregisteredapplicationinfoEntity>
    {
        /// <summary>
        /// NotificationRegisteredApplicationInfoRequestValidator
        /// </summary>
        public NotificationRegisteredApplicationInfoRequestValidator()
        {
            RuleFor(x => x.applicationid).NotEmpty();
            RuleFor(x => x.applicationcodename).Empty();
            RuleFor(x => x.applicationfreindlyname).Empty();
        }
    }
}
