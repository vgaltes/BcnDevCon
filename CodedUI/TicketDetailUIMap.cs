namespace test2.TicketDetailUIMapClasses
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
    
    
    public partial class TicketDetailUIMap
    {
        public string CurrentId
        {
            get
            {
                return (((string)(this.UIDetailsWindowsInternWindow.UIDetailsDocument).GetProperty(
                    HtmlDocument.PropertyNames.PageUrl)).Split('/'))[5];
            }
        }
    }
}
