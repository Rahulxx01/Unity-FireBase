using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour {
	public GameObject firstname;
	public GameObject lastname;
	public GameObject username;
	public GameObject email;
	public GameObject password;
	public GameObject confPasword;

	private string Firstname;
	private string Lastname;
	private string Username;
	private string Email;
	private string Password;
	private string ConfPassword;
	private string form;
	private bool EmailValid = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Firstname = firstname.GetComponent<InputField> ().text;
		Lastname = lastname.GetComponent<InputField> ().text;
		Username = username.GetComponent<InputField> ().text;
		Email = email.GetComponent<InputField> ().text;
		Password = password.GetComponent<InputField> ().text;
		//Confpassword = confPassword.GetComponent<InputField> ().text;
	}
}