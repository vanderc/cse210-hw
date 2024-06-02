using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video vid1 = new Video("Bowling Ball Vs. Trampoline from 45m!", "How Ridiculous", 631);
        vid1.Comment("rubbermaidable", "I love the way you guys talk and joke around, don't stop anything you're doing.");
        vid1.Comment("vertigatari", "This video was a game changer for their channel.");
        _videos.Add(vid1);

        Video vid2 = new Video("How to make an Easy Chroma Sphere Using Epoxy Resin and a Mold", "Ben's Worx", 1621);
        vid2.Comment("Arkie8", "The small one has to be my favorite.");
        vid2.Comment("coralmarineresinart", "They are all so amazing and beautiful");
        vid2.Comment("robbiekenan", "These are amazing");
        _videos.Add(vid2);

        Video vid3 = new Video("I Made a Huge Landscape for my Millennium Falcon", "Boylei Hobby Time", 901);
        vid3.Comment("Duri", "May the 4th be with you");
        vid3.Comment("Themodelman", "Dude the scale of this is crazy! The terrain, miniatures and landscape turned out so good!");
        vid3.Comment("alexblanch4309", "You continue to absolutely kill it! These builds are so incredible to watch");
        _videos.Add(vid3);

        foreach (Video video in _videos)
        {
            video.GetVideo();
            Console.WriteLine();
        }

    }
}