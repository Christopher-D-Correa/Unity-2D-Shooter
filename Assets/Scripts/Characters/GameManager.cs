using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
//Monobehaviour makes objects attachable
//Outside of Monobehaviour classes need to be manually created 
{
    public static GameManager instance;

    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private Transform[] spawnPointsArray;
    [SerializeField] private List<GameObject> listOfAllEnemiesAlive;

    private ScoreManager scoreManager;
   
    public List<GameObject> EnemyList = new List<GameObject>();
    

    void Start()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }

        StartCoroutine(SpawnWaveOfEnemies());
        scoreManager = GetComponent<ScoreManager>();
    } 


    void Update()
    {


    }



    private GameObject SpawnEnemy()
    {
        int randomIndex = Random.Range(0, spawnPointsArray.Length);
        Transform randomSpawnPoint = spawnPointsArray[randomIndex];
        /*
        int roll = Random.Range(0, 15);
        GameObject Prefab;
        if (roll < 10)
        {
            Prefab = EnemyList[1];

        }

        else if (roll < 13)
        {
            Prefab = EnemyList[0]; 
        }

        else
        {
            Prefab = EnemyList[2];
        }
        */
        GameObject Prefab = EnemyList[Random.Range(0, EnemyList.Count)];
        GameObject enemyClone = Instantiate(Prefab, randomSpawnPoint.position, randomSpawnPoint.rotation);
        listOfAllEnemiesAlive.Add(enemyClone);
        return enemyClone;
        //enemyClone.healthValue.OnDied.AddListener(RemoveEnemyFromList);
    }

    public void RemoveEnemyFromList(GameObject enemyToBeRemoved)

    {
        scoreManager.IncreaseScore(ScoreType.EnemyKilled);
        int enemy = EnemyList.IndexOf(enemyToBeRemoved);
        listOfAllEnemiesAlive.RemoveAt(enemy);

        /*
        for (int index = 0; index < listOfAllEnemiesAlive.Count; index++)
        //for this variable called index starting at 0, the condition of how long I will do the loop (while index is less than 0), whenever this thing happens increase by 1  
        {
            if (listOfAllEnemiesAlive[index] == null)
            {
                listOfAllEnemiesAlive.RemoveAt(index);
            }
        }
        */
    } 

    private IEnumerator SpawnWaveOfEnemies()

    {
        
        while (true)
        {
            if (listOfAllEnemiesAlive.Count < 15)
            {
                GameObject clone = SpawnEnemy();
                //yield return new WaitForEndOfFrame();
                //clone.healthValue.OnDied.AddListener(RemoveEnemyFromList);
            }
            //do something here
            yield return new WaitForSeconds(Random.Range(1, 6));
            //do something after 5 seconds

        }

    }




}
