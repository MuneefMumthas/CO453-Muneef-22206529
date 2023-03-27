using System;
using System.Collections.Generic;


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
            MessagePost post = new MessagePost(AUTHOR, "Ramadan Kareem");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "image1.jpg", "Ramadan Wishes");
            AddPhotoPost(photoPost);
        }


        // Method to post a message
        public void PostMessage()
        {
            Console.Write("Enter your name: ");
            string author = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Enter your message: ");
            string message = Console.ReadLine();
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
           Console.Write("Enter your name: ");
           string author = Console.ReadLine();
           Console.WriteLine("");

           Console.Write("Enter the file name: ");
           string filename = Console.ReadLine();
           Console.WriteLine("");

          Console.Write("Enter the photo caption: ");
          string caption = Console.ReadLine();
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

        // Method to Add a comment to the posts
        public void AddCommentToPost()
        {
            Console.Write("Enter post ID to add comment: ");
            int postId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Post post = posts.Find(p => p.PostId == postId);
        
            if (post != null)
            {
                Console.Write($"Enter comment for post {postId}: ");
                string comment = Console.ReadLine();
                Console.WriteLine("");

                post.AddComment(comment);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Comment added successfully!");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Post with ID {postId} not found!");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
        
        /// Method to delete a post by ID
        public void DeletePostById()
        {
            
            Console.Write("Enter post ID to delete the post: ");
            int postId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Post post = posts.Find(p => p.PostId == postId);

            if (post == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Post with ID {postId} not found!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                return;
            }

            posts.Remove(post);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Post deleted successfully!");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        
        // Method to Like or dislike a post
        public void LikeOrUnlikePost()
        {
            Console.Write("Enter the ID of the post you want to like or dislike: ");
            int postId = int.Parse(Console.ReadLine());
        
            // find the post with the matching ID
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
                        // remove the like
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
                Console.ForegroundColor = ConsoleColor.Cyan;
                return;
            }
        }

        public void ShowPostsByAuthor()
        {
            Console.Write("Enter the author's name: ");
            string authorName = Console.ReadLine();
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
