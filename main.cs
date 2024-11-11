using System;
class Code{
  public static void Main(string[] args){
    Console.WriteLine("Welcome to Red Scarf Girl Vocab Grade 7");
    Console.WriteLine("Start y/n");
    string start = Console.ReadLine();
    int score = 0;
    int high_score = 0;
    if(start == "y"|| start=="yes"||start=="Yes"||start=="Y"){
      while(true){
        string st = "Write the vocab word in the sentence.";
        Console.WriteLine(st);
        Console.WriteLine("The teacher shows her _____ for teaching by giving us free moneys.");
        string zealin1 = Console.ReadLine();
        if(zealin1 == "zeal"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("Wrong you moron");
          break;
        }Console.WriteLine("Define 'zeal'.");
        Console.WriteLine("a. The feeling of being excited about something | b. A strong feeling of interest or enthusiasm | c. A feeling of great energy or passion | d. UR MOM");
        string zealin2 = Console.ReadLine();
        if(zealin2 == "b" || zealin2 == "B"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("L BOZO");
          break;
        }Console.WriteLine(st);
        Console.WriteLine("The parents were surprised by their daughter’s _____ as she said, “like, this dinner is so not slay, now, uhh, I’m going on my phone to, like, watch TikTokers, which are my real parents, so, like, bye and, like, uhh”.");
        string sneerin1 = Console.ReadLine();
        if(sneerin1== "sneer"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("Ur not cooking");
          break;
        }Console.WriteLine("Define 'sneer'.");
        Console.WriteLine("a. To make someone feel uncomfortable or angry | b. To make someone feel sad or unhappy | c. To make someone feel bad or upset | d. A contemptuous or mocking smile, remark or tone");
        string sneerin2 = Console.ReadLine();
        if(sneerin2 == "d" || sneerin2 == "D"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("T_T");
          break;
        }Console.WriteLine(st);
        Console.WriteLine(" The police _____ the cause of the car accident when they saw your mom.");
        string ascerin1 = Console.ReadLine();
        if(ascerin1== "ascertained"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine(">:(");
          break;
        }Console.WriteLine("Define 'ascertained'");
        Console.WriteLine("a. To be sure of something | b. To be unsure of something | c. Figure something out for certain | d. To be sure of nothing");
        string ascerin2 = Console.ReadLine();
        if(ascerin2 == "c" || ascerin2 == "C"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine(">:)");
          break;
        }Console.WriteLine(st);
        Console.WriteLine("The team believed _____ that the other team are secretly clowns.");
        string fevein1 = Console.ReadLine();
        if(fevein1=="feverently"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("Ur bad");
          break;
        }Console.WriteLine("Define 'feverently'");
        Console.WriteLine("a. To have a really bad fever | b. To dislike | c. Passionately, with intense emotion and belief | d. To have a love-hate relationship");
        string fevein2 = Console.ReadLine();
        if(fevein2 == "c" || fevein2 == "C"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("really?");
          break;
        }Console.WriteLine(st);
        Console.WriteLine("The heroes of the novel _____ the bad guy from soap operas");
        string liberin1 = Console.ReadLine();
        if(liberin1=="liberated"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("YOUR MOM IS SO FAT SHE EATS FOOD WITH A FORKLIFT AND A SHOVEL");
          break;
        }Console.WriteLine("Define 'liberated'");
        Console.WriteLine("a. To receive liberty | b. To free| c. To be freed from having rights | d. To have rights");
        string liberin2 = Console.ReadLine();
        if(liberin2 == "b" || liberin2 == "B"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("This is sad");
          break;
        }Console.WriteLine(st);
        Console.WriteLine("The landlady slowly rose from her rocking chair and _____ went to take a dump.");
        string werl1 = Console.ReadLine();
        if(werl1=="wearily"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("??????????????????????????????????????????????????????");
          break;
        }Console.WriteLine("Define 'wearily'");
        Console.WriteLine("a. To do something tiredly | b. To dislike | c. To do something with clothes | d. To have a love-hate relationship");
        string werl2 = Console.ReadLine();
        if(werl2=="a" || werl2=="A"){
          Console.WriteLine("Correct!");
          score = score + 1;
          Console.WriteLine("Score = "+score);
        }else{
          Console.WriteLine("This is torture");
          break;
        }
      }
    }
  }
}