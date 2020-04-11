using UnityEngine;

public class RocketAttractor : Attractor
{
	protected override void Attract(Attractor objToAttract)
	{
		if (objToAttract.attractable && (objToAttract is RocketAttractor) == false)
		{
			Rigidbody2D rbToAttract = objToAttract.rb;

			Vector3 direction = rb.position - rbToAttract.position;
			float distance = direction.magnitude;

			if (distance == 0f)
				return;

			float forceMagnitude = (G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2)) * TimeScale.gameSclae;
			Vector3 force = direction.normalized * forceMagnitude * TimeScale.gameSclae;

			rbToAttract.AddForce(force * TimeScale.gameSclae);
		}
	}
}
