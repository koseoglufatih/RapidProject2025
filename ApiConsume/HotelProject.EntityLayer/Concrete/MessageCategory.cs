using System.Collections.Generic;

namespace HotelProject.EntityLayer.Concrete
{
    public class MessageCategory
    {
        public int MessageCategoryID { get; set; }
        public string MessageCategoryName { get; set; }

        //Navigation property
        public List<Contact> Contacts { get; set; }
    }
}
