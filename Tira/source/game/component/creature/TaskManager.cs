using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class TaskManager : Component
{
    public List<Task> Tasks { get; set; } = new List<Task>();
    public Task CurrentTask { get; set; } = Task.NONE;
    public Task NextTask { get; set; } = Task.NONE;
    public Task PreviousTask { get; set; } = Task.NONE;

    public void AddTask(Task task)
    {
        task.TaskManager = this;
        Tasks.Add(task);

        if (Tasks.Count == 1) SetCurrentTask(task);
    }

    public void CycleTask()
    {
        CurrentTask.End();
        RemoveTask(CurrentTask);

        CurrentTask = Task.NONE;

        if(Tasks.Count > 0) SetCurrentTask(NextTask);
    }

    public void RemoveTask(Task task)
    {
        Tasks.Remove(task);
    }

    public void SetCurrentTask(Task task)
    {
        CurrentTask = task;

        CurrentTask.Start();
    }

    public override void Update()
    {
        CurrentTask.Update();

        base.Update();
    }


}
