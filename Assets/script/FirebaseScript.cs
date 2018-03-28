using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using UnityEngine.SceneManagement;

public class FirebaseScript : MonoBehaviour {
	public InputField Emailid, Password;

	public void LoginButtonPressed(){
		FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync (Emailid.text, Password.text).
		ContinueWith ((obj) => {
			SceneManager.LoadSceneAsync ("New Scene");
		});
	}
/*
	public void LoginButtonPressed(){
		FirebaseAuth.DefaultInstance.SignInWithCredentialAsync (Emailid.text, Password.text).
		ContinueWith ((obj) => {
			SceneManager.LoadSceneAsync ("New Scene");
		});
	}*/
	public void SignupButtonPressed(){
		FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync (Emailid.text, Password.text).
		ContinueWith ((obj) => {
			SceneManager.LoadSceneAsync ("New Scene");
		});
	}


	}
