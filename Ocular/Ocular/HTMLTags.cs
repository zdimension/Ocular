using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ocular
{
    public static class HTMLTags
    {
        public static Tag doctype = new Tag("!DOCTYPE", "Defines the document type.");
        public static Tag a = new Tag("a", "Defines a hyperlink.");
        public static Tag abbr = new Tag("abbr", "Defines an abbreviation.");
        public static Tag address = new Tag("address", "Defines contact information for the author/owner of a document.");
        public static Tag area = new Tag("area", "Defines an area inside an image-map.");
        public static Tag article = new Tag("article", "Defines an article.");
        public static Tag aside = new Tag("aside", "Defines content aside from the page context.");
        public static Tag audio = new Tag("audio", "Defines sound content.");
        public static Tag b = new Tag("b", "Defines bold text.");
        public static Tag @base = new Tag("base", "Specifies the base URL/target for all relative URLs in a document.");
        public static Tag bdi = new Tag("bdi", "Isolates a part of text that might be formatted in a different direction from other text outside it.");
        public static Tag bdo = new Tag("bdo", "Overrides the current text direction.");
        public static Tag blockquote = new Tag("blockquote", "Defines a section that is quoted from another source.");
        public static Tag body = new Tag("body", "Defines the document's body.");
        public static Tag br = new Tag("br", "Defines a single-line break.");
        public static Tag button = new Tag("button", "Defines a clickable button.");
        public static Tag canvas = new Tag("canvas", "Used to draw graphics, on the fly, via scripting (usually JavaScript).");
        public static Tag caption = new Tag("caption", "Defines a table caption.");
        public static Tag cite = new Tag("cite", "Defines the title of a work.");
        public static Tag code = new Tag("code", "Defines a piece of computer code.");
        public static Tag col = new Tag("col", "Specifies column properties for each column within a <colgroup> element.");
        public static Tag colgroup = new Tag("colgroup", "Specifies a group of one or more columns in a table for formatting.");
        public static Tag command = new Tag("command", "Defines a command button that a user can invoke.");
        public static Tag datalist = new Tag("datalist", "Specifies a list of pre-defined options for input controls.");
        public static Tag dd = new Tag("dd", "Defines a description/value of a term in a description list.");
        public static Tag del = new Tag("del", "Defines text that have been deleted from a document.");
        public static Tag details = new Tag("details", "Defines additional details that the user can view or hide.");
        public static Tag dfn = new Tag("dfn", "Defines a definition term.");
        public static Tag dialog = new Tag("dialog", "Defines a dialog box or window.");
        public static Tag div = new Tag("div", "Defines a section in a document.");
        public static Tag dl = new Tag("dl", "Defines a description list.");
        public static Tag dt = new Tag("dt", "Defines a term/name in a description list.");
        public static Tag em = new Tag("em", "Defines emphasized text.");
        public static Tag embed = new Tag("embed", "Defines a container for an external (non-HTML) application.");
        public static Tag fieldset = new Tag("fieldset", "Groups related elements in a form.");
        public static Tag figcaption = new Tag("figcaption", "Defines a caption for a <figure> element.");
        public static Tag figure = new Tag("figure", "Specifies self-contained content.");
        public static Tag footer = new Tag("footer", "Defines a footer for a document or section.");
        public static Tag form = new Tag("form", "Defines an HTML form for user input.");
        public static Tag h1 = new Tag("h1", "Defines HTML heading.");
        public static Tag h2 = new Tag("h2", "Defines HTML heading.");
        public static Tag h3 = new Tag("h3", "Defines HTML heading.");
        public static Tag h4 = new Tag("h4", "Defines HTML heading.");
        public static Tag h5 = new Tag("h5", "Defines HTML heading.");
        public static Tag h6 = new Tag("h6", "Defines HTML heading.");
        public static Tag head = new Tag("head", "Defines information about the document.");
        public static Tag header = new Tag("header", "Defines a header for a document or section.");
        public static Tag hr = new Tag("hr", "Defines a thematic change in the content.");
        public static Tag html = new Tag("html", "Defines the root of an HTML document.");
        public static Tag i = new Tag("i", "Defines a part of text in an alternate voice or mood.");
        public static Tag iframe = new Tag("iframe", "Defines an inline frame.");
        public static Tag img = new Tag("img", "Defines an image.");
        public static Tag input = new Tag("input", "Defines an input control.");
        public static Tag ins = new Tag("ins", "Defines a text that has been inserted into a document.");
        public static Tag kbd = new Tag("kbd", "Defines keyboard input.");
        public static Tag keygen = new Tag("keygen", "Defines a key-pair generator field (for forms).");
        public static Tag label = new Tag("label", "Defines a label for an <input> element.");
        public static Tag legend = new Tag("legend", "Defines a caption for a <fieldset> document.");
        public static Tag li = new Tag("li", "Defines a list item.");
        public static Tag link = new Tag("link", "Defines the relationship between a document and an external ressource (most used to link style sheets).");
        public static Tag map = new Tag("map", "Defines a client-side image-map.");
        public static Tag mark = new Tag("mark", "Defines marked/highlighted text.");
        public static Tag menu = new Tag("menu", "Defines a list/menu of commands.");
        public static Tag meta = new Tag("meta", "Defines metadata about an HTML document.");
        public static Tag meter = new Tag("meter", "Defines a scalar measurement within a known range (a gauge).");
        public static Tag nav = new Tag("nav", "Defines navigation links.");
        public static Tag noscript = new Tag("noscript", "Defines an alternate content for users that do not support client-side scripts.");
        public static Tag @object = new Tag("object", "Defines an embedded object.");
        public static Tag ol = new Tag("ol", "Defines an ordered list.");
        public static Tag optgroup = new Tag("optgroup", "Defines a group of related options in a drop-down list.");
        public static Tag option = new Tag("option", "Defines an option in a drop-down list.");
        public static Tag output = new Tag("output", "Defines the result of a calculation.");
        public static Tag p = new Tag("p", "Defines a paragraph.");
        public static Tag param = new Tag("param", "Defines a parameter for an object.");
        public static Tag pre = new Tag("pre", "Defines preformatted text.");
        public static Tag progress = new Tag("progress", "Represents the progress of a task.");
        public static Tag q = new Tag("q", "Defines a short quotation.");
        public static Tag rp = new Tag("rp", "Defines what to show in browsers that do not support ruby annotations.");
        public static Tag rt = new Tag("rt", "Defines an explanation/pronunciation of characters (for East Asian typography).");
        public static Tag ruby = new Tag("ruby", "Defines a ruby annotation (for East Asian typography).");
        public static Tag s = new Tag("s", "Defines text that is no longer correct.");
        public static Tag samp = new Tag("samp", "Defines sample output from a computer program.");
        public static Tag script = new Tag("script", "Defines a client-side script.");
        public static Tag section = new Tag("section", "Defines a section in a document.");
        public static Tag select = new Tag("select", "Defines a drop-down list.");
        public static Tag small = new Tag("small", "Defines smaller text.");
        public static Tag source = new Tag("source", "Defines multiple media resources for media elements (<video> and <audio>).");
        public static Tag span = new Tag("span", "Defines a section in a document..");
        public static Tag strong = new Tag("strong", "Defines important text.");
        public static Tag style = new Tag("style", "Defines style information for a document.");
        public static Tag sub = new Tag("sub", "Defines subscripted text.");
        public static Tag summary = new Tag("summary", "Defines a visible heading for a <details> element.");
        public static Tag sup = new Tag("sup", "Defines superscripted text.");
        public static Tag table = new Tag("table", "Defines a table.");
        public static Tag tbody = new Tag("tbody", "Groups the body content in a table.");
        public static Tag td = new Tag("td", "Defines a cell in a table.");
        public static Tag textarea = new Tag("textarea", "Defines a multiline input control (text area).");
        public static Tag tfoot = new Tag("tfoot", "Groups the footer content in a table.");
        public static Tag th = new Tag("th", "Defines a header cell in a table.");
        public static Tag thead = new Tag("thead", "Groups the header content in a table.");
        public static Tag time = new Tag("time", "Defines a date/time.");
        public static Tag title = new Tag("title", "Defines a title for the document.");
        public static Tag tr = new Tag("tr", "Defines a row in a table.");
        public static Tag track = new Tag("track", "Defines text track for media elements (<video> and <audio>).");
        public static Tag u = new Tag("u", "Defines text that should ne stylistically different from normal text.");
        public static Tag ul = new Tag("ul", "Defines an unordered list.");
        public static Tag var = new Tag("var", "Defines a variable.");
        public static Tag video = new Tag("video", "Defines a video or movie.");
        public static Tag wbr = new Tag("wbr", "Defines a possible line break.");

        
        
        //public const string font =       "font", "");
        
        
        
        
        
        

        //public const string href = new "href", "");
        //public const string src =        "src", "");
    }
}
