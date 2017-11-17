var AmmoSound : AudioSource;

function OnTriggerEnter(col : Collider) {
	AmmoSound.Play();
	if(GlobalAmmo.LoadedAmmo <= 0) {
		GlobalAmmo.LoadedAmmo += 30;
		this.gameObject.SetActive(false);
	}
	else {
		GlobalAmmo.CurrentAmmo += 30;
		this.gameObject.SetActive(false);
	}
}
