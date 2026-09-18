using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public AudioSource MusicSource;
    [SerializeField] public AudioSource SfxSource;

    public AudioClip background;

    public AudioClip humanHurt;
    public AudioClip humanDeath1;
    public AudioClip humanDeath2;
    public AudioClip humanDeath3;

    public AudioClip attackBat;
    public AudioClip attackShotgun;
    public AudioClip attackRifle;
    public AudioClip attackSkeleton1;
    public AudioClip attackSkeleton2;
    public AudioClip attackSkeleton3;
    public AudioClip attackSkeletonArrow;

    public AudioClip coinCollect;
    public AudioClip levelUp;
    public AudioClip uiFail;
    public AudioClip uiHover;
    public AudioClip uiSelect;
    public AudioClip upgrade;
    public AudioClip victory;

    public AudioClip standin;
    





    private void Start()
    {
        MusicSource.clip = background;
        MusicSource.Play();
    }

    public void PlaySfx(AudioClip clip)
    {
        SfxSource.PlayOneShot(clip);
    }
}