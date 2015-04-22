using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServerCustomProperty.Business.Properties;

namespace EPiServerCustomProperty.Models.Pages
{
    [ContentType(DisplayName = "Contact page", GUID = "41f411fa-1a45-4bbe-a73a-ba2996eff0e5", Description = "")]
    public class ContactPage : PageData
    {

        #region Solution 1

        [Required]
        [Display(
            Name = "Country email addresses container page",
            Description = "Country email addresses container page",
            GroupName = "Solution 1",
            Order = 10)]
        public virtual ContentReference CountryEmailAddressContainerPage { get; set; }

        #endregion

        #region Solution 2

        [Required]
        [Display(
            Name = "Belgium email addresses",
            Description = "Belgium email addresses",
            GroupName = "Solution 2",
            Order = 10)]
        public virtual string BelgiumEmailAddress { get; set; }

        [Required]
        [Display(
            Name = "Netherlands email addresses",
            Description = "Netherlands email addresses",
            GroupName = "Solution 2",
            Order = 20)]
        public virtual string NetherlandsEmailAddress { get; set; }

        [Required]
        [Display(
            Name = "Sweden email addresses",
            Description = "Sweden email addresses",
            GroupName = "Solution 2",
            Order = 30)]
        public virtual string SwedenEmailAddress { get; set; }

        #endregion

        #region Solution 3

        [UIHint("CountryEmailAddressesProperty")]
        [Display(
            Name = "Country email addresses",
            Description = "Country email addresses",
            GroupName = "Solution 3",
            Order = 10)]
        [BackingType(typeof(PropertyCountryEmailAddress))]
        public virtual IEnumerable<CountryEmailAddress> CountryEmailAddresses { get; set; }

        #endregion

        #region Solution 4

        [UIHint("MultiPageProperty")]
        [Display(
            Name = "Pages",
            Description = "Select country emailaddress pages",
            GroupName = "Solution 4",
            Order = 10)]
        [BackingType(typeof(PropertyMultiPage))]
        public virtual IEnumerable<ContentReference> CountryEmailAddressesContainerPages { get; set; }

        #endregion
    }
}