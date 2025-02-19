using System;
using System.Collections.Generic;
using System.Linq;

class Policy
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Policy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public override bool Equals(object obj)
    {
        if (obj is Policy other)
            return PolicyNumber == other.PolicyNumber;
        return false;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public override string ToString()
    {
        return "PolicyNumber: " + PolicyNumber + ", CoverageType: " + CoverageType + ", ExpiryDate: " + ExpiryDate.ToShortDateString();
    }
}

class InsurancePolicyManagement
{
    private HashSet<Policy> policySet = new HashSet<Policy>();
    private LinkedList<Policy> policyOrder = new LinkedList<Policy>();
    private SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(Comparer<Policy>.Create((x, y) => x.ExpiryDate.CompareTo(y.ExpiryDate)));
    private Dictionary<string, List<Policy>> policyNumberMap = new Dictionary<string, List<Policy>>();

    public void AddPolicy(Policy policy)
    {
        if (!policySet.Contains(policy))
        {
            policySet.Add(policy);
            policyOrder.AddLast(policy);
            sortedPolicies.Add(policy);
            if (!policyNumberMap.ContainsKey(policy.PolicyNumber))
                policyNumberMap[policy.PolicyNumber] = new List<Policy>();
            policyNumberMap[policy.PolicyNumber].Add(policy);
        }
    }

    public void DisplayAllPolicies()
    {
        Console.WriteLine("All Unique Policies:");
        foreach (var policy in policySet)
            Console.WriteLine(policy);
    }

    public void DisplayPoliciesExpiringSoon()
    {
        DateTime today = DateTime.Today;
        DateTime limit = today.AddDays(30);

        Console.WriteLine("\nPolicies Expiring Soon (Within 30 Days):");
        foreach (var policy in sortedPolicies)
        {
            if (policy.ExpiryDate <= limit)
                Console.WriteLine(policy);
        }
    }

    public void DisplayPoliciesByCoverage(string coverageType)
    {
        Console.WriteLine("\nPolicies with Coverage Type: " + coverageType);
        foreach (var policy in policySet)
        {
            if (policy.CoverageType == coverageType)
                Console.WriteLine(policy);
        }
    }

    public void DisplayDuplicatePolicies()
    {
        Console.WriteLine("\nDuplicate Policies Based on Policy Number:");
        foreach (var entry in policyNumberMap)
        {
            if (entry.Value.Count > 1)
            {
                foreach (var policy in entry.Value)
                    Console.WriteLine(policy);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        InsurancePolicyManagement management = new InsurancePolicyManagement();

        management.AddPolicy(new Policy("P123", "Health", DateTime.Today.AddDays(10)));
        management.AddPolicy(new Policy("P124", "Car", DateTime.Today.AddDays(40)));
        management.AddPolicy(new Policy("P125", "Home", DateTime.Today.AddDays(25)));
        management.AddPolicy(new Policy("P123", "Health", DateTime.Today.AddDays(15))); 

        management.DisplayAllPolicies();
        management.DisplayPoliciesExpiringSoon();
        management.DisplayPoliciesByCoverage("Health");
        management.DisplayDuplicatePolicies();
    }
}
