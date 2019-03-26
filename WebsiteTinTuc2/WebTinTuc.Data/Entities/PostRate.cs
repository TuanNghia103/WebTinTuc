namespace WebTinTuc.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostRate")]
    public partial class PostRate
    {
        public long Id { get; set; }

        public long? PostId { get; set; }

        public long? RatedBy { get; set; }

        public short? Mark { get; set; }

        public DateTime? RatedTime { get; set; }
    }
}
