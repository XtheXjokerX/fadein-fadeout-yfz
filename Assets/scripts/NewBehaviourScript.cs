using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip level2Music;
    public Animator animator;
    public int scenetoload;

    // Update is called once per frame
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            FadeToLevel(1);
            source.clip = level2Music;
            source.Play();
    }
    public void FadeToLevel(int index)
    {
        animator.SetTrigger("FadeOut");
    }


    public void OnFadeComplete()
    {
        SceneManager.LoadScene(scenetoload);
        source.clip = level2Music;
        source.Play();
    }
}
