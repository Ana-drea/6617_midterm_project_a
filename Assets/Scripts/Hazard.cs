using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public AudioSource loseAudio;
    // Hazard Script
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            // Play the audio for losing the game
            if (loseAudio != null && !loseAudio.isPlaying)
            {
                loseAudio.Play();
            }

            Player player = other.GetComponent<Player>();
            if (player != null)
                player.Die();
        }
    }



}
