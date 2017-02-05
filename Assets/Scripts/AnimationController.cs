using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    Animator anim;

    [Header("Blink")]
    [SerializeField]
    private float minBlinkTime = 0.5f;
    [SerializeField]
    private float maxBlinkTime = 5f;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        Blink();
	}
	
	// Update is called once per frame
	//void Update () {
		//TODO: set correct animation state for what is happening
	//}

    /// <summary>
    /// Simple self calling class to make the character blink
    /// </summary>
    void Blink()
    {
        anim.SetTrigger("Blink");
        float rndTime = Random.Range(minBlinkTime, maxBlinkTime);
        Invoke("Blink", rndTime);
    }
}
