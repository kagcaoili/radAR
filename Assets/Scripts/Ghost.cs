using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {

    private Vector3 playerPosition;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float minDistance;

	// Use this for initialization
	void Start () {
        playerPosition = Camera.main.transform.position;
    }
	
    private void FloatToUser()
    {
        playerPosition = Camera.main.transform.position;
        float distance = Vector3.Distance(transform.position, playerPosition);

        Debug.Log("Distance: " + distance);
        if (distance > minDistance)
        {
            Debug.Log("Fly to user");
            Vector3 direction = playerPosition - transform.position;
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }
    }

	// Update is called once per frame
	void Update () {
        FloatToUser();
	}
}
