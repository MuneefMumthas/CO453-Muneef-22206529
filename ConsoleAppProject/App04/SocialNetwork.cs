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
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select a choice (1-8)");
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
            Console.WriteLine();
        
        }


    }
    
}
