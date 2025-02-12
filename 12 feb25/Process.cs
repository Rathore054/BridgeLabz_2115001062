using System;

class Process
{
    public int ProcessID;
    public int BurstTime;
    public int Priority;
    public Process Next;

    public Process(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private Process head;
    private Process tail;

    public void AddProcess(int processID, int burstTime, int priority)
    {
        Process newProcess = new Process(processID, burstTime, priority);
        if (head == null)
        {
            head = newProcess;
            tail = newProcess;
            tail.Next = head;
        }
        else
        {
            tail.Next = newProcess;
            tail = newProcess;
            tail.Next = head;
        }
    }

    public void DisplayProcesses()
    {
        if (head == null) return;
        Process temp = head;
        do
        {
            Console.WriteLine("Process ID: " + temp.ProcessID + ", Burst Time: " + temp.BurstTime + ", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != head);
    }

    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();
        scheduler.AddProcess(1, 10, 2);
        scheduler.AddProcess(2, 5, 1);
        scheduler.AddProcess(3, 8, 3);

        Console.WriteLine("Process List:");
        scheduler.DisplayProcesses();
    }
}

