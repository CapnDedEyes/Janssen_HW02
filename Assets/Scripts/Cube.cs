using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] AudioClip[] booshSound;
    [SerializeField] AudioClip[] quackSound;
    [SerializeField] GameObject clone;
    [SerializeField] Transform spawn;

    public float baseSize = 1f;

    public void Boosh()
    {
        
        Debug.Log("BOOSH");
        int random = Random.Range(0, booshSound.Length);
        AudioHelper.PlayClip2D(booshSound[random], 1f);
        //DestroyImmediate(GetComponent<AudioClip>());

        Instantiate(clone, spawn.position, spawn.rotation);
    }

    public void Quack()
    {
        Debug.Log("Q u a c k");
        int random = Random.Range(0, quackSound.Length);
        AudioHelper.PlayClip2D(quackSound[random], 1f);
        //DestroyImmediate(GetComponent<AudioClip>());

        transform.localScale = Vector3.one * baseSize * Random.Range(0.1f, 2f);
    }

    public void DestroyClip()
    {
        DestroyImmediate(GetComponent<AudioClip>());
    }
}
