using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData : MonoBehaviour
{
    public int num;

    public PlayerData(Player player)
    {
        num = player.num;

    }
}
