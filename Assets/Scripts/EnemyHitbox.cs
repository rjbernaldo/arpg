using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable {
	public int damage = 1;
	public float pushForce = 5;

	protected override void OnCollide(Collider2D coll) {
		if (coll.tag == "Fighter" && coll.name == "Player") {
			Damage dmg = new Damage();
			dmg.damageAmount = damage;
			dmg.origin = transform.position;
			dmg.pushForce = pushForce;

			// Debug.Log(coll.name);
			coll.SendMessage("ReceiveDamage", dmg);
		}
	}
}
