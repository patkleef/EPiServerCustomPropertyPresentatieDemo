using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing;
using EPiServerCustomProperty.Business.Services;

namespace EPiServerCustomProperty.Business.SelectionFactory
{
    public class CountrySelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var countryService = new CountryService();

            return countryService.GetAll().Select(c => new SelectItem
            {
                Text = c.Name,
                Value = c.Code
            });
        }
    }
}