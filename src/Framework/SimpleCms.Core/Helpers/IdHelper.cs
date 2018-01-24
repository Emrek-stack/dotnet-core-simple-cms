using System;

namespace SimpleCms.Core.Helpers
{
    public static class IdHelper
    {
        public static Guid GenerateId(string guid = "")
        {
            return string.IsNullOrEmpty(guid) ? Guid.NewGuid() : new Guid(guid);
        }
    }
}