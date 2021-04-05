using System;

namespace ApiService.Models
{
    public class ItemModel
    {
        public ItemModel()
        {
            SomeThing = Guid.NewGuid();
        }

        public ItemModel(string id)
        {
            Id = id;
            SomeThing = Guid.NewGuid();
        }
        public string Id { get; set; }
        public Guid SomeThing { get; set; }


    }
}
