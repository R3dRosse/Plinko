using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSpawn : MonoBehaviour
{
    Vector3 randomPosition;
    public float xRange = 5f;
    public float yRange = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float yPosition = Random.Range(4.75f - yRange, 4.75f + yRange);
        randomPosition = new Vector3(xPosition, yPosition);
        transform.position = randomPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
}
