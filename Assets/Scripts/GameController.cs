using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [Header("Shape Object")]
    public GameObject[] shapePrefabs;
    [Header("Default spawn Delay Time")]
    public float spawnDelay = 2f;
     [Header("Default spawn Time")]
     public float spawnTime = 3f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }
    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }
   
   public void GameOver()
   {
   
    CancelInvoke("Spawn");
   
   Time.timeScale = 0;
   
   gameOverCanvas.SetActive(true);

   }
    // Update is called once per frame
    void Update()
    {

    }
          
          [Header("Game Over UI Object")]
          public GameObject gameOverCanvas;


          //gameOverCanvas.SetActive(true);
            
         //Time.timeScale = 0;
          

}

