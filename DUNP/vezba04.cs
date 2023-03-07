

using System;

namespace Post{
    class ConsoleApp
{
    static void Main(string[] args)
    {
        Post p = new Post("How to secure class member",
        "I want know how I could secure my class members",
        "1.3.2023");
        for(int i = 0; i < 10;i++){
            p.UpScore();
        }
           for(int i = 0; i < 3;i++){
            p.DownScore();
        }
        System.Console.WriteLine(p.ToString());

    }
}

public class Post{
    private int score;
    public string title;
    public string description;
    public string CreatedDateTime;
    public string Title { get; set; }
    public string Description { get; set; }
    public string  CreatedDateTimeSetGet{ get; set; }

    public Post(string title, string description, string createdDateTime){
        Title = title;
        Description = description;
        CreatedDateTimeSetGet = createdDateTime;
        score = 0;
    }
    public void UpScore(){
        score++;
    }
    public void DownScore(){
        score--;
    }
   public override string ToString(){
    return "Post with title: " + Title + ", has score: " + score;
   }


}

}
