// looks for objects to fall through the ground and tracks the users score
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassCollision : MonoBehaviour {
    [HideInInspector] static public int score;

    private void Start()
    {
        score = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Floor" && collision.gameObject.tag != "Projectile")
        {
            Destroy(collision.gameObject); //remove the object that touched the ground
            score++;
        }
    }
}
