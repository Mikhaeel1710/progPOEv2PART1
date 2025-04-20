namespace progPOEv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Response("What is your name?");
            Console.ForegroundColor = ConsoleColor.White;//change colour to indicate user input
            string username = Console.ReadLine();
            int choice, choice2;

            Boolean end1, end2;//to determnine if while loops end
            end1 = false;
            end2 = false;


            Console.Clear();

            while (end1 == false)
            {
                Response(@$"What would you like to talk about today {username}?
(1) How are you?
(2) What's your purpose?
(3) What can I ask you about?
(0) Quit");
                Console.ForegroundColor = ConsoleColor.White;
                if (int.TryParse(Console.ReadLine(), out choice))//ensure that value entered is an integer
                {

                    switch (choice)
                    {
                        case 1:
                            Response("I am doing fantastic today! I hope you are doing amazing today and staying safe online" + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;


                        case 2:
                            Response("My purpose is to inform you on the dangers out there online and asssist you in ways to remain safe." + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;


                        case 3:
                            Console.Clear();
                           

                            while (end2 == false)
                            {
                                Response(@$"What would you like to ask me today {username}?
(1) Password Safety
(2) Phishing
(3) Safe Browsing
(4) Watch What You Post
(0) Return");
                                Console.ForegroundColor = ConsoleColor.White;
                                if (int.TryParse(Console.ReadLine(), out choice2))

                                {
                                    switch (choice2)
                                    {
                                        case 1:
                                            Response("");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;

                                        case 2:
                                            Response("");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;

                                        case 3:
                                            Response("");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;

                                        case 4:
                                            Response("");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;

                                        case 0:
                                            end2 = true;
                                            break;
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("I didnt quite get that, please rephrase");

                                }


                            }
                            Console.Clear();
                            
                            break;

                        case 0:
                            end1 = true;
                            break;



                    }



                }
                else
                {
                    Console.WriteLine("I didnt quite get that, please rephrase");
                }
            }
            Response("Thank You!");
            Environment.Exit(0);



        }
        static void Response(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;// making response a different color
            Console.WriteLine("[Chatbot]: ");
            foreach (char character in message)
            {
                Console.Write(character);
                Thread.Sleep(30); // changes speed at which the words are written
            }
            Console.WriteLine();
        }
    
    }
}
