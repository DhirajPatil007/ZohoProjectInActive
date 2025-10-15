using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class BordoKutuCategory
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public string Path { get; set; }
        public bool? IsdiplayedonDrawer { get; set; }
        public bool? IsdiplayedonHomeScreen { get; set; }
        public bool? IsdiplayedonShopScreen { get; set; }
        public int? SortOrder { get; set; }
        public int? HomescreenOrder { get; set; }
        public int? DrawerOrder { get; set; }
        public int? ShopscreenOrder { get; set; }
        public bool? IsActive { get; set; }
        public DateTime DateModfied { get; set; }
    }
}
