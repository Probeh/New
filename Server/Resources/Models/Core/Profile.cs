using System.Collections.Generic;

namespace Server.Resources.Models.Core
{
    public class Profile<TEntity> : Model<TEntity>
    {
        public string Title { get; set; }
        public int ParentId { get; set; }
        public string Summary { get; set; }
        public virtual TEntity Parent { get; set; }
        public virtual List<TEntity> Children { get; set; }

        public Profile()
        {
            this.Children = new List<TEntity>();
        }
    }
}