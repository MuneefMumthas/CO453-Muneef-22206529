using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Muneef Mumthas - 22206529
    /// </author>
    public class SocialNetwork
    {
        private NewsFeed news = new NewsFeed();
        
        public void Run()
        {
            Choices();
        }
        public void Choices()
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please select a choice (1-8)");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Post a message");
            Console.WriteLine("2. Post an image");
            Console.WriteLine("3. Comment on a post");
            Console.WriteLine("4. Delete a post");
            Console.WriteLine("5. Like or dislike a post");
            Console.WriteLine("6. Show posts by an author");
            Console.WriteLine("7. Show all posts");
            Console.WriteLine("8. Quit");
            Console.WriteLine();
            Console.Write("Answer: ");

            int ChoiceNumber = 0;
            while (ChoiceNumber == 0)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice) && (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6 || choice == 7 || choice == 8))
                {
                    ChoiceNumber = choice;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please enter a valid input (1-8).");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }

            if (ChoiceNumber == 1)
            {
                Console.WriteLine();
                PostMessage();
            }

            else if (ChoiceNumber == 2)
            {
                Console.WriteLine();
                PostImage();
            }

            else if (ChoiceNumber == 3)
            {
                Console.WriteLine();
                AddCommentToPost();
            }

            else if (ChoiceNumber == 4)
            {
                Console.WriteLine();
                DeletePost();
            }

            else if (ChoiceNumber == 5)
            {
                Choices();
            }

            else if (ChoiceNumber == 6)
            {
                Choices();
            }

            else if (ChoiceNumber == 7)
            {
                Console.WriteLine();
                DisplayAll();
            }

            else if (ChoiceNumber == 8)
            {
                Environment.Exit(0);
            }
        }

        public void PostMessage()
        {
            news.PostMessage();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Message posted.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Choices();
        }

        public void PostImage()
        {
            news.PostPhoto();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Photo posted.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Choices();
        }

        public void AddCommentToPost()
        {
            news.AddCommentToPost();
            Console.WriteLine("");
            Choices();
        }

        public void DeletePost()
        {
            news.DeletePostById();
            Console.WriteLine("");
            Choices();
        }
        public void DisplayAll()
        {
            news.Display();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("-------------- End of Posts -------------");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Choices();
        }

    }
    
}
