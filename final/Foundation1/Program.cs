
using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new Video("Russia Takes Bakhmut Districts, Milley Doubts Victory, Insufficient ATACMS, Russia FP Challenges US", "Alexander Mercouris", 4846);
        Video video2 = new Video("Douglas Macgregor: No More Defense Lines to Stop The Russians", "Douglas Macgregor Straight Calls", 2115);
        Video video3 = new Video("Lord of the Rings | Middle Earth Music & Ambience, 3 Hours", "Ambient Worlds", 10810);
        Video video4 = new Video("Sam Altman: OpenAI CEO on GPT-4, ChatGPT, and the Future of AI | Lex Fridman Podcast #367", "Lex Fridman", 8636);
        Video video5 = new Video("The Tree - Animation Short Film 2018 - GOBELINS", "GOBELINS", 391);

        Comment comment01 = new Comment("geoffrey ward", "UK Ministry of Defence, this is the same institution that was asked to hold down one province in Afghanistan and could not do the job and had to hand it over to the American marines in 2014, who along with the rest of Nato were unceremoniously kicked out of Afghanistan by a few farm boys with Kalashnikovs, total humiliation.");
        Comment comment02 = new Comment("GracefulCloudNine", "Mexico’s president was awesome during the summit of democracy, he gave a lesson to everyone what democracy should mean and how far away from it the collective west is.");
        Comment comment03 = new Comment("B Ilic", "I can't believe how much the ukrainian army and nato are struggling against the wagner private military company that's crazy.");
        Comment comment04 = new Comment("Andrew Krolikiewicz", "Milley NEVER led soldiers to any battle. His 4 - stars were a product of \"successful\" career in military administration. In other words - paper pusher / political appointee w/o military experience.");
        video1.SetCommentList(new List<Comment> {comment01, comment02, comment03, comment04});

        Comment comment05 = new Comment("Chris Green", "In my two decades as a Marine, I observed (as I was approaching retirement) that politics started playing larger and larger roles in who were allowed to stay and who had to leave.  It became a military of physically and mentally weak personnel with college educations over battle hardened, mentally and physically tough SOBs.  The military is a mess right now.  Those who I've mentored and trained, and who are now the leaders are having a hard time at it due to having to cater to everyone's emotions, gender identities, and moral actions.");
        Comment comment06 = new Comment("Analytics805", "'We have killed integrity in the Army...\"  Macgregor");
        Comment comment07 = new Comment("thomas bowman", "Col. MacGregor is a great American hero if only because he's so darn sensible");
        Comment comment08 = new Comment("Johnny", "The elegance and eloquence of this man talking is really cool");
        video2.SetCommentList(new List<Comment> {comment05, comment06, comment07, comment08});

        Comment comment09 = new Comment("Jake Belmore", "I will always treasure this music with fondness, my dad, who passed away last year, this was his favorite music and movies. As we were in his hospital room, before he went to his far green country under a swift sunrise, The Shire theme is the last thing he heard. When I hear this music it brings back the greatest memories. Love you Dad and thanks for sharing this with me.");
        Comment comment10 = new Comment("Tonybot", "I would rather share 3 hours of my lifetime with this music than face all the ages of this world never having heard it");
        Comment comment11 = new Comment("Greendalf", "I wish Tolkien got to hear this.");
        Comment comment12 = new Comment("Nicholas Spears", "“All we have to decide is what to do with the time that is given us.” - Gandalf");
        video3.SetCommentList(new List<Comment> {comment09, comment10, comment11, comment12});

        Comment comment13 = new Comment("Gauruv Arora", "Nice to see Sam getting interviewed by an actual AI.");
        Comment comment14 = new Comment("Mr. White", "If this intro at 0:56 doesn't make you feel like you're living in a real-life dystopian video game where you've been sent back to prevent the end of the world, i don't know what will. lol In all seriousness, amazing and very timely interview. Thanks for the work you do Lex.");
        Comment comment15 = new Comment("Axle Axle.Australian.Patriot", "Thank you for presenting this discussion. You both provided a lot of thought food and insight into the potential good, bad and difficulties presented from the advancements in AGI. Well done.");
        Comment comment16 = new Comment("Dustin L Phillips", "At 1:54ish, #HatTag@LexFridman goes beastmode.  Dude, you’re interviewing skilllz are officially the best.  This guy hones in on his guests personalities and ideals, and reciprocates accordingly.  \nThus, a more comfortable way of conversing; a mild and meager symbiosis inquisitive as its best, if at its least.  Kudos Lex");
        video4.SetCommentList(new List<Comment> {comment13, comment14, comment15, comment16});

        Comment comment17 = new Comment("fujo San", "This is... The Most heartbreaking... Yet sweetest short story animation I've ever seen.  \n\n10/10.");
        Comment comment18 = new Comment("Clockwerk Clockwerk", "the old man is good at calculation , imagine precisely predicted where water drops relative to the air");
        Comment comment19 = new Comment("Sohag Das", "To People here saying that it was pointless to water a stick.. It was also pointless to give the girl the water because she had no chance of surviving a fever in a desert. But humans live on hope.");
        Comment comment20 = new Comment("Toni Diaz", "This gives me hope, that someday I will see my son again.");
        video5.SetCommentList(new List<Comment> {comment17, comment18, comment19, comment20});

        List<Video> videoList = new List<Video> {video1, video2, video3, video4, video5};

        int videoNumber = 1;
        foreach (Video video in videoList)
        {
            string[] videoInformationArray = new string[3];
            videoInformationArray = video.GetTitleAuthorLengthArray();

            Console.WriteLine("\n-------");
            Console.WriteLine($"Video {videoNumber ++}");
            Console.WriteLine("-------");
            Console.WriteLine("Title:        " + videoInformationArray[0]);
            Console.WriteLine("Author:       " + videoInformationArray[1]);
            Console.WriteLine("Length:       " + videoInformationArray[2]);
            Console.WriteLine("(In seconds): " + videoInformationArray[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine($"Comments ({video.GetCommentNumber()} total):");
            Console.WriteLine("-------------------");

            int commentNumber = 1;
            foreach (Comment comment in video.GetCommentList())
            {
                Console.WriteLine($"   [#{commentNumber ++}] Name: " + comment.GetCommenterName());
                Console.WriteLine($"   Text: {comment.GetCommentText()}\n");
            }
            Console.Write("(Press enter.) ");
            Console.ReadLine();
        }
    }
}
