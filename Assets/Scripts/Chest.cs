using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable {
	public Sprite emptyChest;
	public int pesosAmount = 5;

	protected override void OnCollect() {
		base.OnCollect();

		if (!collected) {
			collected = true;
			GetComponent<SpriteRenderer>().sprite = emptyChest;
			GameManager.instance.ShowText("+" + pesosAmount + " pesos!", 20, Color.yellow, transform.position, Vector3.up * 1, 0.50f);
		}
	}
}
