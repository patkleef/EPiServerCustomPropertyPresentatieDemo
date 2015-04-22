using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;
using EPiServerCustomProperty.Business.SelectionFactory;
using EPiServerCustomProperty.Models.Pages.Interfaces;

namespace EPiServerCustomProperty.Models.Pages
{
    [ContentType(DisplayName = "Country emailaddress container page", GUID = "4bc8ba6e-2009-4a4b-9fd1-a39457ca42ea", Description = "")]
    public class CountryEmailAddressContainerPage : PageData, IContainerPage
    {
        [Required]
        [Display(
            Name = "Country",
            Description = "Country",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [SelectOne(SelectionFactoryType = typeof(CountrySelectionFactory))]
        public virtual string Country { get; set; }

        [Required]
        [Display(
            Name = "Email address",
            Description = "Email address",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string EmailAddress { get; set; }
    }
}