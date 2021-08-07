using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpet : MonoBehaviour
{
    [SerializeField]Collider capsuleCol,carpetBoxCol ;
    Animator animator;
    Baby baby;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void UseCarpet()
    {
        Debug.Log("used");
        gameObject.transform.parent = null;
        gameObject.transform.position = baby.carpetOpenPos.transform.position;
        carpetBoxCol.enabled = true;
        animator.SetTrigger("Use");

    }
    private void CarpetCatched(Collider other)
    {
        other.TryGetComponent<Baby>(out Baby _baby);

        baby = _baby;
        capsuleCol.enabled = false;

        animator.SetTrigger("Catch");

        gameObject.transform.parent = baby.Backpack.transform;

    }
    private void OnTriggerEnter(Collider other)
    {
        CarpetCatched(other);
    }

}
