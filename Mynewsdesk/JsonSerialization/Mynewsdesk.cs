
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
namespace Spctrm_news.Mynewsdesk.JsonSerialization
{
    public class Link
    {
        public string text { get; set; }
        public string url { get; set; }
    }

    public class Links
    {
        public List<Link> link { get; set; }
    }

    public class Tags
    {
        public List<string> tag { get; set; }
    }

    public class Subjects
    {
        public List<string> subject { get; set; }
    }

    public class GeographicAreas
    {
        public object geographic_area { get; set; }
    }

    public class ContactPerson
    {
        public string Source_id { get; set; }
        public string Source_name { get; set; }
        public string Pressroom_name { get; set; }
        public string Pressroom { get; set; }
        public string Pressroom_id { get; set; }
        public string Organization_number { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public string Published_at { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Specialist { get; set; }
        public string Phone { get; set; }
        public object Phone_alternative { get; set; }
        public string Email { get; set; }
        public string Pressroom_contact { get; set; }
        public object Summary { get; set; }
        public object Body { get; set; }
        public string Image { get; set; }
        public string Image_small { get; set; }
        public string Image_medium { get; set; }
        public string Image_thumbnail_large { get; set; }
        public string Image_thumbnail_medium { get; set; }
        public string Image_thumbnail_small { get; set; }
    }

    public class ContactPeople
    {
        public List<ContactPerson> Contact_person { get; set; }
    }

    public class RelatedItem
    {
        public string Item_id { get; set; }
        public string Type_of_media { get; set; }
    }

    public class RelatedItems
    {
        public List<RelatedItem> Related_item { get; set; }
    }

    public class Item
    {
        public string NewsdeskML { get; set; }
        [JsonProperty("type_of_media")]
        public string Type { get; set; }
        public string Language { get; set; }
        public string Source_id { get; set; }
        public string Source_name { get; set; }
        public string Pressroom_name { get; set; }
        public string Pressroom { get; set; }
        public string Pressroom_id { get; set; }
        public string Organization_number { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        [JsonProperty("published_at")]
        public string Published { get; set; }
        [JsonProperty("created_at")]
        public string Created { get; set; }
        [JsonProperty("updated_at")]
        public string Updated { get; set; }
        public Links Links { get; set; }
        [JsonProperty("header")]
        public string Title { get; set; }
        public string Summary { get; set; }
        [JsonProperty("body")]
        public string Content { get; set; }
        public string Boilerplate { get; set; }
       

        public List<Images> Images = new List<Images>() { new Images() };
                
        public string image_caption { set { Images[0].Title = value; } }
        public string image { set { Images[0].Large = value; } }
        public string image_small { set { Images[0].Small = value; } }
        public string image_medium { set { Images[0].Medium = value; } }
        public string image_thumbnail_large { set { Images[0].Thumbnail_large = value; } }
        public string image_thumbnail_medium { set { Images[0].Thumbnail_medium = value; } }
        public string image_thumbnail_small { set { Images[0].Thumbnail_small = value; } }

        public Tags tags { get; set; }
        public Subjects Subjects { get; set; }
        public GeographicAreas Geographic_areas { get; set; }
        public ContactPeople Contact_people { get; set; }
        public RelatedItems Related_items { get; set; }

        public List<File> Files = new List<File> { new File(), new File() };


        public string attached_doc { set { Files[0].Url = value; Files[0].Type = "doc"; } }
        public string attached_pdf { set { Files[1].Url = value; Files[1].Type = "pdf"; } }
    }


    public class File
    {
        public string Type { get; set; }
        public string Url { get; set; }
    }
    public class Images
    {
        public string Title { get; set; }
        public string Large { get; set; }
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Thumbnail_large { get; set; }
        public string Thumbnail_medium { get; set; }
        public string Thumbnail_small { get; set; }
    }
    public class Items
    {
        [JsonProperty("item")]
        public List<Item> Item{ get; set; }
        [JsonProperty("total_count")]
        public string Total { get; set; }
    }

    public class RootObject
    {
        public Items items { get; set; }
    }

}