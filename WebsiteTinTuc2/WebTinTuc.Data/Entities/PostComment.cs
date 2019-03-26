namespace WebTinTuc.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostComment")]
    public partial class PostComment
    {
        public long Id { get; set; }

        public long? PostId { get; set; }

        public long? CommentedBy { get; set; }

        [StringLength(200)]
        public string Content { get; set; }

        public DateTime? CommentedTime { get; set; }
    }
}
