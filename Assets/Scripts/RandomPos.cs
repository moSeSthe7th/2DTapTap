﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RandomPos
{
    public static int RandomPosition(int exRandom, int samenumb)
    {
        int randomIndex = Random.Range(0, 2);

        if (exRandom == randomIndex && samenumb >= 1)
        {
            if (randomIndex == 0)
            {
                randomIndex += 1;
            }
            else if (randomIndex == 1)
            {
                randomIndex -= 1;
            }
            return randomIndex;
        }
        else if (exRandom == randomIndex && samenumb < 1)
        {
            return randomIndex;
        }
        else
        {
            return randomIndex;
        }
    }
}
