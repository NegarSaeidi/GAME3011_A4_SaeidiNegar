using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelOfDifficulty : MonoBehaviour
{
    public TextMeshProUGUI colorHint;
    public TextMeshProUGUI placeHint;
    public void OnEasy()
    {
        GridGeneration.gridSize = 10;
        GridGeneration.regenerateTiles = true;
        Timer.time = 300;
        colorHint.text =  "";
        placeHint.text =  "";
    }
    public void OnMedium()
    {
        GridGeneration.gridSize = 5;
        GridGeneration.regenerateTiles = true;
        Timer.time = 150;
        colorHint.text = "";
        placeHint.text = "";
    }
    public void OnHard()
    {
        GridGeneration.gridSize =3;
        GridGeneration.regenerateTiles = true;
        Timer.time = 120;
        colorHint.text = "";
        placeHint.text = "";
    }
}
