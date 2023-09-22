using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentStats : MonoBehaviour
{
    public Stats stats;
    public Stats currentStats;
    private void Awake()
    {
        currentStats = stats;
    }
}
