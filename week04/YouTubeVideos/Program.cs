using System;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video videos = new Video();
        videos.setVideo("James", "New York Blog", "30:45");
        videos.setVideo("Renji", "Chill in Rocket League", "20:04");
        videos.setVideo("PedroGaming", "24 hours of Fortnite", "24:09");

        Comment comments = new Comment();
        comments.setText("Chill in Rocket League","PedroGaming", "Wow, you're bad player, you don't deserve my like");
        comments.setText("Chill in Rocket League","StephenPro2017", "Yooo brooo, you're playing so well for your rank, DON'T GIVE UP!");
        comments.setText("Chill in Rocket League","Elon Musk", "I want you in my new Gaming Team, are you interested?");

        comments.setText("New York Blog","John Marcus", "That house looks awesome, it's seems like a millionare house");
        comments.setText("New York Blog","John Marcus", "Great video! Would you like to make one with me?");
        comments.setText("New York Blog","Ikea", "Awesome furniture, it seems like we sent it (blink blink)");

        comments.setText("24 hours of Fortnite","MichaelAlan19", "This live is too boring");
        comments.setText("24 hours of Fortnite","Peter Parker", "I can climb better");
        comments.setText("24 hours of Fortnite","AuraFarmer21", "Awesome live, I'll give you my like");

        


        Dictionary<string, Dictionary<string, List<string>>> videoComents = comments.getText();
        videos.setComment(videoComents);
        
        videos.getVideoTest();

    }
}
