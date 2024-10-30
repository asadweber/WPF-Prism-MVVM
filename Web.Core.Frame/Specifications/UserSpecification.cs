


using BDO.Core.DataAccessObjects.SecurityModels;

namespace Web.Core.Frame.Specifications
{
    public sealed class UserSpecification : BaseSpecification<owin_userEntity>
    {
        public UserSpecification(string identityId) : base(u => u.IdentityId==identityId)
        {
            AddInclude(u => u.RefreshTokens);
        }
    }
}
