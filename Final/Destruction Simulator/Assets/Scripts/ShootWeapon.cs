// checks for mouse button input and fires or switches between projectiles
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour {

    public float fireSpeed;
    public GameObject[] projectiles = new GameObject[1];
    int curProjectile;

	void Update () {
        if (Input.GetMouseButtonDown(1)) // if right mouse button is clicked switch the loaded projectile
        {
            // cycle to the next prjectile
            if (curProjectile == projectiles.Length - 1)
                curProjectile = 0;
            else
                curProjectile++;
        }
        if (Input.GetMouseButtonDown(0)) // if left mouse button is clicked fire a projectile
        {
            GameObject newProjectile = Instantiate(projectiles[curProjectile], transform.position, Quaternion.identity);
            newProjectile.GetComponent<Rigidbody>().velocity = transform.forward * fireSpeed; //fire in the direcction the camera is looking
        }
	}
}
