using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class mypublicscript : MonoBehaviour
{

    public int wall;
    public int window;
    public int floor;
    public int door;
	
	public int costwall1;
	public int costwall2;
	public int costwall3;
	public int costwindow1;
	public int costwindow2;
	public int costwindow3;
	public int costdoor1;
	public int costdoor2;
	public int costdoor3;
	public int costfloor1;
		public int costfloor2;
		public int costfloor3;
		
		public int co2wall1;
	public int co2wall2;
	public int co2wall3;
	public int co2window1;
	public int co2window2;
	public int co2window3;
	public int co2door1;
	public int co2door2;
	public int co2door3;
	public int co2floor1;
		public int co2floor2;
		public int co2floor3;
	
	public GameObject Mainmodel;
	public GameObject MainForm0;
	public GameObject MainForm1;
	public GameObject MainForm2;
	public GameObject menu;
	public GameObject wall1;
	public GameObject wall2;
	public GameObject wall3;
	public GameObject window1;
	public GameObject window2;
	public GameObject window3;
	public GameObject floor1;
	public GameObject floor2;
	public GameObject floor3;
	public GameObject door1;
	public GameObject door2;
	public GameObject door3;
	public Material matwall1;
	 public Material matwall2;
	 public Material matwall3;
	 public Material matwindow1;
	 public Material matwindow2;
	 public Material matwindow3;
	 public Material matfloor1;
	 public Material matfloor2;
	 public Material matfloor3;
	 public Material matdoor1;
	 public Material matdoor2;
	 public Material matdoor3;
	 public  GameObject Mypublic;
	 
	 
	 public Text iwalls;
	 public Text iwindows;
	 public Text ifloors;
	 public Text idoors;
	 
	 //public InputField qname;
	 public Dropdown q1;
	 public InputField q2;
	 public Dropdown q3;
	 public Dropdown q4;
	 public Dropdown q5;
	 public Dropdown q6;
	 public Dropdown q7;
	 public Dropdown q81;
	 public Dropdown q82;
	 public Dropdown q83;
	 public Dropdown q84;
	 
	 
	 public Dropdown q9;
	 public Dropdown q10;
	 public Dropdown q11;
	 public Dropdown q12;
	 public Dropdown q13;
	 public Dropdown q14;
	 public Dropdown q15;
	 public Dropdown q16;
	 public Dropdown q17;
	 public Dropdown q18;
	 public Dropdown q19;
	 public InputField q20;
	 public Dropdown q21;
	 public InputField q22;
	 public InputField q23;
	 public InputField q24;
	
	 
	 
	
	
	

    // Start is called before the first frame update
    void Start()
    {
		Mypublic = GameObject.Find("mypublic");
		
		
		
        wall = 2;
        window = 2;
        floor = 2;
        door = 2;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void form2enable()
	{
		Mypublic.GetComponent<mypublicscript>().MainForm2.SetActive(true);
	}
	
	public void form0enable()
	{
		Mypublic.GetComponent<mypublicscript>().MainForm0.GetComponent<RectTransform>().anchoredPosition = new Vector2(10000, 10000f);;
	}
	
	
	
	public void Khashexit()
    {
        string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop); // the path of your project folder

            if (!System.IO.Directory.Exists(folderPath)) // if this path does not exist yet
                System.IO.Directory.CreateDirectory(folderPath);  // it will get created
            
            var screenshotName =
                                    "Screenshot_" +
                                    System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + // puts the current time right into the screenshot name
                                    ".png"; // put youre favorite data format here
            ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(folderPath, screenshotName),2); // takes the sceenshot, the "2" is for the scaled resolution, you can put this to 600 but it will take really long to scale the image up
            Debug.Log(folderPath + screenshotName); // You get instant feedback in the console
			
			Application.Quit();
			
    }
	
	
	public void Mahexit()
	{
		iwalls = GameObject.Find("iwalls").GetComponent<Text>();
		ifloors = GameObject.Find("ifloors").GetComponent<Text>();
		iwindows = GameObject.Find("iwindows").GetComponent<Text>();
		idoors = GameObject.Find("idoors").GetComponent<Text>();
		
		
		
		// qname= GameObject.Find("qname").GetComponent<InputField>();
		q1 = GameObject.Find("q1").GetComponent<Dropdown>();
		q2= GameObject.Find("q2").GetComponent<InputField>();
		q3 = GameObject.Find("q3").GetComponent<Dropdown>();
		q4 = GameObject.Find("q4").GetComponent<Dropdown>();
		q5 = GameObject.Find("q5").GetComponent<Dropdown>();
		q6 = GameObject.Find("q6").GetComponent<Dropdown>();
		q7 = GameObject.Find("q7").GetComponent<Dropdown>();
		q81 = GameObject.Find("q81").GetComponent<Dropdown>();
		q82 = GameObject.Find("q82").GetComponent<Dropdown>();
		q83 = GameObject.Find("q83").GetComponent<Dropdown>();
		q84 = GameObject.Find("q84").GetComponent<Dropdown>();
		
		q9 = GameObject.Find("q9").GetComponent<Dropdown>();
		q10 = GameObject.Find("q10").GetComponent<Dropdown>();
		q11 = GameObject.Find("q11").GetComponent<Dropdown>();
		q12 = GameObject.Find("q12").GetComponent<Dropdown>();
		q13 = GameObject.Find("q13").GetComponent<Dropdown>();
		q14 = GameObject.Find("q14").GetComponent<Dropdown>();
		q15= GameObject.Find("q15").GetComponent<Dropdown>();
		q16= GameObject.Find("q16").GetComponent<Dropdown>();
		q17= GameObject.Find("q17").GetComponent<Dropdown>();
		q18= GameObject.Find("q18").GetComponent<Dropdown>();
		q19= GameObject.Find("q19").GetComponent<Dropdown>();
		q20= GameObject.Find("q20").GetComponent<InputField>();
		q21= GameObject.Find("q21").GetComponent<Dropdown>();
		q22= GameObject.Find("q22").GetComponent<InputField>();
		q23= GameObject.Find("q23").GetComponent<InputField>();
		q24= GameObject.Find("q24").GetComponent<InputField>();
		
		// + "Name," + qname.text + ",\n" 
		
		string s = "Question,Answer,\n" + "Wall Type," + iwalls.text + ",\n" + "Window Type," + iwindows.text + ",\n" + "Floor Type," + ifloors.text + ",\n" +"Door Type," + idoors.text + ",\n" + "Please select your gender.," + q1.options[q1.value].text + ",\n" + "What is your age?," + q2.text + ",\n" + "Please select your current role as a stakeholder.," + q3.options[q3.value].text + ",\n" +"Please select the number of years of experience in the AEC industry.," + q4.options[q4.value].text + ",\n" + "Were you familiar with Virtual Reality (VR) prior to today's experiment?," + q5.options[q5.value].text + ",\n" + "Are you familiar with the concept of Circular Economy (CE) in general?," + q6.options[q6.value].text + ",\n" + "How familiar are you generally with Global warming and Carbon footprint?," + q7.options[q7.value].text + ",\n" + "Please rate the following according to their importance to you regarding building features using a scale from 1 to 5 (1 being the least important and 5 being the most important)., ,\n Economic Impact," + q81.options[q81.value].text + ",\n" + "Environmental impact," + q82.options[q82.value].text + ",\n" + "Social impact," + q83.options[q83.value].text + ",\n" + "Aesthetics," + q84.options[q84.value].text + ",\n" + "Did you find enough information about the different options of the material / product?," + q9.options[q9.value].text + ",\n" + "Are the presented metrics clear enough to help you on selecting the best material / product?," + q10.options[q10.value].text + ",\n" + "Were the visuals clear and immersive?," + q11.options[q11.value].text + ",\n" + "Did you encounter any bugs or visual/audio issues while using the VR system?," + q12.options[q12.value].text + ",\n" + "How easy was to install the app?," + q13.options[q13.value].text + ",\n" + "Were the controls and interactions intuitive and easy to use?," + q14.options[q14.value].text + ",\n" + "Were you able to navigate options easily within the VR environment?," + q15.options[q15.value].text + ",\n" + "How often do you think you would use this VR system?," + q16.options[q16.value].text + ",\n" + "Did you find the content relevant and valuable for its intended purpose?," + q17.options[q17.value].text + ",\n" + "Did the VR system meet your expectations or needs?," + q18.options[q18.value].text + ",\n" + "Did you feel immersed in the VR experience or did you find it distracting in any way?," + q19.options[q19.value].text + ",\n" + "Would you recommend this VR system to others and if so why?," + q20.text + ",\n" + "On a scale of 1 to 5 how would you rate your overall experience with the VR system?," + q21.options[q21.value].text + ",\n" + "What were the biggest challenges or issues you encountered while using the VR system?," + q22.text + ",\n" + "Is there anything specific you would like to see improved or added to enhance the VR experience?," + q23.text + ",\n" + "Do you have any additional comments or feedback about your experience with the VR system?," + q24.text + ",\n";
		
    
        System.IO.File.WriteAllText(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/Data_" + System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".csv", s);
		
	
	
	Application.Quit();
}
}
