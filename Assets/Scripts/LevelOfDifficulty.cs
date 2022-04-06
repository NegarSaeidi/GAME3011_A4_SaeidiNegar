using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOfDifficulty : MonoBehaviour
{
   public void OnEasy()
    {
        GridGeneration.gridSize = 10;
        GridGeneration.regenerateTiles = true;
    }
    public void OnMedium()
    {
        GridGeneration.gridSize = 5;
        GridGeneration.regenerateTiles = true;
    }
    public void OnHard()
    {
        GridGeneration.gridSize =3;
        GridGeneration.regenerateTiles = true;
    }
}
