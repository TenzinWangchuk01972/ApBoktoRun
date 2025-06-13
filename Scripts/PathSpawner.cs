using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawner : MonoBehaviour
{
    [SerializeField]private List<GameObject> path = new List<GameObject>();
    [SerializeField]private GameObject spawnPoint;
    [SerializeField] private int nextIndex;
    [SerializeField] private BoktoBehaviour player;

    private GameObject runningPath;

    private void Start()
    {
        path[1].transform.position = spawnPoint.transform.position;
    }

    private void Update()
    {
        if(runningPath == player.currentPath)
        {
            return;
        }
        PathChanger();
    }
    public void PathChanger()
    {
        nextIndex = Random.Range(0, path.Count);
        path[nextIndex].transform.position = spawnPoint.transform.position;

        runningPath = player.currentPath;
        spawnPoint = path[nextIndex].transform.GetChild(2).gameObject;
    }
}
 

 

