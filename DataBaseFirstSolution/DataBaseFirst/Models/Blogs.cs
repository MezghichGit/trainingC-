namespace DataBaseFirst.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blogs
    {
        
        public Blogs()
        {
            Posts = new HashSet<Posts>();
        }

      
        public int BlogId { get; set; }

        
        public string Name { get; set; }

        
        public string Url { get; set; }

        
        public virtual ICollection<Posts> Posts { get; set; }
    }
}
