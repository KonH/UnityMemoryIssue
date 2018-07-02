using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour {
	static int Iters = 0;
	
	public GameObject Prefab;
	
	int PackSize = 1000;
	int Packs = 30;

	int _packs = 0;

	void Start() {
		System.GC.Collect();
		Resources.UnloadUnusedAssets();
		Debug.LogFormat("Iters: {0}", Iters);
	}

	void Update() {
		for (var i = 0; i < PackSize; i++ ) {
			Instantiate(Prefab);
		}
		_packs++;
		if ( _packs > Packs ) {
			GoToNext();
		}
	}
	
	void GoToNext() {
		Iters++;
		var scene = SceneManager.GetActiveScene();
		var nextIndex = scene.buildIndex == 0 ? 1 : 0;
		SceneManager.LoadScene(nextIndex);
	}
}
