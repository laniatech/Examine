﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UmbracoExamine.Core;

namespace UmbracoExamine.Test.Testing
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(ExamineManager.Instance.DefaultSearchProvider.Description);
        }
    }
}
