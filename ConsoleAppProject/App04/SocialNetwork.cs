﻿using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class represents a social network and allows users to perform 
    /// various actions such as posting messages and images, 
    /// commenting, deleting, and liking posts.
    /// </summary>
    /// <author>
    /// Muneef Mumthas - 22206529
    /// </author>
    public class SocialNetwork
    {
        private NewsFeed news = new NewsFeed();

        /// Method to run the social network program.
        public void Run()
        {
            Choices();
        }
        /// Method to display the list of available actions
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
            Console.WriteLine("7. Show all posts (Feed)");
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

            // Perform action based on user input
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
                Console.WriteLine();
                LikeOrDislikePost();
            }

            else if (ChoiceNumber == 6)
            {
                Console.WriteLine();
                ShowPostsByAuthor();
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

        /// Method to post a message
        public void PostMessage()
        {
            news.PostMessage();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Message posted.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Choices();
        }

        /// Method to post an image
        public void PostImage()
        {
            news.PostPhoto();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Photo posted.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Choices();
        }

        /// Method to add a comment to a post
        public void AddCommentToPost()
        {
            news.AddCommentToPost();
            Console.WriteLine("");
            Choices();
        }

        /// Method to delete a post
        public void DeletePost()
        {
            news.DeletePostById();
            Console.WriteLine("");
            Choices();
        }

        /// Method to like or Dislike a post
        public void LikeOrDislikePost()
        {
            news.LikeOrUnlikePost();
            Console.WriteLine("");
            Choices();
        }

        /// Method to filter posts by author
        public void ShowPostsByAuthor()
        {
            news.ShowPostsByAuthor();
            Console.WriteLine("");
            Choices();
        }
        
        /// Method to display all available posts
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
