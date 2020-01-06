using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : MonoBehaviour
{
    public float playerRange;
    public GameObject eyebeam;
    public TopDownCharacterController2D Player;
    public Transform firepoint;
    public float waitbetweenbeams;
    private float beamcounter;




    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<TopDownCharacterController2D>();
        beamcounter = waitbetweenbeams;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));
        beamcounter -= Time.deltaTime;

        if (transform.localScale.x > 0 && Player.transform.position.x > transform.position.x && Player.transform.position.x < transform.position.x + playerRange && beamcounter < 0)
        {
            Instantiate(eyebeam, firepoint.position, firepoint.rotation);
            beamcounter = waitbetweenbeams;
        }

        if (transform.localScale.x > 0 && Player.transform.position.x < transform.position.x && Player.transform.position.x > transform.position.x - playerRange && beamcounter < 0)
        {
            Instantiate(eyebeam, firepoint.position, firepoint.rotation);
            beamcounter = waitbetweenbeams;
        }
    }
}
