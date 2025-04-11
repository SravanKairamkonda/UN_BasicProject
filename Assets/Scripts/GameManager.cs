using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
  

    private GameObject playerInstance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInstance=Instantiate(PlayerPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        /* Continuous Movement
        Vector3 moveForward = Vector3.forward * speed * Time.deltaTime;
        playerInstance.transform.position += moveForward;
         */

        
    }
}
