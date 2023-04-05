using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        Display displayObject = new Display();

        string lectureType = "Lecture";
        string lectureTitle = "The King Follet Discourse in Light of Ancient and Medieval Jewish and Christian Beliefs";
        string lectureDescription = "The King Follett discourse, delivered less than three months before Joseph Smith's death, introduced a number of new ideas related to the creation of the earth and man's origin and destiny.  This lecture discusses those concepts, dwelling on ancient and medieval Jewish and Christian beliefs.";
        string[] lectureDateTime = new string[] {"Friday, April 9, 2004", "6:00 PM"};
        string lectureAddress = "Utah Valley State College.800 West University Parkway.Orem, UT";
        string lectureSpeaker = "John Tvednes (read by Matt Roper)";
        int lectureCapacity = 50;

        string receptionType = "Reception";
        string receptionTitle = "Johnny Yourneighbour and Suzie Nevermether's Wedding Reception";
        string receptionDescription = "The Yourneighbours are thrilled to finally be able to invite you to the wedding of their son with this unknown but hopefully nice individual.  Will it last?  Please cross your fingers and help make it a memorable event for them.  The reception will immediately follow the ceremony, which will begin at 4 pm.";
        string[] receptionDateTime = new string[] {"Saturday, April 8, 2023", "4:00 PM"};
        string receptionAddress = "Joseph Smith Memorial Building.15 East South Temple Street.Salt Lake City, UT";
        string receptionEMail = "johnsusanyourneighbour@tinycompanymail.com";

        string outdoorType = "Outdoor Gathering";
        string outdoorTitle = "46th Utah Asian Festival";
        string outdoorDescription = "Join us as we celebrate carefully curated diversity, inclusion (of our kind), exclusion (of you), unassimilatable levels of in-migration, cultural dilution all around, demographic displacement, and everything except traditional Utah culture, if there ever was such a thing (but we still welcome your money as we replace you -- your fault for being so charitable! ;D ).  The day-long festival combines traditional performances you wish you still had, food you wish you could digest, crafts you wish you could afford, sub-museum-quality exhibits, and more to tempt open the wallets of young and old.";
        string[] outdoorDateTime = new string[] {"Saturday, June 3, 2023", "12:00 PM"};
        string outdoorAddress = "Utah State Fairpark.155 North 1000 West.Salt Lake City, UT";
        string outdoorWeather = "expected to be fine and sunny";

        Lecture lectureEvent = new Lecture(lectureType, lectureTitle, lectureDescription, lectureDateTime[0], lectureDateTime[1], lectureAddress, lectureSpeaker, lectureCapacity);
        Reception receptionEvent = new Reception(receptionType, receptionTitle, receptionDescription, receptionDateTime[0], receptionDateTime[1], receptionAddress, receptionEMail);
        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering(outdoorType, outdoorTitle, outdoorDescription, outdoorDateTime[0], outdoorDateTime[1], outdoorAddress, outdoorWeather);

        displayObject.DisplayMessages(lectureEvent);
        displayObject.DisplayMessages(receptionEvent);
        displayObject.DisplayMessages(outdoorGatheringEvent);
    }
}
