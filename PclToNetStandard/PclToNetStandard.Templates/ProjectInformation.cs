﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PclToNetStandard.Templates
{
    internal class ProjectInformation
    {
        public string PackageVersion { get; set; }
        public string Authors { get; set; }
        public string Company { get; set; }
        public string Product { get; set; }
        public string PackageId { get; set; }
        public string Copyright { get; set; }
        public string AssemblyVersion { get; set; }
        public string FileVersion { get; set; }
        public string Description { get; set; }
        public string PackageLicenseUrl { get; set; }
        public string PackageProjectUrl { get; set; }
        public string PackageIconUrl { get; set; }
        public string RepositoryUrl { get; set; }
        public string RepositoryType { get; set; }
        public string PackageTags { get; set; }
        public string PackageReleaseNotes { get; set; }
        public string NeutralLanguage { get; set; }
    }
}