using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        Video v1 = new Video();
        v1._title = "My life";
        v1._author = "James";
        v1._length = 275;

        Video v2 = new Video();
        v2._title = "A sad story";
        v2._author = "Sally";
        v2._length = 300;

        Video v3 = new Video();
        v3._title = "Christmas prank!!";
        v3._author = "Bernie";
        v3._length = 120;

        Comment c1 = new Comment();
        Comment c2 = new Comment();
        Comment c3 = new Comment();
        c1._name = "Bernie";
        c1._comment = "Nice video!";
        c2._name = "Lynn";
        c2._comment = "I love this video!";
        c3._name = "Peterson";
        c3._comment = "Pretty good";
        v1._comment.Add(c1);
        v1._comment.Add(c2);
        v1._comment.Add(c3);
        v1.Display();

        Console.WriteLine();

        Comment co1 = new Comment();
        Comment co2 = new Comment();
        Comment co3 = new Comment();
        co1._name = "周杰倫";
        co1._comment = "哎呦不錯喔～";
        co2._name = "Manson";
        co2._comment = "This video touched my heart!";
        co3._name = "Ben";
        co3._comment = "I don't get it...";
        v2._comment.Add(co1);
        v2._comment.Add(co2);
        v2._comment.Add(co3);
        v2.Display();

        Console.WriteLine();

        Comment com1 = new Comment();
        Comment com2 = new Comment();
        Comment com3 = new Comment();
        com1._name = "Lynn";
        com1._comment = "Stop doing this!";
        com2._name = "May";
        com2._comment = "This's not fun!";
        com3._name = "Benj";
        com3._comment = "Hahahahaha";
        v3._comment.Add(com1);
        v3._comment.Add(com2);
        v3._comment.Add(com3);
        v3.Display();
    }
}