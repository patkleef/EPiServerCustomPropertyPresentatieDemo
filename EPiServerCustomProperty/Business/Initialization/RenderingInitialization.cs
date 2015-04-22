using System;
using System.Web;
using EPiServer.Framework;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServerCustomProperty.Models.Pages.Interfaces;

namespace EPiServerCustomProperty.Business.Initialization
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RenderingInitialization : IInitializableModule
    {
        public void Initialize(EPiServer.Framework.Initialization.InitializationEngine context)
        {
            context.Locate.TemplateResolver().TemplateResolved += OnTemplateResolved;
        }

        /// <summary>
        /// On template resolved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected virtual void OnTemplateResolved(object sender, TemplateResolverEventArgs args)
        {
            if (args.SupportedTemplates == null || 
                args.ItemToRender == null ||
                args.ItemToRender is IContainerPage)
            {
                args.SelectedTemplate = null;
                return;
            }
        }

        public void Preload(string[] parameters)
        {

        }

        public void Uninitialize(EPiServer.Framework.Initialization.InitializationEngine context)
        {
            ServiceLocator.Current.GetInstance<TemplateResolver>().TemplateResolved -= OnTemplateResolved;
        }
    }
}