using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRule : MonoBehaviour
{
  [SerializeField] private ScoreCounter score;
  [SerializeField] private ScoreCounter bid;


  public void GetWall()
  {
    score.TakeAway(bid.Score);
    
  }
  public void GetTreasures()
  {
    score.Add(bid.Score);
  }
  
}
