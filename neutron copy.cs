using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neutron : MonoBehaviour
{
    public GameObject neutronObj;
    private ParticleSystem partSys;
    public float timeGap;
    private GameObject clone;
    private float timer = 0.00f;
    public obstacles obstaclesScript;
    private float yPosition;
    public Transform spawnPoint;
    private Rigidbody2D rbClone;
    public float Speed;
    private int randomValue;
 

    private bool collided = false;
   

    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //segments[0] = new Vector3(neutronObj.transform.position.x - 2, neutronObj.transform.position.y);
        if (Time.time - timer > timeGap)
        {
            obstaclesScript.randomPosition();
            obstaclesScript.Spawn(neutronObj);
            
            partSys = neutronObj.GetComponent<ParticleSystem>();
            
            timer = Time.time;
        }

 
    }


}
