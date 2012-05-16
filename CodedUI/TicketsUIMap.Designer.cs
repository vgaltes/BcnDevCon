﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace test2.TicketsUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class TicketsUIMap
    {
        
        /// <summary>
        /// OpenTicket
        /// </summary>
        public void OpenTicket()
        {
            #region Variable Declarations
            HtmlHyperlink uIA014116Hyperlink = this.UIServiceTicketsWindowWindow.UIServiceTicketsDocument.UIContentCustom.UIA014116Hyperlink;
            #endregion

            // Click 'A014116' link
            Mouse.Click(uIA014116Hyperlink, new Point(11, 8));
        }
        
        /// <summary>
        /// NavigateToDeletePage
        /// </summary>
        public void NavigateToDeletePage()
        {
            #region Variable Declarations
            HtmlHyperlink uIDeleteHyperlink = this.UIDetailsWindowsInternWindow.UIDetailsDocument.UIContentCustom.UIDeleteHyperlink;
            #endregion

            // Click 'Delete' link
            Mouse.Click(uIDeleteHyperlink, new Point(30, 25));
        }
        
        #region Properties
        public UIServiceTicketsWindowWindow UIServiceTicketsWindowWindow
        {
            get
            {
                if ((this.mUIServiceTicketsWindowWindow == null))
                {
                    this.mUIServiceTicketsWindowWindow = new UIServiceTicketsWindowWindow();
                }
                return this.mUIServiceTicketsWindowWindow;
            }
        }
        
        public UIDetailsWindowsInternWindow UIDetailsWindowsInternWindow
        {
            get
            {
                if ((this.mUIDetailsWindowsInternWindow == null))
                {
                    this.mUIDetailsWindowsInternWindow = new UIDetailsWindowsInternWindow();
                }
                return this.mUIDetailsWindowsInternWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIServiceTicketsWindowWindow mUIServiceTicketsWindowWindow;
        
        private UIDetailsWindowsInternWindow mUIDetailsWindowsInternWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIServiceTicketsWindowWindow : BrowserWindow
    {
        
        public UIServiceTicketsWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Service Tickets";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Service Tickets");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIServiceTicketsDocument UIServiceTicketsDocument
        {
            get
            {
                if ((this.mUIServiceTicketsDocument == null))
                {
                    this.mUIServiceTicketsDocument = new UIServiceTicketsDocument(this);
                }
                return this.mUIServiceTicketsDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIServiceTicketsDocument mUIServiceTicketsDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIServiceTicketsDocument : HtmlDocument
    {
        
        public UIServiceTicketsDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Service Tickets";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/ServiceTickets";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://intranet.fabrikam.com/ServiceTickets";
            this.WindowTitles.Add("Service Tickets");
            #endregion
        }
        
        #region Properties
        public UIContentCustom UIContentCustom
        {
            get
            {
                if ((this.mUIContentCustom == null))
                {
                    this.mUIContentCustom = new UIContentCustom(this);
                }
                return this.mUIContentCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIContentCustom mUIContentCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIContentCustom : HtmlCustom
    {
        
        public UIContentCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["Id"] = "content";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.SearchProperties["TagName"] = "SECTION";
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"content\"";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("Service Tickets");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIA014116Hyperlink
        {
            get
            {
                if ((this.mUIA014116Hyperlink == null))
                {
                    this.mUIA014116Hyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIA014116Hyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIA014116Hyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIA014116Hyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIA014116Hyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "A014116";
                    this.mUIA014116Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/ServiceTickets/Details/16";
                    this.mUIA014116Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIA014116Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://intranet.fabrikam.com/ServiceTickets/Details/16";
                    this.mUIA014116Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIA014116Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/ServiceTickets/Details/16\"";
                    this.mUIA014116Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "15";
                    this.mUIA014116Hyperlink.WindowTitles.Add("Service Tickets");
                    #endregion
                }
                return this.mUIA014116Hyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIA014116Hyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIDetailsWindowsInternWindow : BrowserWindow
    {
        
        public UIDetailsWindowsInternWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Details";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Details");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIDetailsDocument UIDetailsDocument
        {
            get
            {
                if ((this.mUIDetailsDocument == null))
                {
                    this.mUIDetailsDocument = new UIDetailsDocument(this);
                }
                return this.mUIDetailsDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIDetailsDocument mUIDetailsDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIDetailsDocument : HtmlDocument
    {
        
        public UIDetailsDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Details";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/ServiceTickets/Details/16";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://intranet.fabrikam.com/ServiceTickets/Details/16";
            this.WindowTitles.Add("Details");
            #endregion
        }
        
        #region Properties
        public UIContentCustom1 UIContentCustom
        {
            get
            {
                if ((this.mUIContentCustom == null))
                {
                    this.mUIContentCustom = new UIContentCustom1(this);
                }
                return this.mUIContentCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIContentCustom1 mUIContentCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIContentCustom1 : HtmlCustom
    {
        
        public UIContentCustom1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["Id"] = "content";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.SearchProperties["TagName"] = "SECTION";
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"content\"";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("Details");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIDeleteHyperlink
        {
            get
            {
                if ((this.mUIDeleteHyperlink == null))
                {
                    this.mUIDeleteHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIDeleteHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIDeleteHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIDeleteHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIDeleteHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Delete";
                    this.mUIDeleteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/ServiceTickets/Delete/16";
                    this.mUIDeleteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIDeleteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://intranet.fabrikam.com/ServiceTickets/Delete/16";
                    this.mUIDeleteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "glossyBox";
                    this.mUIDeleteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"glossyBox\" href=\"/ServiceTickets/";
                    this.mUIDeleteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "3";
                    this.mUIDeleteHyperlink.WindowTitles.Add("Details");
                    #endregion
                }
                return this.mUIDeleteHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIDeleteHyperlink;
        #endregion
    }
}