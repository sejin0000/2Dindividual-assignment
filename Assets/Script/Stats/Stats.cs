using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Stats", menuName = "ScriptableObject/Stats", order = 0)]
public class Stats : ScriptableObject
{
    [Header("정보")]
    public int 최대_체력;
    public int 공격력;
    public int 이동속도;
    public LayerMask 공격_가능_대상;
}
