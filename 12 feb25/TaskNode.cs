using System;

class TaskNode
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public string DueDate;
    public TaskNode Next;

    public TaskNode(int taskID, string taskName, int priority, string dueDate)
    {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskScheduler
{
    private TaskNode head = null;
    private TaskNode tail = null;

    public void AddTask(int taskID, string taskName, int priority, string dueDate)
    {
        TaskNode newTask = new TaskNode(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            tail = newTask;
            tail.Next = head; 
        }
        else
        {
            tail.Next = newTask;
            tail = newTask;
            tail.Next = head;
        }
    }

    public void RemoveTask(int taskID)
    {
        if (head == null) return;

        TaskNode temp = head, prev = null;
        if (head.TaskID == taskID)
        {
            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }
            head = head.Next;
            tail.Next = head;
            return;
        }

        do
        {
            prev = temp;
            temp = temp.Next;
        } while (temp != head && temp.TaskID != taskID);

        if (temp == head) return;

        prev.Next = temp.Next;
        if (temp == tail)
        {
            tail = prev;
        }
    }

    public void DisplayTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        TaskNode temp = head;
        do
        {
            Console.WriteLine("Task ID: " + temp.TaskID + ", Name: " + temp.TaskName + ", Priority: " + temp.Priority + ", Due Date: " + temp.DueDate);
            temp = temp.Next;
        } while (temp != head);
    }

    public void ViewCurrentTask()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }
        Console.WriteLine("Current Task: " + head.TaskID + ", " + head.TaskName);
        head = head.Next; 
    }

    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        TaskNode temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine("Task ID: " + temp.TaskID + ", Name: " + temp.TaskName + ", Due Date: " + temp.DueDate);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No tasks with the given priority.");
        }
    }

    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddTask(1, "Complete Report", 1, "2025-02-15");
        scheduler.AddTask(2, "Attend Meeting", 2, "2025-02-16");
        scheduler.AddTask(3, "Submit Assignment", 1, "2025-02-17");

        Console.WriteLine("All Tasks:");
        scheduler.DisplayTasks();

        Console.WriteLine("\nView Current Task:");
        scheduler.ViewCurrentTask();
        
        Console.WriteLine("\nView Next Task:");
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nSearch Tasks by Priority 1:");
        scheduler.SearchByPriority(1);

        Console.WriteLine("\nRemoving Task with ID 2:");
        scheduler.RemoveTask(2);
        scheduler.DisplayTasks();
    }
}
