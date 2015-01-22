using System.Collections.Generic;
using System.Reflection;

namespace System
{
    public static class Extension
    {
        public static bool IsInstanceOfType(this Type type, object obj)
        {
            return obj != null && type.GetTypeInfo().IsAssignableFrom(obj.GetType().GetTypeInfo());
        }

        public static IEnumerable<FieldInfo> GetFields(this Type type)
        {
            return type.GetRuntimeFields();
        }
    }
}
