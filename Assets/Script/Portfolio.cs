using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Portfolio : MonoBehaviour
{
    // [SerializeField] private Button Linkedin_BTN, Github_BTN, Insta_BTN, X_BTN, Gmail_BTN;
    [SerializeField] private GameObject Home_Panel, About_Panel /*, Resume_Panel, Project_Panel, Contact_Panel*/;
    private string emailAddress = "agrawalricha013@gmail.com";
    private void Start()
    {
        About_Panel.gameObject.SetActive(false);
        Home_Panel.gameObject.SetActive(true);
        // Resume_Panel.gameObject.SetActive(false);
        // Project_Panel.gameObject.SetActive(false);
        // Contact_Panel.gameObject.SetActive(false);
    }
    public void OnClickLinkedin_BTN()
    {
        Application.OpenURL("https://www.linkedin.com/in/ag-richa-13s/");
    }
    public void OnClickGithub_BTN()
    {
        Application.OpenURL("https://github.com/ag-richa-13");
    }
    public void OnClickInstagram()
    {
        Application.OpenURL("https://www.instagram.com/r.i._c_.h.a/");
    }
    public void OnClickX()
    {
        Application.OpenURL("https://x.com/IMRichaAgrawal");
    }


    // Button click event handler
    public void OnEmailButtonClick()
    {
        // `mailto:` URL create karna
        string mailtoUrl = "mailto:" + emailAddress;

        // Email client ko open karna
        Application.OpenURL(mailtoUrl);
    }

    public void OnClickAbout()
    {
        About_Panel.gameObject.SetActive(true);
        Home_Panel.gameObject.SetActive(false);
        // Resume_Panel.gameObject.SetActive(false);
        // Project_Panel.gameObject.SetActive(false);
        // Contact_Panel.gameObject.SetActive(false);
    }
}
