using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GithubOrgSearch.Models
{
    public class OrgRepoDetails
    {
        public string Avatar_image { get; set; }
        public string Forks { get; set; }
        public string Label { get; set; }
        public string Open_issues { get; set; }
        public string Watchers { get; set; }
        public string OrgName { get; set; }
        public string License { get; set; }
    }
}