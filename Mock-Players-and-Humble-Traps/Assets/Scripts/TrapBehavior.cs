using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehavior : MonoBehaviour
{
    [SerializeField] private TrapTargetType trapType;
    private Trap trap;

    private void Awake()
    {
        trap = new Trap();
    }

    private void OnTriggerEnter(Collider other)
    {
        IPlayer playerMover = other.GetComponent<IPlayer>();
        trap.HandleCharacterEntered(playerMover, trapType);
    }
}

public class Trap
{
    public void HandleCharacterEntered(IPlayer playerMover, TrapTargetType trapTargetType)
    {
        if (playerMover.IsPlayer)
        {
            if (trapTargetType == TrapTargetType.Player)
                playerMover.Health--;
        }
        else
        {
            if (trapTargetType == TrapTargetType.NPC)
                playerMover.Health--;
        }
    }
}

public enum TrapTargetType {Player , NPC}
