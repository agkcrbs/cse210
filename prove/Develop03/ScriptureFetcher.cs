using System;
using System.Collections.Generic;

class ScriptureFetcher
{
    private List<string> _scriptureKeys = new List<string>();
    private Dictionary<string, string> _scriptureDictionary = new Dictionary<string, string>()
    {
        {"Moses 1:39", "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."}, 
        {"Matthew 5:14–16", "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."}, 
        {"1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."}, 
        {"JS—H 1:15–19", "After I had retired to the place where I had previously designed to go, having looked around me, and finding myself alone, I kneeled down and began to offer up the desires of my heart to God. I had scarcely done so, when immediately I was seized upon by some power which entirely overcame me, and had such an astonishing influence over me as to bind my tongue so that I could not speak. Thick darkness gathered around me, and it seemed to me for a time as if I were doomed to sudden destruction. But, exerting all my powers to call upon God to deliver me out of the power of this enemy which had seized upon me, and at the very moment when I was ready to sink into despair and abandon myself to destruction—not to an imaginary ruin, but to the power of some actual being from the unseen world, who had such marvelous power as I had never before felt in any being—just at this moment of great alarm, I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me. It no sooner appeared than I found myself delivered from the enemy which held me bound. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other—\"This is My Beloved Son. Hear Him!\" My object in going to inquire of the Lord was to know which of all the sects was right, that I might know which to join. No sooner, therefore, did I get possession of myself, so as to be able to speak, than I asked the Personages who stood above me in the light, which of all the sects was right (for at this time it had never entered into my heart that all were wrong)—and which I should join. I was answered that I must join none of them, for they were all wrong; and the Personage who addressed me said that all their creeds were an abomination in his sight; that those professors were all corrupt; that: \"they draw near to me with their lips, but their hearts are far from me, they teach for doctrines the commandments of men, having a form of godliness, but they deny the power thereof.\""}, // “”
        {"Moses 7:18", "And the Lord called his people ZION, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them."}, 
        {"Matthew 11:28–30", "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light."}, 
        {"2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy."}, 
        {"D&C 1:37–38", "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."}, 
    };
    private Random _randomInstance = new Random();

    public ScriptureFetcher()
    {
        foreach (string _key in _scriptureDictionary.Keys)
        {
            _scriptureKeys.Add(_key);
        };
    }

    public (string, string) ReturnRandomScriptureTuple()
    {
        int randomNumber = _randomInstance.Next(0, _scriptureDictionary.Count);
        return (_scriptureKeys[randomNumber], _scriptureDictionary[_scriptureKeys[randomNumber]]);
    }
}
