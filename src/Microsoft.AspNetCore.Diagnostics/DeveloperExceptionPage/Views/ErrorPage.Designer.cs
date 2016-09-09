namespace Microsoft.AspNetCore.Diagnostics.RazorViews
{
#line 1 "ErrorPage.cshtml"
using System

#line default
#line hidden
    ;
#line 2 "ErrorPage.cshtml"
using System.Globalization

#line default
#line hidden
    ;
#line 3 "ErrorPage.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 4 "ErrorPage.cshtml"
using System.Net

#line default
#line hidden
    ;
#line 5 "ErrorPage.cshtml"
using System.Reflection

#line default
#line hidden
    ;
#line 6 "ErrorPage.cshtml"
using Microsoft.AspNetCore.Diagnostics.RazorViews

#line default
#line hidden
    ;
#line 7 "ErrorPage.cshtml"
using Microsoft.AspNetCore.Diagnostics

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    internal class ErrorPage : Microsoft.Extensions.RazorViews.BaseView
    {
#line 9 "ErrorPage.cshtml"

    public ErrorPage(ErrorPageModel model)
    {
        Model = model;
    }

    public ErrorPageModel Model { get; set; }

#line default
#line hidden
        #line hidden
        public ErrorPage()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 17 "ErrorPage.cshtml"
  
    // TODO: Response.ReasonPhrase = "Internal Server Error";
    Response.ContentType = "text/html; charset=utf-8";
    string location = string.Empty;

#line default
#line hidden

            WriteLiteral("<!DOCTYPE html>\n<html");
            BeginWriteAttribute("lang", " lang=\"", 514, "\"", 575, 1);
#line 23 "ErrorPage.cshtml"
WriteAttributeValue("", 521, CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, 521, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\">\n    <head>\n        <meta charset=\"utf-8\" />\n        <title>");
#line 26 "ErrorPage.cshtml"
          Write(Resources.ErrorPageHtml_Title);

#line default
#line hidden
            WriteLiteral(@"</title>
        <style>
            /*! normalize.css v4.2.0 | MIT License | github.com/necolas/normalize.css */

/**
 * 1. Change the default font family in all browsers (opinionated).
 * 2. Correct the line height in all browsers.
 * 3. Prevent adjustments of font size after orientation changes in IE and iOS.
 */

/* Document
   ========================================================================== */

html {
  font-family: sans-serif; /* 1 */
  line-height: 1.15; /* 2 */
  -ms-text-size-adjust: 100%; /* 3 */
  -webkit-text-size-adjust: 100%; /* 3 */
}

/* Sections
   ========================================================================== */

/**
 * Remove the margin in all browsers (opinionated).
 */

body {
  margin: 0;
}

/**
 * Add the correct display in IE 9-.
 */

article,
aside,
footer,
header,
nav,
section {
  display: block;
}

/**
 * Correct the font size and margin on `h1` elements within `section` and
 * `article` contexts in Chrome, Firefox, and Safari.
 */

h1 {
  font-size: 2em;
  mar");
            WriteLiteral(@"gin: 0.67em 0;
}

/* Grouping content
   ========================================================================== */

/**
 * Add the correct display in IE 9-.
 * 1. Add the correct display in IE.
 */

figcaption,
figure,
main { /* 1 */
  display: block;
}

/**
 * Add the correct margin in IE 8.
 */

figure {
  margin: 1em 40px;
}

/**
 * 1. Add the correct box sizing in Firefox.
 * 2. Show the overflow in Edge and IE.
 */

hr {
  box-sizing: content-box; /* 1 */
  height: 0; /* 1 */
  overflow: visible; /* 2 */
}

/**
 * 1. Correct the inheritance and scaling of font size in all browsers.
 * 2. Correct the odd `em` font sizing in all browsers.
 */

pre {
  font-family: monospace, monospace; /* 1 */
  font-size: 1em; /* 2 */
}

/* Text-level semantics
   ========================================================================== */

/**
 * 1. Remove the gray background on active links in IE 10.
 * 2. Remove gaps in links underline in iOS 8+ and Safari 8+.
 */

a {
  background-color: transparent; /* 1 */
  -w");
            WriteLiteral(@"ebkit-text-decoration-skip: objects; /* 2 */
}

/**
 * Remove the outline on focused links when they are also active or hovered
 * in all browsers (opinionated).
 */

a:active,
a:hover {
  outline-width: 0;
}

/**
 * 1. Remove the bottom border in Firefox 39-.
 * 2. Add the correct text decoration in Chrome, Edge, IE, Opera, and Safari.
 */

abbr[title] {
  border-bottom: none; /* 1 */
  text-decoration: underline; /* 2 */
  text-decoration: underline dotted; /* 2 */
}

/**
 * Prevent the duplicate application of `bolder` by the next rule in Safari 6.
 */

b,
strong {
  font-weight: inherit;
}

/**
 * Add the correct font weight in Chrome, Edge, and Safari.
 */

b,
strong {
  font-weight: bolder;
}

/**
 * 1. Correct the inheritance and scaling of font size in all browsers.
 * 2. Correct the odd `em` font sizing in all browsers.
 */

code,
kbd,
samp {
  font-family: monospace, monospace; /* 1 */
  font-size: 1em; /* 2 */
}

/**
 * Add the correct font style in Android 4.3-.
 */

dfn {
  font-style: italic;
}
");
            WriteLiteral(@"
/**
 * Add the correct background and color in IE 9-.
 */

mark {
  background-color: #ff0;
  color: #000;
}

/**
 * Add the correct font size in all browsers.
 */

small {
  font-size: 80%;
}

/**
 * Prevent `sub` and `sup` elements from affecting the line height in
 * all browsers.
 */

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/* Embedded content
   ========================================================================== */

/**
 * Add the correct display in IE 9-.
 */

audio,
video {
  display: inline-block;
}

/**
 * Add the correct display in iOS 4-7.
 */

audio:not([controls]) {
  display: none;
  height: 0;
}

/**
 * Remove the border on images inside links in IE 10-.
 */

img {
  border-style: none;
}

/**
 * Hide the overflow in IE.
 */

svg:not(:root) {
  overflow: hidden;
}

/* Forms
   ========================================================================== */

/**
 * 1. Change the f");
            WriteLiteral(@"ont styles in all browsers (opinionated).
 * 2. Remove the margin in Firefox and Safari.
 */

button,
input,
optgroup,
select,
textarea {
  font-family: sans-serif; /* 1 */
  font-size: 100%; /* 1 */
  line-height: 1.15; /* 1 */
  margin: 0; /* 2 */
}

/**
 * Show the overflow in IE.
 * 1. Show the overflow in Edge.
 */

button,
input { /* 1 */
  overflow: visible;
}

/**
 * Remove the inheritance of text transform in Edge, Firefox, and IE.
 * 1. Remove the inheritance of text transform in Firefox.
 */

button,
select { /* 1 */
  text-transform: none;
}

/**
 * 1. Prevent a WebKit bug where (2) destroys native `audio` and `video`
 *    controls in Android 4.
 * 2. Correct the inability to style clickable types in iOS and Safari.
 */

button,
html [type=""button""], /* 1 */
[type=""reset""],
[type=""submit""] {
  -webkit-appearance: button; /* 2 */
}

/**
 * Remove the inner border and padding in Firefox.
 */

button::-moz-focus-inner,
[type=""button""]::-moz-focus-inner,
[type=""reset""]::-moz-focus-inner,
[type=""submi");
            WriteLiteral(@"t""]::-moz-focus-inner {
  border-style: none;
  padding: 0;
}

/**
 * Restore the focus styles unset by the previous rule.
 */

button:-moz-focusring,
[type=""button""]:-moz-focusring,
[type=""reset""]:-moz-focusring,
[type=""submit""]:-moz-focusring {
  outline: 1px dotted ButtonText;
}

/**
 * Change the border, margin, and padding in all browsers (opinionated).
 */

fieldset {
  border: 1px solid #c0c0c0;
  margin: 0 2px;
  padding: 0.35em 0.625em 0.75em;
}

/**
 * 1. Correct the text wrapping in Edge and IE.
 * 2. Correct the color inheritance from `fieldset` elements in IE.
 * 3. Remove the padding so developers are not caught out when they zero out
 *    `fieldset` elements in all browsers.
 */

legend {
  box-sizing: border-box; /* 1 */
  color: inherit; /* 2 */
  display: table; /* 1 */
  max-width: 100%; /* 1 */
  padding: 0; /* 3 */
  white-space: normal; /* 1 */
}

/**
 * 1. Add the correct display in IE 9-.
 * 2. Add the correct vertical alignment in Chrome, Firefox, and Opera.
 */

progress {
  display");
            WriteLiteral(@": inline-block; /* 1 */
  vertical-align: baseline; /* 2 */
}

/**
 * Remove the default vertical scrollbar in IE.
 */

textarea {
  overflow: auto;
}

/**
 * 1. Add the correct box sizing in IE 10-.
 * 2. Remove the padding in IE 10-.
 */

[type=""checkbox""],
[type=""radio""] {
  box-sizing: border-box; /* 1 */
  padding: 0; /* 2 */
}

/**
 * Correct the cursor style of increment and decrement buttons in Chrome.
 */

[type=""number""]::-webkit-inner-spin-button,
[type=""number""]::-webkit-outer-spin-button {
  height: auto;
}

/**
 * 1. Correct the odd appearance in Chrome and Safari.
 * 2. Correct the outline style in Safari.
 */

[type=""search""] {
  -webkit-appearance: textfield; /* 1 */
  outline-offset: -2px; /* 2 */
}

/**
 * Remove the inner padding and cancel buttons in Chrome and Safari on OS X.
 */

[type=""search""]::-webkit-search-cancel-button,
[type=""search""]::-webkit-search-decoration {
  -webkit-appearance: none;
}

/**
 * 1. Correct the inability to style clickable types in iOS and Safari.
 * 2. Chang");
            WriteLiteral(@"e font properties to `inherit` in Safari.
 */

::-webkit-file-upload-button {
  -webkit-appearance: button; /* 1 */
  font: inherit; /* 2 */
}

/* Interactive
   ========================================================================== */

/*
 * Add the correct display in IE 9-.
 * 1. Add the correct display in Edge, IE, and Firefox.
 */

details, /* 1 */
menu {
  display: block;
}

/*
 * Add the correct display in all browsers.
 */

summary {
  display: list-item;
}

/* Scripting
   ========================================================================== */

/**
 * Add the correct display in IE 9-.
 */

canvas {
  display: inline-block;
}

/**
 * Add the correct display in IE.
 */

template {
  display: none;
}

/* Hidden
   ========================================================================== */

/**
 * Add the correct display in IE 10-.
 */

[hidden] {
  display: none;
}

            body {
    font-family: 'Segoe UI', Tahoma, Arial, Helvetica, sans-serif;
    font-size: .813em;
    color: #222;
  ");
            WriteLiteral(@"  background-color: #fff;
}

h1, h2, h3, h4, h5 {
    /*font-family: 'Segoe UI',Tahoma,Arial,Helvetica,sans-serif;*/
    font-weight: 100;
}

h1 {
    color: #44525e;
    margin: 15px 0 15px 0;
}

h2 {
    margin: 10px 5px 0 0;
}

h3 {
    color: #363636;
    margin: 5px 5px 0 0;
}

code {
    font-family: Consolas, ""Courier New"", courier, monospace;
}

body .titleerror {
    padding: 3px 3px 6px 3px;
    display: block;
    font-size: 1.5em;
    font-weight: 100;
}

body .location {
    margin: 3px 0 10px 30px;
}

#header {
    font-size: 18px;
    padding: 15px 0;
    border-top: 1px #ddd solid;
    border-bottom: 1px #ddd solid;
    margin-bottom: 0;
}

    #header li {
        display: inline;
        margin: 5px;
        padding: 5px;
        color: #a0a0a0;
        cursor: pointer;
    }

    #header .selected {
        background: #44c5f2;
        color: #fff;
    }

#stackpage ul {
    list-style: none;
    padding-left: 0;
    margin: 0;
    /*border-bottom: 1px #ddd solid;*/
}

#stackpage .details {");
            WriteLiteral(@"
    font-size: 1.2em;
    padding: 3px;
    color: #000;
}

#stackpage .stackerror {
    padding: 5px;
    border-bottom: 1px #ddd solid;
}


#stackpage .frame {
    padding: 0;
    margin: 0 0 0 30px;
}

    #stackpage .frame h3 {
        padding: 2px;
        margin: 0;
    }

#stackpage .source {
    padding: 0 0 0 30px;
}

    #stackpage .source ol li {
        font-family: Consolas, ""Courier New"", courier, monospace;
        white-space: pre;
        background-color: #fbfbfb;
    }

#stackpage .frame .source .highlight li span {
    color: #FF0000;
}

#stackpage .source ol.collapsible li {
    color: #888;
}

    #stackpage .source ol.collapsible li span {
        color: #606060;
    }

.page table {
    border-collapse: separate;
    border-spacing: 0;
    margin: 0 0 20px;
}

.page th {
    vertical-align: bottom;
    padding: 10px 5px 5px 5px;
    font-weight: 400;
    color: #a0a0a0;
    text-align: left;
}

.page td {
    padding: 3px 10px;
}

.page th, .page td {
    border-right: 1px #ddd solid;");
            WriteLiteral(@"
    border-bottom: 1px #ddd solid;
    border-left: 1px transparent solid;
    border-top: 1px transparent solid;
    box-sizing: border-box;
}

    .page th:last-child, .page td:last-child {
        border-right: 1px transparent solid;
    }

.page .length {
    text-align: right;
}

a {
    color: #1ba1e2;
    text-decoration: none;
}

    a:hover {
        color: #13709e;
        text-decoration: underline;
    }

.showRawException {
    cursor: pointer;
    color: #44c5f2;
    background-color: transparent;
    font-size: 1.2em;
    text-align: left;
    text-decoration: none;
    display: inline-block;
    border: 0;
    padding: 0;
}

.rawExceptionStackTrace {
    font-size: 1.2em;
}

.rawExceptionBlock {
    border-top: 1px #ddd solid;
    border-bottom: 1px #ddd solid;
}

.showRawExceptionContainer {
    margin-top: 10px;
    margin-bottom: 10px;
}

.expandCollapseButton {
    cursor: pointer;
    float: left;
    height: 16px;
    width: 16px;
    font-size: 10px;
    position: absolute;
    left: 1");
            WriteLiteral("0px;\n    background-color: #eee;\n    padding: 0;\n    border: 0;\n    margin: 0;\n}\n\n        </style>\n    </head>\n    <body>\n        <h1>");
#line 689 "ErrorPage.cshtml"
       Write(Resources.ErrorPageHtml_UnhandledException);

#line default
#line hidden
            WriteLiteral("</h1>\n");
#line 690 "ErrorPage.cshtml"
        

#line default
#line hidden

#line 690 "ErrorPage.cshtml"
         foreach (var errorDetail in Model.ErrorDetails)
        {

#line default
#line hidden

            WriteLiteral("            <div class=\"titleerror\">");
#line 692 "ErrorPage.cshtml"
                               Write(errorDetail.Error.GetType().Name);

#line default
#line hidden
            WriteLiteral(": ");
#line 692 "ErrorPage.cshtml"
                                                                          Output.Write(HtmlEncodeAndReplaceLineBreaks(errorDetail.Error.Message)); 

#line default
#line hidden

            WriteLiteral("</div>\n");
#line 693 "ErrorPage.cshtml"
            

#line default
#line hidden

#line 693 "ErrorPage.cshtml"
              
                var firstFrame = errorDetail.StackFrames.FirstOrDefault();
                if (firstFrame != null)
                {
                    location = firstFrame.Function;
                }
            

#line default
#line hidden

#line 699 "ErrorPage.cshtml"
             
            if (!string.IsNullOrEmpty(location) && firstFrame != null && !string.IsNullOrEmpty(firstFrame.File))
            {

#line default
#line hidden

            WriteLiteral("                <p class=\"location\">");
#line 702 "ErrorPage.cshtml"
                               Write(location);

#line default
#line hidden
            WriteLiteral(" in <code");
            BeginWriteAttribute("title", " title=\"", 12786, "\"", 12810, 1);
#line 702 "ErrorPage.cshtml"
WriteAttributeValue("", 12794, firstFrame.File, 12794, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 702 "ErrorPage.cshtml"
                                                                           Write(System.IO.Path.GetFileName(firstFrame.File));

#line default
#line hidden
            WriteLiteral("</code>, line ");
#line 702 "ErrorPage.cshtml"
                                                                                                                                     Write(firstFrame.Line);

#line default
#line hidden
            WriteLiteral("</p>\n");
#line 703 "ErrorPage.cshtml"
            }
            else if (!string.IsNullOrEmpty(location))
            {

#line default
#line hidden

            WriteLiteral("                <p class=\"location\">");
#line 706 "ErrorPage.cshtml"
                               Write(location);

#line default
#line hidden
            WriteLiteral("</p>\n");
#line 707 "ErrorPage.cshtml"
            }
            else
            {

#line default
#line hidden

            WriteLiteral("                <p class=\"location\">");
#line 710 "ErrorPage.cshtml"
                               Write(Resources.ErrorPageHtml_UnknownLocation);

#line default
#line hidden
            WriteLiteral("</p>\n");
#line 711 "ErrorPage.cshtml"
            }

            var reflectionTypeLoadException = errorDetail.Error as ReflectionTypeLoadException;
            if (reflectionTypeLoadException != null)
            {
                if (reflectionTypeLoadException.LoaderExceptions.Length > 0)
                {

#line default
#line hidden

            WriteLiteral("                    <h3>Loader Exceptions:</h3>\n                    <ul>\n");
#line 720 "ErrorPage.cshtml"
                        

#line default
#line hidden

#line 720 "ErrorPage.cshtml"
                         foreach (var ex in reflectionTypeLoadException.LoaderExceptions)
                        {

#line default
#line hidden

            WriteLiteral("                            <li>");
#line 722 "ErrorPage.cshtml"
                           Write(ex.Message);

#line default
#line hidden
            WriteLiteral("</li>\n");
#line 723 "ErrorPage.cshtml"
                        }

#line default
#line hidden

            WriteLiteral("                    </ul>\n");
#line 725 "ErrorPage.cshtml"
                }
            }
        }

#line default
#line hidden

            WriteLiteral("        <ul id=\"header\">\n            <li id=\"stack\" tabindex=\"1\" class=\"selected\">\n                ");
#line 730 "ErrorPage.cshtml"
           Write(Resources.ErrorPageHtml_StackButton);

#line default
#line hidden
            WriteLiteral("\n            </li>\n            <li id=\"query\" tabindex=\"2\">\n                ");
#line 733 "ErrorPage.cshtml"
           Write(Resources.ErrorPageHtml_QueryButton);

#line default
#line hidden
            WriteLiteral("\n            </li>\n            <li id=\"cookies\" tabindex=\"3\">\n                ");
#line 736 "ErrorPage.cshtml"
           Write(Resources.ErrorPageHtml_CookiesButton);

#line default
#line hidden
            WriteLiteral("\n            </li>\n            <li id=\"headers\" tabindex=\"4\">\n                ");
#line 739 "ErrorPage.cshtml"
           Write(Resources.ErrorPageHtml_HeadersButton);

#line default
#line hidden
            WriteLiteral("\n            </li>\n        </ul>\n\n        <div id=\"stackpage\" class=\"page\">\n            <ul>\n");
#line 745 "ErrorPage.cshtml"
                

#line default
#line hidden

#line 745 "ErrorPage.cshtml"
                  
                    var exceptionCount = 0;
                    var stackFrameCount = 0;
                    var exceptionDetailId = "";
                    var frameId = "";
                

#line default
#line hidden

            WriteLiteral("                ");
#line 751 "ErrorPage.cshtml"
                 foreach (var errorDetail in Model.ErrorDetails)
                {
                    

#line default
#line hidden

#line 753 "ErrorPage.cshtml"
                      
                        exceptionCount++;
                        exceptionDetailId = "exceptionDetail" + exceptionCount;
                    

#line default
#line hidden

#line 756 "ErrorPage.cshtml"
                     

#line default
#line hidden

            WriteLiteral("                    <li>\n                        <h2 class=\"stackerror\">");
#line 758 "ErrorPage.cshtml"
                                          Write(errorDetail.Error.GetType().Name);

#line default
#line hidden
            WriteLiteral(": ");
#line 758 "ErrorPage.cshtml"
                                                                             Write(errorDetail.Error.Message);

#line default
#line hidden
            WriteLiteral("</h2>\n                        <ul>\n");
#line 760 "ErrorPage.cshtml"
                        

#line default
#line hidden

#line 760 "ErrorPage.cshtml"
                         foreach (var frame in errorDetail.StackFrames)
                        {
                            

#line default
#line hidden

#line 762 "ErrorPage.cshtml"
                              
                                stackFrameCount++;
                                frameId = "frame" + stackFrameCount;
                            

#line default
#line hidden

#line 765 "ErrorPage.cshtml"
                             

#line default
#line hidden

            WriteLiteral("                            <li class=\"frame\"");
            BeginWriteAttribute("id", " id=\"", 15280, "\"", 15293, 1);
#line 766 "ErrorPage.cshtml"
WriteAttributeValue("", 15285, frameId, 15285, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\n");
#line 767 "ErrorPage.cshtml"
                                

#line default
#line hidden

#line 767 "ErrorPage.cshtml"
                                 if (string.IsNullOrEmpty(frame.File))
                                {

#line default
#line hidden

            WriteLiteral("                                    <h3>");
#line 769 "ErrorPage.cshtml"
                                   Write(frame.Function);

#line default
#line hidden
            WriteLiteral("</h3>\n");
#line 770 "ErrorPage.cshtml"
                                }
                                else
                                {

#line default
#line hidden

            WriteLiteral("                                    <h3>");
#line 773 "ErrorPage.cshtml"
                                   Write(frame.Function);

#line default
#line hidden
            WriteLiteral(" in <code");
            BeginWriteAttribute("title", " title=\"", 15631, "\"", 15650, 1);
#line 773 "ErrorPage.cshtml"
WriteAttributeValue("", 15639, frame.File, 15639, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 773 "ErrorPage.cshtml"
                                                                                Write(System.IO.Path.GetFileName(frame.File));

#line default
#line hidden
            WriteLiteral("</code></h3>\n");
#line 774 "ErrorPage.cshtml"
                                }

#line default
#line hidden

            WriteLiteral("\n");
#line 776 "ErrorPage.cshtml"
                                

#line default
#line hidden

#line 776 "ErrorPage.cshtml"
                                 if (frame.Line != 0 && frame.ContextCode.Any())
                                {

#line default
#line hidden

            WriteLiteral("                                    <button class=\"expandCollapseButton\" data-frameId=\"");
#line 778 "ErrorPage.cshtml"
                                                                                  Write(frameId);

#line default
#line hidden
            WriteLiteral("\">+</button>\n                                    <div class=\"source\">\n");
#line 780 "ErrorPage.cshtml"
                                        

#line default
#line hidden

#line 780 "ErrorPage.cshtml"
                                         if (frame.PreContextCode.Any())
                                        {

#line default
#line hidden

            WriteLiteral("                                            <ol");
            BeginWriteAttribute("start", " start=\"", 16181, "\"", 16210, 1);
#line 782 "ErrorPage.cshtml"
WriteAttributeValue("", 16189, frame.PreContextLine, 16189, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"collapsible\">\n");
#line 783 "ErrorPage.cshtml"
                                                

#line default
#line hidden

#line 783 "ErrorPage.cshtml"
                                                 foreach (var line in frame.PreContextCode)
                                                {

#line default
#line hidden

            WriteLiteral("                                                    <li><span>");
#line 785 "ErrorPage.cshtml"
                                                         Write(line);

#line default
#line hidden
            WriteLiteral("</span></li>\n");
#line 786 "ErrorPage.cshtml"
                                                }

#line default
#line hidden

            WriteLiteral("                                            </ol>\n");
#line 788 "ErrorPage.cshtml"
                                        }

#line default
#line hidden

            WriteLiteral("\n                                        <ol");
            BeginWriteAttribute("start", " start=\"", 16641, "\"", 16660, 1);
#line 790 "ErrorPage.cshtml"
WriteAttributeValue("", 16649, frame.Line, 16649, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"highlight\">\n");
#line 791 "ErrorPage.cshtml"
                                            

#line default
#line hidden

#line 791 "ErrorPage.cshtml"
                                             foreach (var line in frame.ContextCode)
                                            {

#line default
#line hidden

            WriteLiteral("                                                <li><span>");
#line 793 "ErrorPage.cshtml"
                                                     Write(line);

#line default
#line hidden
            WriteLiteral("</span></li>\n");
#line 794 "ErrorPage.cshtml"
                                            }

#line default
#line hidden

            WriteLiteral("                                        </ol>\n\n");
#line 797 "ErrorPage.cshtml"
                                        

#line default
#line hidden

#line 797 "ErrorPage.cshtml"
                                         if (frame.PostContextCode.Any())
                                        {

#line default
#line hidden

            WriteLiteral("                                            <ol");
            BeginWriteAttribute("start", " start=\'", 17144, "\'", 17169, 1);
#line 799 "ErrorPage.cshtml"
WriteAttributeValue("", 17152, frame.Line + 1, 17152, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"collapsible\">\n");
#line 800 "ErrorPage.cshtml"
                                                

#line default
#line hidden

#line 800 "ErrorPage.cshtml"
                                                 foreach (var line in frame.PostContextCode)
                                                {

#line default
#line hidden

            WriteLiteral("                                                    <li><span>");
#line 802 "ErrorPage.cshtml"
                                                         Write(line);

#line default
#line hidden
            WriteLiteral("</span></li>\n");
#line 803 "ErrorPage.cshtml"
                                                }

#line default
#line hidden

            WriteLiteral("                                            </ol>\n");
#line 805 "ErrorPage.cshtml"
                                        }

#line default
#line hidden

            WriteLiteral("                                    </div>\n");
#line 807 "ErrorPage.cshtml"
                                }

#line default
#line hidden

            WriteLiteral("                            </li>\n");
#line 809 "ErrorPage.cshtml"
                        }

#line default
#line hidden

            WriteLiteral(@"                        </ul>
                    </li>
                    <li>
                        <br/>
                        <div class=""rawExceptionBlock"">
                            <div class=""showRawExceptionContainer"">
                                <button class=""showRawException"" data-exceptionDetailId=""");
#line 816 "ErrorPage.cshtml"
                                                                                    Write(exceptionDetailId);

#line default
#line hidden
            WriteLiteral("\">Show raw exception details</button>\n                            </div>\n                            <div");
            BeginWriteAttribute("id", " id=\"", 18141, "\"", 18164, 1);
#line 818 "ErrorPage.cshtml"
WriteAttributeValue("", 18146, exceptionDetailId, 18146, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"rawExceptionDetails\">\n                                <pre class=\"rawExceptionStackTrace\">");
#line 819 "ErrorPage.cshtml"
                                                               Write(errorDetail.Error.ToString());

#line default
#line hidden
            WriteLiteral("</pre>\n                            </div>\n                        </div>\n                    </li>\n");
#line 823 "ErrorPage.cshtml"
                }

#line default
#line hidden

            WriteLiteral("            </ul>\n        </div>\n\n        <div id=\"querypage\" class=\"page\">\n");
#line 828 "ErrorPage.cshtml"
            

#line default
#line hidden

#line 828 "ErrorPage.cshtml"
             if (Model.Query.Any())
            {

#line default
#line hidden

            WriteLiteral("                <table>\n                    <thead>\n                        <tr>\n                            <th>");
#line 833 "ErrorPage.cshtml"
                           Write(Resources.ErrorPageHtml_VariableColumn);

#line default
#line hidden
            WriteLiteral("</th>\n                            <th>");
#line 834 "ErrorPage.cshtml"
                           Write(Resources.ErrorPageHtml_ValueColumn);

#line default
#line hidden
            WriteLiteral("</th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
#line 838 "ErrorPage.cshtml"
                        

#line default
#line hidden

#line 838 "ErrorPage.cshtml"
                         foreach (var kv in Model.Query.OrderBy(kv => kv.Key))
                        {
                            foreach (var v in kv.Value)
                            {

#line default
#line hidden

            WriteLiteral("                                <tr>\n                                    <td>");
#line 843 "ErrorPage.cshtml"
                                   Write(kv.Key);

#line default
#line hidden
            WriteLiteral("</td>\n                                    <td>");
#line 844 "ErrorPage.cshtml"
                                   Write(v);

#line default
#line hidden
            WriteLiteral("</td>\n                                </tr>\n");
#line 846 "ErrorPage.cshtml"
                            }
                        }

#line default
#line hidden

            WriteLiteral("                    </tbody>\n                </table>\n");
#line 850 "ErrorPage.cshtml"
            }
            else
            {

#line default
#line hidden

            WriteLiteral("                <p>");
#line 853 "ErrorPage.cshtml"
              Write(Resources.ErrorPageHtml_NoQueryStringData);

#line default
#line hidden
            WriteLiteral("</p>\n");
#line 854 "ErrorPage.cshtml"
            }

#line default
#line hidden

            WriteLiteral("        </div>\n\n        <div id=\"cookiespage\" class=\"page\">\n");
#line 858 "ErrorPage.cshtml"
            

#line default
#line hidden

#line 858 "ErrorPage.cshtml"
             if (Model.Cookies.Any())
            {

#line default
#line hidden

            WriteLiteral("                <table>\n                    <thead>\n                        <tr>\n                            <th>");
#line 863 "ErrorPage.cshtml"
                           Write(Resources.ErrorPageHtml_VariableColumn);

#line default
#line hidden
            WriteLiteral("</th>\n                            <th>");
#line 864 "ErrorPage.cshtml"
                           Write(Resources.ErrorPageHtml_ValueColumn);

#line default
#line hidden
            WriteLiteral("</th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
#line 868 "ErrorPage.cshtml"
                        

#line default
#line hidden

#line 868 "ErrorPage.cshtml"
                         foreach (var kv in Model.Cookies.OrderBy(kv => kv.Key))
                        {

#line default
#line hidden

            WriteLiteral("                            <tr>\n                                <td>");
#line 871 "ErrorPage.cshtml"
                               Write(kv.Key);

#line default
#line hidden
            WriteLiteral("</td>\n                                <td>");
#line 872 "ErrorPage.cshtml"
                               Write(kv.Value);

#line default
#line hidden
            WriteLiteral("</td>\n                            </tr>\n");
#line 874 "ErrorPage.cshtml"
                        }

#line default
#line hidden

            WriteLiteral("                    </tbody>\n                </table>\n");
#line 877 "ErrorPage.cshtml"
            }
            else
            {

#line default
#line hidden

            WriteLiteral("                <p>");
#line 880 "ErrorPage.cshtml"
              Write(Resources.ErrorPageHtml_NoCookieData);

#line default
#line hidden
            WriteLiteral("</p>\n");
#line 881 "ErrorPage.cshtml"
            }

#line default
#line hidden

            WriteLiteral("        </div>\n        <div id=\"headerspage\" class=\"page\">\n");
#line 884 "ErrorPage.cshtml"
            

#line default
#line hidden

#line 884 "ErrorPage.cshtml"
             if (Model.Headers.Any())
            {

#line default
#line hidden

            WriteLiteral("                <table>\n                    <thead>\n                        <tr>\n                            <th>");
#line 889 "ErrorPage.cshtml"
                           Write(Resources.ErrorPageHtml_VariableColumn);

#line default
#line hidden
            WriteLiteral("</th>\n                            <th>");
#line 890 "ErrorPage.cshtml"
                           Write(Resources.ErrorPageHtml_ValueColumn);

#line default
#line hidden
            WriteLiteral("</th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
#line 894 "ErrorPage.cshtml"
                        

#line default
#line hidden

#line 894 "ErrorPage.cshtml"
                         foreach (var kv in Model.Headers.OrderBy(kv => kv.Key))
                        {
                            foreach (var v in kv.Value)
                            {

#line default
#line hidden

            WriteLiteral("                                <tr>\n                                    <td>");
#line 899 "ErrorPage.cshtml"
                                   Write(kv.Key);

#line default
#line hidden
            WriteLiteral("</td>\n                                    <td>");
#line 900 "ErrorPage.cshtml"
                                   Write(v);

#line default
#line hidden
            WriteLiteral("</td>\n                                </tr>\n");
#line 902 "ErrorPage.cshtml"
                            }
                        }

#line default
#line hidden

            WriteLiteral("                    </tbody>\n                </table>\n");
#line 906 "ErrorPage.cshtml"
            }
            else
            {

#line default
#line hidden

            WriteLiteral("                <p>");
#line 909 "ErrorPage.cshtml"
              Write(Resources.ErrorPageHtml_NoHeaderData);

#line default
#line hidden
            WriteLiteral("</p>\n");
#line 910 "ErrorPage.cshtml"
            }

#line default
#line hidden

            WriteLiteral(@"        </div>
        <script>
            //<!--
            (function (window, undefined) {
    ""use strict"";

    function ns(selector, element) {
        return new NodeCollection(selector, element);
    }

    function NodeCollection(selector, element) {
        this.items = [];
        element = element || window.document;

        var nodeList;

        if (typeof (selector) === ""string"") {
            nodeList = element.querySelectorAll(selector);
            for (var i = 0, l = nodeList.length; i < l; i++) {
                this.items.push(nodeList.item(i));
            }
        }
    }

    NodeCollection.prototype = {
        each: function (callback) {
            for (var i = 0, l = this.items.length; i < l; i++) {
                callback(this.items[i], i);
            }
            return this;
        },

        children: function (selector) {
            var children = [];

            this.each(function (el) {
                children = children.concat(ns(selector, el).items);
           ");
            WriteLiteral(@" });

            return ns(children);
        },

        hide: function () {
            this.each(function (el) {
                el.style.display = ""none"";
            });

            return this;
        },

        toggle: function () {
            this.each(function (el) {
                el.style.display = el.style.display === ""none"" ? """" : ""none"";
            });

            return this;
        },

        show: function () {
            this.each(function (el) {
                el.style.display = """";
            });

            return this;
        },

        addClass: function (className) {
            this.each(function (el) {
                var existingClassName = el.className,
                    classNames;
                if (!existingClassName) {
                    el.className = className;
                } else {
                    classNames = existingClassName.split("" "");
                    if (classNames.indexOf(className) < 0) {
                        el.className = existingCl");
            WriteLiteral(@"assName + "" "" + className;
                    }
                }
            });

            return this;
        },

        removeClass: function (className) {
            this.each(function (el) {
                var existingClassName = el.className,
                    classNames, index;
                if (existingClassName === className) {
                    el.className = """";
                } else if (existingClassName) {
                    classNames = existingClassName.split("" "");
                    index = classNames.indexOf(className);
                    if (index > 0) {
                        classNames.splice(index, 1);
                        el.className = classNames.join("" "");
                    }
                }
            });

            return this;
        },

        attr: function (name) {
            if (this.items.length === 0) {
                return null;
            }

            return this.items[0].getAttribute(name);
        },

        on: function (eventName, ha");
            WriteLiteral(@"ndler) {
            this.each(function (el, idx) {
                var callback = function (e) {
                    e = e || window.event;
                    if (!e.which && e.keyCode) {
                        e.which = e.keyCode; // Normalize IE8 key events
                    }
                    handler.apply(el, [e]);
                };

                if (el.addEventListener) { // DOM Events
                    el.addEventListener(eventName, callback, false);
                } else if (el.attachEvent) { // IE8 events
                    el.attachEvent(""on"" + eventName, callback);
                } else {
                    el[""on"" + type] = callback;
                }
            });

            return this;
        },

        click: function (handler) {
            return this.on(""click"", handler);
        },

        keypress: function (handler) {
            return this.on(""keypress"", handler);
        }
    };

    function frame(el) {
        ns("".source .collapsible"", el).toggle();
    }

");
            WriteLiteral(@"    function expandCollapseButton(el) {
        var frameId = el.getAttribute(""data-frameId"");
        frame(document.getElementById(frameId));
        if (el.innerText === ""+"") {
            el.innerText = ""-"";
        }
        else {
            el.innerText = ""+"";
        }
    }

    function tab(el) {
        var unselected = ns(""#header .selected"").removeClass(""selected"").attr(""id"");
        var selected = ns(""#"" + el.id).addClass(""selected"").attr(""id"");

        ns(""#"" + unselected + ""page"").hide();
        ns(""#"" + selected + ""page"").show();
    }

    ns("".rawExceptionDetails"").hide();
    ns("".collapsible"").hide();
    ns("".page"").hide();
    ns(""#stackpage"").show();

    ns("".expandCollapseButton"")
        .click(function () {
            expandCollapseButton(this);
        })
        .keypress(function (e) {
            if (e.which === 13) {
                expandCollapseButton(this);
            }
        });

    ns(""#header li"")
        .click(function () {
            tab(this);
        })
  ");
            WriteLiteral(@"      .keypress(function (e) {
            if (e.which === 13) {
                tab(this);
            }
        });

    ns("".showRawException"")
        .click(function () {
            var exceptionDetailId = this.getAttribute(""data-exceptionDetailId"");
            ns(""#"" + exceptionDetailId).toggle();
        });
})(window);
            //-->
        </script>
    </body>
</html>
");
        }
        #pragma warning restore 1998
    }
}
