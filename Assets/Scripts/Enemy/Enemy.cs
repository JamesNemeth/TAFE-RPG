using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum AIState
    {
        Patrol,
        Seek,
        Attack,
        Die
    }
    [Header("Base Stats")]
    public AIState state;
    public float curHealth, maxHealth, moveSpeed, attackRange, attackSpeed, sightRange, baseDamage;
    public int curWaypoint, difficulty;
    public bool isDead;

    [Header("Base References")]
    public GameObject self;
    public Transform player;
    public Transform waypointParent;
    protected Transform[] waypoints;
    public NavMeshAgent agent;
    public GameObject healthCanvas;
    public Image healthBar;
    public Animator anim;

    private void Start()
    {
        waypoints = waypointParent.GetComponentsInChildren<Transform>();
        agent = self.GetComponent<NavMeshAgent>();
        curWaypoint = 1;
        agent.speed = moveSpeed;
        anim = self.GetComponent<Animator>();
        healthCanvas = self.GetComponent<Wolf>().healthCanvas;
        healthBar = self.GetComponent<Wolf>().healthBar;
        Patrol();
    }
    public void Update()
    {
        anim.SetBool("Walk", false);
        anim.SetBool("Run", false);
        anim.SetBool("Attack", false);
      


        Patrol();
        Seek();
        Attack();
        Die();
    }
    public void Patrol()
    {
     
        if (waypoints.Length == 0 || Vector3.Distance(player.position,self.transform.position) <= sightRange || curHealth < 0)
        {
            return;
        }
        anim.SetBool("Walk", true);
        state = AIState.Patrol;
        //Do Not Continue If No Waypoints
        //follow waypoints
        //Set agent to target
        agent.destination = waypoints[curWaypoint].position;
        //are we at the waypoint
        if (self.transform.position.x.Equals(agent.destination.x) && self.transform.position.z == agent.destination.z)
        {
            if(curWaypoint < waypoints.Length - 1)
            {
                curWaypoint++;
            }
            else
            {
                //if at end of patrol go to start
                curWaypoint = 1;
            }
        }
        //if so go to next waypoint
    }
    public void Seek()
    {
        //if the player is out of our sight range or inside our attack range
        if (Vector3.Distance(player.position, self.transform.position) > sightRange || Vector3.Distance(player.position, self.transform.position) < attackRange || curHealth < 0)
        {
            //stop seeking
            return;
        }
        anim.SetBool("Run", true);
        state = AIState.Seek;
        //if player in sight range and not attack range the chase
        agent.destination = player.position;
    } 
    public virtual void Attack()
    {
        if (Vector3.Distance(player.position, self.transform.position) > attackRange || curHealth < 0)
        {
            return;
        }
        anim.SetBool("Attack", true);
        state = AIState.Attack;
        Debug.Log("Attack");
        //if player in attack range attack
    }
    public void Die()
    {
        //if health is <= 0 die
        if (curHealth > 0)
        {
            return;
        }
        //else we are dead, rum this
        state = AIState.Die;
        if (!isDead)
        anim.SetTrigger("Die");
        isDead = true;
        agent.destination = self.transform.position;
        //DropLoot
    }
}
