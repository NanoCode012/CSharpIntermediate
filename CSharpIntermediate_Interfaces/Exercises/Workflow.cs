using System.Collections.Generic;

namespace CSharpIntermediate_Interfaces
{
    class Workflow
    {
        private readonly IList<IActivity> _activity;
        public Workflow()
        {
            _activity = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activity.Add(activity);
        }
        public IEnumerable<IActivity> GetActivities() => _activity;
    }

}
