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
        var characterMover = other.GetComponent<ICharacterMovement>();
        trap.HandleCharacterEntered(characterMover, trapType);

    }
}

public class Trap
{
    public void HandleCharacterEntered(ICharacterMovement characterMover, TrapTargetType trapTargetType)
    {
            if (characterMover.IsPlayer)
            {
                if (trapTargetType == TrapTargetType.Player)
                    characterMover.Speed--;
            }
            else
            {
                if (trapTargetType == TrapTargetType.Npc)
                    characterMover.Speed--;
            }
        
    }
}

public enum TrapTargetType {Player, Npc}