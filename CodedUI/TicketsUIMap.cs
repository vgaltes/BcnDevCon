namespace test2.TicketsUIMapClasses
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    
    
    public partial class TicketsUIMap
    {
        public void OpenTicket(string Id)
        {
            HtmlHyperlink hyperLink = this.UIServiceTicketsWindowWindow.UIServiceTicketsDocument.UIContentCustom.UIA014116Hyperlink;

            hyperLink.SearchProperties.Remove(HtmlHyperlink.PropertyNames.InnerText);
            hyperLink.FilterProperties.Remove(HtmlHyperlink.PropertyNames.AbsolutePath);
            hyperLink.FilterProperties.Remove(HtmlHyperlink.PropertyNames.Href);
            hyperLink.FilterProperties.Remove(HtmlHyperlink.PropertyNames.TagInstance);

            hyperLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "A0141" + Id;
            hyperLink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] =
                string.Format("/ServiceTickets/Details/{0}", Id);
            hyperLink.FilterProperties[HtmlHyperlink.PropertyNames.Href] =
                string.Format("http://intranet.fabrikam.com/ServiceTickets/Details/{0}", Id);

            Mouse.Click(hyperLink, hyperLink.GetClickablePoint());
        }

        public void NavigateToDeletePage(string Id)
        {
            HtmlHyperlink hyperLink = this.UIDetailsWindowsInternWindow.UIDetailsDocument.UIContentCustom.UIDeleteHyperlink;

            hyperLink.FilterProperties.Remove(HtmlHyperlink.PropertyNames.AbsolutePath);
            hyperLink.FilterProperties.Remove(HtmlHyperlink.PropertyNames.Href);

            hyperLink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] =
                string.Format("/ServiceTickets/Delete/{0}", Id);
            hyperLink.FilterProperties[HtmlHyperlink.PropertyNames.Href] =
                string.Format("http://intranet.fabrikam.com/ServiceTickets/Delete/{0}", Id);

            Mouse.Click(hyperLink, hyperLink.GetClickablePoint());
        }
    }
}
