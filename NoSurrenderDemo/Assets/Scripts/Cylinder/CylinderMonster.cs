using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class CylinderMonster : MonoBehaviour
{

    [SerializeField] NavMeshAgent agent;
    [SerializeField] CylinderUI _UI;
    [SerializeField] GameObject Player;

    private int health;

    public int Health { get => health; set => health = value; }

    private void Update()
    {
        Chase(Player.transform.position);
    }

    private void OnParticleCollision(GameObject other)
    {
        Damage();
    }
    public void Damage()
    {
        health--;

        if (health == 0)
        {
        KillCylinder();
        }

    }

    public void Chase(Vector3 chaseObject)
    {
        agent.SetDestination(chaseObject);
    }

    public void MetamorphCylinder()
    {
    }

    public void StunCylinder()
    {
    }

    private void KillCylinder()
    {
        Destroy(this.gameObject);
        Aim.TargetList.Remove(Aim.TargetList.First().Key);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == Player)
        {
            Debug.Log("hit!!" + "res");

            LevelManager.levelManager.GameOver();
        }
    }


}
