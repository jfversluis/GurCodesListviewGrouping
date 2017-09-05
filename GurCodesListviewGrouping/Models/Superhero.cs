using Newtonsoft.Json;

namespace GurCodesListviewGrouping.Models
{
    public class Superhero 
    {
        [JsonProperty("superhero")]
        public string Name { get; set; }

		[JsonProperty("alter_ego")]
        public string AlterEgo { get; set; }
    }
}