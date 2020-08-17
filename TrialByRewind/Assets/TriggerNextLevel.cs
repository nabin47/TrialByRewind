using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class TriggerNextLevel : MonoBehaviour
{
   public LevelLoader levelLoader;
   public void OnTriggerEnter2D(Collider2D other)
    {
        levelLoader.LoadNextLevel();
    }
}
