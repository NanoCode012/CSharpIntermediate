namespace CSharpIntermediate_Interfaces
{
    class WorkflowEngine
    {
        public void Run(IWorkFlow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
				activity.Execute();
            }
        }
    }

}
