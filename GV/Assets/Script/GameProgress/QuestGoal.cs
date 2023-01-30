using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    public GoalType goaltype;

    public string puzzleCombination;

    public int requiredAmount;
    public int currentAmount;

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }
    public void areaExplored()
    {
        if (goaltype == GoalType.Exploring)
        {
            currentAmount++;

        }
    }
    public void puzzleSolved()
    {
        if (goaltype == GoalType.SolvePuzzle)
        {
            currentAmount++;

        }
    }
    public void gotTreasure()
    {
        if (goaltype == GoalType.TreasureHunting)
        {
            currentAmount++;

        }
    }
    public void itemCollected()
    {
        if (goaltype == GoalType.Gathering)
        {
            currentAmount++;

        }
    }
    //public bool puzzleSolved()
    //{
    //    return (puzzleCombinationManager.combination == puzzleCombination);
    //}
}
public enum GoalType
{
    Exploring,
    SolvePuzzle,
    TreasureHunting,
    Gathering
}