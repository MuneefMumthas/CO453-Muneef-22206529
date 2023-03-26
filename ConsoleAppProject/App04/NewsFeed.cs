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
                Console.WriteLine("Comment added successfully!");
            }
            else
            {
                Console.WriteLine($"Post with ID {postId} not found!");
            }
        }
        
        // Method to delete a post by ID
        public void DeletePostById()
        {
            
            Console.Write("Enter post ID to delete the post: ");
            int postId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Post post = posts.Find(p => p.PostId == postId);

            if (post == null)
            {
                Console.WriteLine($"No post found with ID {postId}");
                return;
            }

            posts.Remove(post);

            Console.WriteLine("Post deleted successfully!");
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=========================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
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
