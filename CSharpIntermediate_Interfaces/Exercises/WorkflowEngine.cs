namespace CSharpIntermediate_Interfaces
{
    class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var item in workflow.GetActivities())
                item.Execute();
        }
    }

}
