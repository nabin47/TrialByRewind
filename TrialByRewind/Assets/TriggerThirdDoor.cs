using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class TriggerThirdDoor : MonoBehaviour
{
    public LoadThirdDoor levelLoader;
    public void OnTriggerEnter2D(Collider2D other)
    {
        levelLoader.LoadNextLevel();
    }
}
