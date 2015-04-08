using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZendeskApi_v2.Models.Articles
{
	public class SearchArticleResponse : GroupResponseBase
	{
		[JsonProperty("results")]
		public IList<Article> Results { get; set; }
	}
}
