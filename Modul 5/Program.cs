using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class SayaTubeUser
{
    int id;
    List<SayaTubeVideo> uploadVideo;
    string Username;
    public SayaTubeUser(string profile)
    {
        this.Username = profile;
        Random generate = new Random();
        this.id = generate.Next(0, 100000);
        uploadVideo = new List<SayaTubeVideo>();

    }
    public void GetTotalVideoplayCount()
    {
        int dataplayCount = 0;
        foreach (SayaTubeVideo video in uploadVideo)
        {
            dataplayCount = dataplayCount + video.GetPlaycount();
        }
    }
    public void addVideo(SayaTubeVideo data)
    {
        uploadVideo.Add(data);
    }

    public void printAllvideoplayCount()
    {

        for (int i = 0; i < uploadVideo.Count; i++)
        {
            Console.WriteLine("username:" + Username);
            Console.WriteLine("video:" + (i + 1) + ":" + uploadVideo[i]);
        }

    }
}


internal class SayaTubeVideo
{
    int id;
    string title;
    int playCount;


    public SayaTubeVideo()
    {
        Random generate = new Random();
        this.id = generate.Next(0, 100000);
        this.playCount = 0;
    }

    public void IncreaseplayCount(int angka)
    {
        playCount = playCount + angka;
    }

    public int GetPlaycount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }

    public void printVideoDetails()
    {
        Console.WriteLine("title: " + title);
        Console.WriteLine("id: " + id);
        Console.WriteLine("playCount:" + playCount);
    }


}