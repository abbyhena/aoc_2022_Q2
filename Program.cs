// See https://aka.ms/new-console-template for more information
    var choicesList = new List<string>(); 
    var splitChoicesList = new List<string>();
    int total = 0;
    
    foreach (string line in System.IO.File.ReadLines(@"/Users/dd/week-9---classes-and-objects-abbyhena/Week9ObjectsAndClassesHW/input.txt"))
        {  
            choicesList.Add(line); 
        }  
    for(int i =0; i < choicesList.Count(); i++)
        {
            if (choicesList[i] == "A X")
                {
                    total = total + 4;
                    //Console.WriteLine(total);
                 }
            if (choicesList[i] == "A Y")
                {
                    total = total + 8;
                    //Console.WriteLine(total);
                }
            if (choicesList[i] == "A Z")
                {
                    total = total + 3;
                    //Console.WriteLine(total);
                }
            else if(choicesList[i] == "B X")
                { 
                    total = total + 1;
                    //Console.WriteLine(total);
                 }
            else if(choicesList[i] == "B Y")
                {
                    total = total + 5;
                    //Console.WriteLine(total);
                }
            else if(choicesList[i] == "B Z")
                {
                    total = total + 9;
                    //Console.WriteLine(total);
                 }
            else if(choicesList[i] == "C X")
                {
                     total = total + 7;
                     //Console.WriteLine(total);
                }
            else if(choicesList[i] == "C Y")
                {
                     total = total + 2;
                    //Console.WriteLine(total);
                }
            else if(choicesList[i] == "C Z")
                {
                    total = total + 6;
                    //Console.WriteLine(total);
                }
        }
    //part 1 answer
    Console.WriteLine(total);

