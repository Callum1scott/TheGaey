using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companion : MonoBehaviour
{
    public AudioClip clip;
    public int clipLength;
    private AudioSource companionAS;
    private bool clipPlayed;
    private GameObject player;
    public GameObject body;
    private PlayerController playerCon;

    // Start is called before the first frame update
    void Start()
    {
        playerCon = FindObjectOfType<PlayerController>();
        companionAS = this.GetComponent<AudioSource>();
        companionAS.clip = clip;
        clipPlayed = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        body.transform.LookAt(player.transform);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && !clipPlayed)
        {
            clipPlayed = true;
            companionAS.Play();
            StartCoroutine(InputControl());
        }
    }

    public IEnumerator InputControl()
    {
        playerCon.setCanInput(false);
        playerCon.setBatteryHolder(playerCon.getBatteryLife());
        yield return new WaitForSeconds(clipLength);
        playerCon.setCanInput(true);
    }
}
