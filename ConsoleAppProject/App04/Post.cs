using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    /// <author>
    /// Muneef Mumthas - 22206529
    /// </author>
    public class Post
    {
        private static int nextPostId = 1;
        public int PostId { get; }
        private int likes;
        private int dislikes;

        private readonly List<String> comments;
        // username of the post's author
        public String Username { get; }

        public DateTime Timestamp { get; }

        // Constructor to initialize the post with its properties
        public Post(String author)
        {
            PostId = nextPostId++;
            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            dislikes = 0;
            comments = new List<String>();
        }

        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            dislikes++;
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>    

        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Post ID: {PostId}");
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes:  {likes} ");
            }
            else
            {
                Console.WriteLine($"    No Likes.");
            }

            if (dislikes > 0)
            {
                Console.WriteLine($"    Dislikes:  {dislikes} ");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    {comments.Count} comment(s):");
                foreach (string comment in comments)
                {
                    Console.WriteLine($"        {comment}");
                }
            }
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }


}