using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pickup-derived component which addes to the player's score when collected
/// </summary>
public class WingPickup : Pickup
{
    /// <summary>
    /// Description:
    /// When picked up, adds to the player's score
    /// Input:
    /// Collider2D collision
    /// Returns:
    /// void (no return)
    /// </summary>
    /// <param name="collision">The collision that touched the pickup</param>
    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.CompareTag("Player") && collision.gameObject.GetComponent<Health>() != null)
        {
            // Flip gravity
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            // Flip player
            collision.gameObject.transform.Rotate(180f, 0, 0);
        }
        base.DoOnPickup(collision);
    }
}
