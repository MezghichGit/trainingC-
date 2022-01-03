namespace DataBaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Posts
    {
        [Key]
        public int PostId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [System.ComponentModel.DataAnnotations.Column(TypeName = "ntext")]
        public string Content { get; set; }

        public int BlogId { get; set; }

        public virtual Blogs Blogs { get; set; }
    }
}
