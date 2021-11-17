using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionController : MonoBehaviour
{
    public Vector3 startLocation;
    public float startRotation;
    public Vector3 location1;
    public float rotation1;
    public Vector3 location2;
    public float rotation2;
    public Vector3 location3;
    public float rotation3;
    public Vector3 location4;
    public float rotation4;
    public Vector3 location5;
    public float rotation5;
    public GameObject interactionText;
    public AudioSource companionAudioSource;
    public AudioClip clip1;
    public int clip1Length;
    public AudioClip clip2;
    public int clip2Length;
    public AudioClip clip3;
    public int clip3Length;
    public AudioClip clip4;
    public int clip4Length;
    public AudioClip clip5;
    public int clip5Length;
    public AudioClip clip6;
    public int clip6Length;

    private bool canInteract;
    private bool isDipping;
    private Vector3[] locations;
    private float[] rotations;
    private AudioClip[] audioClips;
    private int[] audioClipLengths;
    private int locationNumber;

    // Start is called before the first frame update
    void Start()
    {
        canInteract = false;
        isDipping = false;
        interactionText.SetActive(false);
        locationNumber = 0;
        locations = new Vector3[6];
        rotations = new float[6];
        audioClips = new AudioClip[6];
        audioClipLengths = new int[6];
        audioClips[0] = clip1;
        audioClips[1] = clip2;
        audioClips[2] = clip3;
        audioClips[3] = clip4;
        audioClips[4] = clip5;
        audioClips[5] = clip6;
        audioClipLengths[0] = clip1Length;
        audioClipLengths[1] = clip2Length;
        audioClipLengths[2] = clip3Length;
        audioClipLengths[3] = clip4Length;
        audioClipLengths[4] = clip5Length;
        audioClipLengths[5] = clip6Length;
        locations[0] = startLocation;
        locations[1] = location1;
        locations[2] = location2;
        locations[3] = location3;
        locations[4] = location4;
        locations[5] = location5;
        rotations[0] = startRotation;
        rotations[1] = rotation1;
        rotations[2] = rotation2;
        rotations[3] = rotation3;
        rotations[4] = rotation4;
        rotations[5] = rotation5;
        transform.position = locations[0];
        transform.rotation.Set(0, rotations[0], 0, 0);
        StartCoroutine(playClip(audioClipLengths[locationNumber]));
    }

    // Update is called once per frame
    void Update()
    {
        if(isDipping == true)
        {
            transform.position = transform.position + transform.up * Time.deltaTime * 10;
            transform.Rotate(0, 1, 0);
        }

        if(Input.GetKeyDown(KeyCode.F) && canInteract)
        {
            StartCoroutine(playClip(audioClipLengths[locationNumber]));
        }

        if (canInteract == false)
        {
            interactionText.SetActive(false);
        }
    }

    private IEnumerator moveToNewSpot(Vector3 pos)
    {
        isDipping = true;
        yield return new WaitForSeconds(10);
        isDipping = false;
        transform.position = pos;
        transform.eulerAngles = new Vector3(0, rotations[locationNumber], 0);
        locationNumber++;
        canInteract = true;
    }

    private IEnumerator playClip(int clipLength)
    {
        AudioSource.PlayClipAtPoint(audioClips[locationNumber], this.transform.position);
        canInteract = false;
        yield return new WaitForSeconds(clipLength);
        if(locationNumber > 0)
        {
            StartCoroutine(moveToNewSpot(locations[locationNumber]));
        }
        else
        {
            locationNumber++;
            canInteract = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && canInteract)
        {
            interactionText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            interactionText.SetActive(false);
        }
    }
}

