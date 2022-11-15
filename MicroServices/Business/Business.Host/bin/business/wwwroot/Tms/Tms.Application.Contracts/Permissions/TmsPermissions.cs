using System;
using System.Collections.Generic;
using System.Text;

namespace Tms.Permissions
{
    public static class TmsPermissions
    {
        public const string Tms = "Tms";

        public static class Car
        {
            public const string Default = Tms + ".Car";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }

        //Code generation...
    }
}
