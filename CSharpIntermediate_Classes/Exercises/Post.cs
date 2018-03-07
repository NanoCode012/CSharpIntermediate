using System;

namespace CSharpIntermediate_Classes
{
    class Post{
        string _title;
        string _description;
        DateTime _dateCreated;
        int vote = 0;

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _dateCreated = DateTime.Now;
        }

        public void Upvote() => vote++;
        public void Downvote() => vote--;
        public int GetVote() => vote;

    }
}
