using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain;

namespace Application.Profiles.Model
{
    public class Profile
    {
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
        public ICollection<Photo> Photos { get; set; }

        [JsonPropertyName("following")]
        public bool Following { get; set; }
        public int FollowersCount {get;set;}
        public int FollowingCount { get; set; }
    }
}