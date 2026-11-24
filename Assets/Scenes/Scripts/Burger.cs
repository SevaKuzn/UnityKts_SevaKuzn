using UnityEngine;
using System;

public class Burger : MonoBehaviour
{

    void MakeBurger(string ing1, string ing2, string ing3, string ing4, out string burgerResult)
    {
        string[] inputs = { ing1, ing2, ing3, ing4 };

        string[] cheeseburgerReqs = { "сыр", "кетчуп", "котлета", "огурец" };
        string[] bigMacReqs = { "специальный соус", "булочка с кунжутом", "две котлеты", "салат" };

        if (CheckExactMatch(inputs, cheeseburgerReqs))
        {
            burgerResult = "чизбургер";
        }
        else if (CheckExactMatch(inputs, bigMacReqs))
        {
            burgerResult = "биг мак";
        }
        else
        {
            burgerResult = "неизвестный бургер";
        }
    }

    bool CheckExactMatch(string[] inputs, string[] requirements)
    {
        if (inputs.Length != requirements.Length) return false;

        string[] sortedInputs = (string[])inputs.Clone();
        string[] sortedReqs = (string[])requirements.Clone();

        Array.Sort(sortedInputs);
        Array.Sort(sortedReqs);

        for (int i = 0; i < sortedInputs.Length; i++)
        {
            if (sortedInputs[i] != sortedReqs[i])
                return false;
        }

        return true;
    }
}