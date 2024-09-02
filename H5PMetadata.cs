using System;
using System.Collections.Generic;

namespace H5P
{
    public class H5PMetadata
    {
        public string Title { get; set; }
        public string License { get; set; }
        public string LicenseVersion { get; set; }
        public string LicenseExtras { get; set; }
        public string Author { get; set; }
        public string Changes { get; set; }
        public string Source { get; set; }
        public string YearFrom { get; set; }
        public string YearTo { get; set; }
        public string Description { get; set; }
        public string AuthorComments { get; set; }
        public string DefaultLanguage { get; set; }
        public List<string> Keywords { get; set; }
        public List<string> Categories { get; set; }
        public List<string> AdditionalLicenses { get; set; }

        public H5PMetadata()
        {
            Keywords = new List<string>();
            Categories = new List<string>();
            AdditionalLicenses = new List<string>();
        }

        public void AddKeyword(string keyword)
        {
            if (!Keywords.Contains(keyword))
            {
                Keywords.Add(keyword);
            }
        }

        public void AddCategory(string category)
        {
            if (!Categories.Contains(category))
            {
                Categories.Add(category);
            }
        }

        public void AddAdditionalLicense(string license)
        {
            if (!AdditionalLicenses.Contains(license))
            {
                AdditionalLicenses.Add(license);
            }
        }

        public void RemoveKeyword(string keyword)
        {
            if (Keywords.Contains(keyword))
            {
                Keywords.Remove(keyword);
            }
        }

        public void RemoveCategory(string category)
        {
            if (Categories.Contains(category))
            {
                Categories.Remove(category);
            }
        }

        public void RemoveAdditionalLicense(string license)
        {
            if (AdditionalLicenses.Contains(license))
            {
                AdditionalLicenses.Remove(license);
            }
        }

        public override string ToString()
        {
            return $"Title: {Title}, License: {License}, Author: {Author}, Year: {YearFrom}-{YearTo}, Description: {Description}";
        }
    }
}