﻿using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;

namespace WebSite.Helpers
{
    public static class FolderHelpers
    {
        public static MvcHtmlString FolderLink(this HtmlHelper html, DirectoryInfo directoryInfo, string path)
        {
            if (directoryInfo == null)
            {
                return new MvcHtmlString(string.Empty);
            }

            TagBuilder a = new TagBuilder("a");
            a.SetInnerText(directoryInfo.Name);
            StringBuilder href = new StringBuilder("/Folders/");
            if (!string.IsNullOrEmpty(path))
            {
                href.Append(path);
                if (!href.ToString().EndsWith("/"))
                {
                    href.Append("/");
                }
            }

            href.Append(directoryInfo.Name);
            a.Attributes.Add(new KeyValuePair<string, string>("href", href.ToString().Replace(":", "")));

            return new MvcHtmlString(a.ToString());
        }
    }
}