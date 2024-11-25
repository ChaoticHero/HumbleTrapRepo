using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterMovement
{
   int Health {get; set; }
   int Speed { get; set; }
   bool IsPlayer {get;}
    bool IsDrowned { get; set; }
}
