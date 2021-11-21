using System;
using System.Text;

namespace ConsoleAppHTML
{
	public abstract class Element
	{
		public string Id { get; set; }
		public string Class { get; set; }
		public abstract string Render();
		public abstract string Render2();
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
			if (!string.IsNullOrEmpty(Id))
			{
				linkBuilder.Append(" id=\"").Append(Id).Append("\"");
			}
			if (!string.IsNullOrEmpty(Class))
			{
				linkBuilder.Append(" class=\"").Append(Class).Append("\"");
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

		public override string Render2()
		{
			string href = "";
			string id = "";
			string classProp = "";
			string title = "";
			string style = "";
			string text = "";

			if (!string.IsNullOrEmpty(Href))
			{
				href = $" href=\"{Href}\" ";
			}
			if (!string.IsNullOrEmpty(Id))
			{
				id = $"id=\"{Id}\" ";
			}
			if (!string.IsNullOrEmpty(Class))
			{
				classProp = $"class=\"{Class}\" ";
			}
			if (!string.IsNullOrEmpty(Title))
			{
				title = $"title=\"{Title}\" ";
			}
			if (!string.IsNullOrEmpty(Style))
			{
				style = $"style=\"{Style}\"";
			}
			if (!string.IsNullOrEmpty(Text))
			{
				text = Text;
			}

			return $"<a{href}{id}{classProp}{title}{style}>{text}</a>";
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			Link googleLink = new Link()
			{
				Href = "https://google.com",
				Id = "google_link_id",
				Class = "google_link_class",
				Style = "padding:0px;margin:0px",
				Title = "Link to Google.com",
				Text = "Google.com WEBSITE",
			};
			Link emptyLink = new Link();
			string link = googleLink.Render();
			string link2 = googleLink.Render2();
			string link3 = emptyLink.Render();
			string link4 = emptyLink.Render2();
			Console.WriteLine(link);
			Console.WriteLine(link2);
			Console.WriteLine(link3);
			Console.WriteLine(link4);
			Console.ReadKey();
		}
	}
}
