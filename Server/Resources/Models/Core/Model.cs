using System;
using System.Collections.Generic;

namespace Server.Resources.Models.Core
{
    public abstract class Model<TEntity>
    {
        private bool _isActive;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Logo { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? ActiveSince { get; set; }
        public DateTime? ActiveLast { get; set; }

        public Model()
        {
            this.Created = DateTime.Now;
            this.IsActive = true;
        }

        public bool IsActive
        {
            get { return this._isActive; }
            set
            {
                this._isActive = value;
                if (value) { this.ActiveSince = DateTime.Now; }
                else { this.ActiveLast = DateTime.Now; }
            }
        }
    }
}