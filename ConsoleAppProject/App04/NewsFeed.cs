﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    /// Muneef Mumthas - 22206529
    ///</author> 
    public class NewsFeed 
    {
        public const string AUTHOR = "Muneef Mumthas";
        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
        }


        // Method to post a message
        public void PostMessage()
        {
            string author = "";
            while (string.IsNullOrWhiteSpace(author))
            {
                Console.Write("Enter your name: ");
                author = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(author))
                {
                    /// error message for empyt input
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (author.Any(char.IsDigit))
                {
                    /// error message for numbers in the name
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Name cannot contain numbers. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    author = "";
                }
            }

            Console.WriteLine("");

            string message = "";
            while (string.IsNullOrWhiteSpace(message))
            {
                Console.Write("Enter your message: ");
                message = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(message))
                {
                    /// error message for empyt input
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Message cannot be empty. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }

            Console.WriteLine("");

            MessagePost post = new MessagePost(author, message);
            AddMessagePost(post);
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        // Method to post a photo
        public void PostPhoto()
        {
            string author = "";
            while (string.IsNullOrWhiteSpace(author))
            {
                Console.Write("Enter your name: ");
                author = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(author))
                {
                    /// error message for empty input
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (author.Any(char.IsDigit))
                {
                    /// error message for numbers in the name
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Name cannot contain numbers. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    author = "";
                }
            }

            Console.WriteLine("");

            string filename = "";
            while (string.IsNullOrWhiteSpace(filename))
            {
                Console.Write("Enter the file name: ");
                filename = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(filename))
                {
                    /// error message for empty input
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("File name cannot be empty. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }

            Console.WriteLine("");

            string caption = "";
            while (string.IsNullOrWhiteSpace(caption))
            {
                Console.Write("Enter the photo caption: ");
                caption = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(caption))
                {
                    /// error message for empty input
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Caption cannot be empty. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }

            Console.WriteLine("");

            PhotoPost post = new PhotoPost(author, filename, caption);
            AddPhotoPost(post);
        }


        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        // Method to Enter PostId
        private int GetPostId()
        {
            int postId = 0;
            while (postId <= 0)
            {
                Console.Write("Enter post ID: ");
                if (!int.TryParse(Console.ReadLine(), out postId) || postId <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Invalid input. The ID must be a positive integer.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }
            Console.WriteLine("");
            return postId;
        }

        // Method to Add a comment to the posts
        public void AddCommentToPost()
        {
            int postId = GetPostId();
            Post post = posts.Find(p => p.PostId == postId);

            if (post != null)
            {
                string comment = "";
                while (string.IsNullOrWhiteSpace(comment))
                {
                    Console.Write($"Enter comment for post {postId}: ");
                    comment = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(comment))
                    {
                        /// error message for empty input for comment
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Comment cannot be empty. Please try again.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
                Console.WriteLine("");

                post.AddComment(comment);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Comment added successfully!");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                /// error message for invalid post ID
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Post with ID {postId} not found!");
                Console.WriteLine("Please check the ID and try again.");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }

        /// Method to delete a post by ID
        public void DeletePostById()
        {
            int postId = GetPostId();
            Post post = posts.Find(p => p.PostId == postId);

            if (post != null)
            {
                string confirmation = "";
                while (confirmation != "1" && confirmation != "2")
                {
                    /// prompt to confirm deletion of the selected post
                    Console.Write("Are you sure you want to delete this post?");
                    Console.WriteLine("");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.WriteLine("");
                    Console.Write("Answer: ");
                    confirmation = Console.ReadLine();

                    if (confirmation != "1" && confirmation != "2")
                    {
                        /// error message for invalid selection
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Invalid input. Please enter either 1 or 2.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }

                if (confirmation == "1")
                {
                    posts.Remove(post);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Post deleted successfully!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (confirmation == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("");
                    Console.WriteLine("Post deletion canceled as requested.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    return;
                }
            }
            else
            {
                /// error message for invalid post ID
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Post with ID {postId} not found!");
                Console.WriteLine("Please check the ID and try again.");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }

        // Method to Like or dislike a post
        public void LikeOrUnlikePost()
        {
            int postId = GetPostId();
            Post post = posts.Find(p => p.PostId == postId);

            if (post != null)
            {
                bool validChoice = false;
                while (!validChoice)
                {
                    // ask user if they want to like or unlike the post
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to like or dislike this post?");
                    Console.WriteLine("");
                    Console.WriteLine("1. Like");
                    Console.WriteLine("2. DisLike");
                    Console.WriteLine("");
                    Console.Write("Answer: ");
                    string choice = Console.ReadLine().ToLower();
                    Console.WriteLine("");

                    if (choice == "1")
                    {
                        // record the like
                        post.Like();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have liked this post.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        validChoice = true;
                    }
                    else if (choice == "2")
                    {
                        // record the dislike
                        post.Unlike();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have disliked this post.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        validChoice = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Please enter valid input (1 or 2).");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("");
                Console.WriteLine($"Post with ID {postId} not found!");
                Console.WriteLine("Please check the ID and try again.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                return;
            }
        }

        /// Method to filter posts by author
        public void ShowPostsByAuthor()
        {
            string authorName = "";
            while (string.IsNullOrWhiteSpace(authorName))
            {
                Console.Write("Enter the author's name: ");
                authorName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(authorName))
                {
                    /// error message for empyt input
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (authorName.Any(char.IsDigit))
                {
                    /// error message for numbers in the name
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Name cannot contain numbers. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    authorName = "";
                }
            }
            Console.WriteLine("");

            bool foundPosts = false;

            foreach (Post post in posts)
            {
                if (post.Username == authorName)
                {
                    if (!foundPosts)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("=========================================");
                        Console.WriteLine("");
                        Console.WriteLine($"          Posts by {authorName}          ");
                        Console.WriteLine("");
                        Console.WriteLine("=========================================");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        foundPosts = true;
                    }
                    post.Display();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("=========================================");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    foundPosts = true;
                }
            }

            if (!foundPosts)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No posts found for the given author.");
                Console.WriteLine("Please enter the author's name exactly as it appears in the feed.");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------- All Posts ---------------");
            Console.WriteLine("");
            Console.WriteLine("=========================================");
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (posts.Count == 0)
            {

                // Error message if there is no posts
                Console.WriteLine("");
                Console.WriteLine("          No Posts Available :(          ");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=========================================");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");

            }
            else
            {
                // display all text posts
                foreach (Post post in posts)
                {
                    post.Display();
                    // line to seperate posts
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("=========================================");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }

        }
    }

}
