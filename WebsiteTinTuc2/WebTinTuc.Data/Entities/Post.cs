namespace WebTinTuc.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        public long Id { get; set; }

        public long? CategoryId { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(100)]
        public string Summary { get; set; }

        [StringLength(50)]
        public string Resource { get; set; }

        [StringLength(1000)]
        public string Image { get; set; }

        public long? View { get; set; }

        [StringLength(500)]
        public string Tags { get; set; }

        public short? PostStatus { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedTime { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedTime { get; set; }

        public bool? IsDeleted { get; set; }

        public long? DeletedBy { get; set; }

        public DateTime? DeletedTime { get; set; }
    }
}
