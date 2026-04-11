using System;

class Program
{
    // Added a dynamic "Leveling" display in the GoalManager.DisplayPlayerInfo 
    // to give visual feedback on progress towards ranks.
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}