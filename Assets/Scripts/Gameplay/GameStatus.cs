using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStatus
//Enum is your own tag that can have multiple locations and can be used to check
//Add public GameStatus status to Game Manager which creates a field in
//Inspector tab in Game Manager where we can select any 3 of the tags
{

    Loading, Playing, PlayerDead
}
