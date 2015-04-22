using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServerCustomProperty.Models.Pages.Interfaces;

namespace EPiServerCustomProperty.Models.Pages
{
    [ContentType(DisplayName = "Container page", GUID = "b1056df2-56b9-45f8-8a95-a502845bc863", Description = "")]
    public class ContainerPage : PageData, IContainerPage
    {

    }
}