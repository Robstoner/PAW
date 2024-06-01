﻿using System.Text.Json.Serialization;

namespace Discussion_Forum.Server.Models.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }

        public Guid PostId { get; set; }
        [JsonIgnore]
        public virtual Post Post { get; set; }
        public string AuthorId { get; set; }
        public virtual User Author { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
