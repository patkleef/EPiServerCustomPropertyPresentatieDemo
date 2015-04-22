using System.Collections.Generic;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using EPiServerCustomProperty.Business.Properties;
using EPiServerCustomProperty.Business.Services;

namespace EPiServerCustomProperty.Business.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(IEnumerable<CountryEmailAddress>), UIHint = "CountryEmailAddressesProperty")]
    public class ContainerPageCountryEditorDescriptor : EPiServer.Shell.ObjectEditing.EditorDescriptors.EditorDescriptor
    {
        public ContainerPageCountryEditorDescriptor()
        {
            var countryService = ServiceLocator.Current.GetInstance<ICountryService>();

            ClientEditingClass = "app.editors.CountryEmailAddressesProperty";

            EditorConfiguration["Countries"] = countryService.GetAll();
        }
    }
}