using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    public int Health { get; set; }
    [SerializeField] private bool isPlayer;
    public bool IsPlayer => isPlayer;
}
