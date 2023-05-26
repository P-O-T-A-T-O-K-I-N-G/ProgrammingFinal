using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Final Exam #3
 * 
 *  Make this script inherit the PickUp Class.
 * Attach this script to the yellow arrow that is on the track
 * Override the Activate() method to:
 *      - Save the original speed of the player
 *      - increase the speed of the car to 5
 *      - Wait for 2 seconds (Write a coroutine)
 *      - Change the speed back to the originalSpeed
 * 
 */
public class SpeedPickup : PickUp
{
    public float originalSpeed = 3f;

    public float boostedSpeed = 20f;

    public Rigidbody2D rb;

    public SpriteRenderer sr;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        sr = GetComponent<SpriteRenderer>();
    }

    public override void Activate()
    {
        MakeThisPickupInvisible();

    }

    private IEnumerator Speeeed()
    {
        originalSpeed = boostedSpeed;

        yield return new WaitForSeconds(2);
        
        DelayedDestroy();
    }
}
