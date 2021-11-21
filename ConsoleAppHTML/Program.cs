using System;
using System.Text;

namespace ConsoleAppHTML
{
    public abstract class Element
    {
        public string Id { get; set; }
        public string Class { get; set; }
        public abstract string Render();
    }

    public class Link : Element
    {
        public string Href { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Style { get; set; }

        public override string Render()
        {
            StringBuilder linkBuilder = new StringBuilder();
            linkBuilder.Append("<a");

            if (!string.IsNullOrEmpty(Href))
            {
                linkBuilder.Append(" href=\"").Append(Href).Append("\"");
            }
            if (!string.IsNullOrEmpty(Title))
            {
                linkBuilder.Append(" title=\"").Append(Title).Append("\"");
            }
            if (!string.IsNullOrEmpty(Style))
            {
                linkBuilder.Append(" style=\"").Append(Style).Append("\"");
            }

            linkBuilder.Append(">");

			if (!string.IsNullOrEmpty(Text))
			{
                linkBuilder.Append(Text);

            }
            linkBuilder.Append("</a>");

            string link = linkBuilder.ToString();

            return link;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Link googleLink = new Link()
            {
                Href = "https://google.com",
                Style = "margin:0px",
                Title = "Link to Google.com",
                Text = "Google.com WEBSITE",
            };
            string link = googleLink.Render();
			Console.WriteLine(link);
            Console.ReadKey();
        }
    }
}
