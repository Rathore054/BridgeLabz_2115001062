using System;
using System.Collections.Generic;

class VotingSystem
{
    private Dictionary<string, int> voteCount = new Dictionary<string, int>();
    private SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>();
    private LinkedList<string> voteOrder = new LinkedList<string>();

    public void CastVote(string candidate)
    {
        voteOrder.AddLast(candidate);

        if (voteCount.ContainsKey(candidate))
            voteCount[candidate]++;
        else
            voteCount[candidate] = 1;
    }

    public void DisplayVoteCount()
    {
        Console.WriteLine("Vote Count:");
        foreach (var entry in voteCount)
            Console.WriteLine(entry.Key + ": " + entry.Value);
    }

    public void DisplaySortedResults()
    {
        sortedResults = new SortedDictionary<string, int>(voteCount);

        Console.WriteLine("\nSorted Voting Results:");
        foreach (var entry in sortedResults)
            Console.WriteLine(entry.Key + ": " + entry.Value);
    }

    public void DisplayVoteOrder()
    {
        Console.WriteLine("\nVote Order:");
        foreach (var vote in voteOrder)
            Console.Write(vote + " -> ");
        Console.WriteLine("End");
    }
}

class Program
{
    static void Main()
    {
        VotingSystem votingSystem = new VotingSystem();

        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Charlie");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");

        votingSystem.DisplayVoteCount();
        votingSystem.DisplaySortedResults();
        votingSystem.DisplayVoteOrder();
    }
}
