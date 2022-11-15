using Tms.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Tms.Permissions
{
    public class TmsPermissionDefinitionProvider: PermissionDefinitionProvider
    {

        public override void Define(IPermissionDefinitionContext context)
        {
            var Tms = context.AddGroup(TmsPermissions.Tms, L("Tms"), MultiTenancySides.Both);

            var Car = Tms.AddPermission(TmsPermissions.Car.Default, L("Car"));
            Car.AddChild(TmsPermissions.Car.Update, L("Edit"));
            Car.AddChild(TmsPermissions.Car.Delete, L("Delete"));
            Car.AddChild(TmsPermissions.Car.Create, L("Create"));

            //Code generation...
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TmsResource>(name);
        }
    }
}
