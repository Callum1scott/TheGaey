using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMAnager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip SlamIntro;
    public AudioClip WallGrabIntro;
    public AudioClip DashRecallIntro;
    public AudioClip DashIntro;
    public AudioClip DoubleJumpIntro;
    public AudioClip WallRunIntro;
    public AudioClip JumpDashIntro;
    public AudioClip ExtendedDashIntro;
    public AudioClip PlainSightIntro;
    public AudioClip HoverIntro;
    public AudioClip BucketRelicIntro;
    public AudioClip FlowerRelicIntro;
    public AudioClip CrystalRelicIntro;
    public AudioClip TorchRelicIntro;

    public AudioSource Player;

    public GameObject bucketIcon;
    public GameObject flowerIcon;
    public GameObject crystalIcon;
    public GameObject torchIcon;

    public int relicCount;

    public void Start()
    {
        relicCount = 0;
        bucketIcon.SetActive(false);
        flowerIcon.SetActive(false);
        crystalIcon.SetActive(false);
        torchIcon.SetActive(false);
    }

    public int getRelicCount()
    {
        return relicCount;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SlamIntro")
        {
            Player.clip = SlamIntro;
            Player.Play();
        }
        if (other.gameObject.name == "WallGrabIntro")
        {
            Player.clip = WallGrabIntro;
            Player.Play();
        }
        if (other.gameObject.name == "DashIntro")
        {
            Player.clip = DashIntro;
            Player.Play();
        }
        if (other.gameObject.name == "DoubleJumpIntro")
        {
            Player.clip = DoubleJumpIntro;
            Player.Play();
        }
        if (other.gameObject.name == "WallRunIntro")
        {
            Player.clip = WallRunIntro;
            Player.Play();
        }
        if (other.gameObject.name == "JumpDashIntro")
        {
            Player.clip = JumpDashIntro;
            Player.Play();
        }
        if (other.gameObject.name == "ExtendedDashIntro")
        {
            Player.clip = ExtendedDashIntro;
            Player.Play();
        }
        if (other.gameObject.name == "DashRecallIntro")
        {
            Player.clip = DashRecallIntro;
            Player.Play();
        }
        if (other.gameObject.name == "PlainSightIntro")
        {
            Player.clip = PlainSightIntro;
            Player.Play();
        }
        if (other.gameObject.name == "HoverIntro")
        {
            Player.clip = HoverIntro;
            Player.Play();
        }
        if (other.gameObject.name == "TheBucket")
        {
            Player.clip = BucketRelicIntro;
            Player.Play();
            bucketIcon.SetActive(true);
            other.gameObject.SetActive(false);
            relicCount++;
        }
        if (other.gameObject.name == "TheFlower")
        {
            Player.clip = FlowerRelicIntro;
            Player.Play();
            flowerIcon.SetActive(true);
            other.gameObject.SetActive(false);
            relicCount++;
        }
        if (other.gameObject.name == "TheCrystal")
        {
            Player.clip = CrystalRelicIntro;
            Player.Play();
            crystalIcon.SetActive(true);
            other.gameObject.SetActive(false);
            relicCount++;
        }
        if (other.gameObject.name == "TheTorch")
        {
            Player.clip = TorchRelicIntro;
            Player.Play();
            torchIcon.SetActive(true);
            other.gameObject.SetActive(false);
            relicCount++;
        }
    }
}

