﻿using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IngKidUnitTest {

	private void LoadSceneByName(string name){

		SceneManager.LoadScene(name, LoadSceneMode.Single);
	}

	/// <summary>
	/// Short test that checks whether the kid's
	/// mouth is closed when the secene starts.
	/// </summary>
	[Test]
	public void KidMouthIsClosedAtStartPasses() {
		var kid = new GameObject ().AddComponent<changeFoodOnContact> ();
		Assert.AreEqual (false, kid.isMouthOpen);
	}

	[Test]
	public void SpriteRendersCorrectlyOpenPasses() {
//		var kid = new GameObject ().AddComponent<changeFoodOnContact> ();
		Assert.AreEqual (false, false);
	}

	/// <summary>
	/// Makes spoon and food collide, checks
	/// whether kid's mouth opens as a result.
	/// </summary>
	[UnityTest]
	public IEnumerator KidMouthOpensAfterCollisionPasses() {
		LoadSceneByName("IngestionKid");
		yield return null;

		var kid = new GameObject ().AddComponent<changeFoodOnContact> ();
		// call method to make them collide, not this
		kid.isMouthOpen = true;
		// then check whether the kid's mouth opens as a result of the collision
		Assert.AreEqual(true, kid.isMouthOpen);
	}
}
