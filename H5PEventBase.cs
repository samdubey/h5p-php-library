using System;

namespace H5P
{
    public abstract class H5PEventBase
    {
        protected string Type { get; set; }
        protected string SubType { get; set; }
        protected int ContentId { get; set; }
        protected int ContentUserId { get; set; }
        protected int UserId { get; set; }
        protected string SiteId { get; set; }
        protected string SiteUrl { get; set; }
        protected string SiteName { get; set; }
        protected string H5PVersion { get; set; }
        protected string H5PLibraryName { get; set; }
        protected string H5PLibraryVersion { get; set; }
        protected DateTime CreatedAt { get; set; }

        protected H5PEventBase(string type, string subType, int contentId, int contentUserId, int userId, string siteId, string siteUrl, string siteName, string h5pVersion, string h5pLibraryName, string h5pLibraryVersion)
        {
            Type = type;
            SubType = subType;
            ContentId = contentId;
            ContentUserId = contentUserId;
            UserId = userId;
            SiteId = siteId;
            SiteUrl = siteUrl;
            SiteName = siteName;
            H5PVersion = h5pVersion;
            H5PLibraryName = h5pLibraryName;
            H5PLibraryVersion = h5pLibraryVersion;
            CreatedAt = DateTime.UtcNow;
        }

        public abstract void Save();
    }
}