using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Task
{
    public List<Task> SubTasks { get; set; } = new List<Task>();
    public Task CurrentSubTask { get; set; }
    public Task NextSubTask { get; set; }

    public TaskManager TaskManager;

    public static readonly Task NONE = new Task();

    public void Start()
    {

    }

    public void Update()
    {

    }

    public void End()
    {
        TaskManager.CycleTask();
    }
}
