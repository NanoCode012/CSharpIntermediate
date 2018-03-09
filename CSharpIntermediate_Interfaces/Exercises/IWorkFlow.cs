using System.Collections.Generic;

namespace CSharpIntermediate_Interfaces
{
    interface IWorkFlow
    {
        void Add(IActivity activity);
        IEnumerable<IActivity> GetActivities();

    }

}
