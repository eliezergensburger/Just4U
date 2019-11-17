using System;

namespace Targil2
{
    public class GuestRequest
    {
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsApproved { get;  set; }

        public override string ToString()
        {
            String result = "";

            result += String.Format("Entry date is : {0}, Release date is :{1}", EntryDate, ReleaseDate);
            result += "Status is : " + ((IsApproved) ? "" : "not ") + "approved";

            return result;
        }
    }
}