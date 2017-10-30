using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class Chase : MonoBehaviour {

	public GameObject target;
	private NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent>();
		target = GameObject.Find ("Tank");
	}

	void Update () {
		if(agent.pathStatus != NavMeshPathStatus.PathInvalid) {
			agent.destination = target.transform.position;
		}
	}
}

