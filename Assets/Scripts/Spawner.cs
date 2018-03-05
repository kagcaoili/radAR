using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public enum Mode
    {
        Easy,
        Hard
    };


    public GameObject[] easyGhosts;

    public GameObject[] hardGhosts;

    private GameObject[] ghosts;

    [SerializeField]
    private int maxGhosts;

    [SerializeField]
    private Mode mode;

    private int numberOfExistingGhosts;

	// Use this for initialization
	void Start () {
        if (mode == Mode.Easy)
        {
            ghosts = easyGhosts;
        } else
        {
            ghosts = hardGhosts;
        }


        numberOfExistingGhosts = 0;
        SpawnGhosts(maxGhosts);
	}

    private void SpawnGhosts(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int index = Random.Range(0, ghosts.Length);
            Instantiate(ghosts[index], Vector3.zero, Quaternion.identity);
            numberOfExistingGhosts++;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
