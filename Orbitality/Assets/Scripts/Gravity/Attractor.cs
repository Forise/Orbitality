using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour 
{
	public const float G = 66.74f;

	public static List<Attractor> Attractors;
	public bool attractable;
	public List<GameObject> exeptions;

	public Rigidbody2D rb;

	private void Update()
	{
		exeptions.RemoveAll(x => x == null);
	}

	private void FixedUpdate ()
	{
		foreach (Attractor attractor in Attractors)
		{
			if (attractor != this)
				Attract(attractor);
		}
	}

	private void OnEnable ()
	{
		if (Attractors == null)
			Attractors = new List<Attractor>();

		Attractors.Add(this);
	}

	private void OnDisable ()
	{
		Attractors.Remove(this);
	}

	protected virtual void Attract (Attractor objToAttract)
	{
		if (objToAttract.attractable && exeptions.Contains(objToAttract.gameObject) == false)
		{
			Rigidbody2D rbToAttract = objToAttract.rb;

			Vector3 direction = rb.position - rbToAttract.position;
			float distance = direction.magnitude * TimeScale.gameSclae;

			if (distance == 0f)
				return;

			float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2) * TimeScale.gameSclae;
			Vector3 force = direction.normalized * forceMagnitude * TimeScale.gameSclae;

			rbToAttract.AddForce(force * TimeScale.gameSclae);
		}
	}
}