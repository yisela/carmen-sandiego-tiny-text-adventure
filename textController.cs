using UnityEngine;
using UnityEngine.UI; //add unity engine UI to make text work
using System.Collections;

public class TextController : MonoBehaviour {
	
	// make new variable available to all methods
	public Text text; 
	
	// enumerate stes#
	private enum States {bedroom_0, table_0, bathroom_0, living_0, wardrove_0, street_0, airport_0, police_0, acme_0, living_1, bedroom_1, street_1, sign_0, sign_1, guard_0, car_0, house_0, end, badend}; 
	private States myState; 
	
	// Use this for initialization
	void Start () {
		myState = States.bedroom_0; 
	}
	
	// Update is called once per frame
	void Update () {	
		print (myState);
		if 		(myState == States.bedroom_0) 			{bedroom_0();} 
		else if (myState == States.table_0) 			{table_0();} 
		else if (myState == States.bathroom_0) 			{bathroom_0();} 
		else if (myState == States.living_0) 			{living_0();} 
		else if (myState == States.wardrove_0) 			{wardrove_0();}
		else if (myState == States.street_0) 			{street_0();}
		
		else if (myState == States.airport_0) 			{airport_0();}
		else if (myState == States.police_0) 			{police_0();}
		else if (myState == States.acme_0) 				{acme_0();}
		
		else if (myState == States.living_1) 			{living_1();}
		else if (myState == States.bedroom_1) 			{bedroom_1();}
		
		else if (myState == States.sign_0) 				{sign_0();}
		else if (myState == States.sign_1) 				{sign_1();}
		else if (myState == States.guard_0) 			{guard_0();}
		else if (myState == States.car_0) 				{car_0();}
		
		else if (myState == States.house_0) 			{house_0();}
		
		else if (myState == States.badend) 				{badend();}
		else if (myState == States.end) 				{end();}
		
	}
	
	// START: BEDROOM
	void bedroom_0 () {
		text.text = "You wake up to find your life-long partner Carmen gone. She was there when " + 
					"you both went to sleep, but now her side of the bed is undone and the house is silent. " +
					"You call for her twice, but there's no response. Not again, you almost say out loud. \n\n" +
					"Press T to inspect her bedside table, W to open her wardrove, B to check the bathroom " +
					"or L to leave the bedroom and go into the living-room.";			
		if 		(Input.GetKeyDown(KeyCode.T)) 		{myState = States.table_0;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bathroom_0;}
		else if (Input.GetKeyDown(KeyCode.W)) 		{myState = States.wardrove_0;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.living_0;}
	}
	
	// BEDSIDE TABLE
	void table_0 () {
		text.text = "You open the top drawer of the bedside table. Inside, there's only a bundle of " + 
					"old postcards tied with a string. Budapest, Moscow, Paris, Reykjavik... " +
					"places you had both seen, Carmen on the run, you chasing her. \n\n" +
					"Press R to Return to inspecting the bedroom";		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.bedroom_0;}
	}
	
	// WARDROVE
	void wardrove_0 () {
		text.text = "You walks towards the wardrove but need not touching it. " + 
					"Through the ajar door, you see Carmen's red dresses hanging perfectly aligned. " +
					"Her hat is obviously gone. \n\n" + 
					"Press R to Return to inspecting the bedroom.";		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.bedroom_0;}
	}
	
	// BATHROOM
	void bathroom_0 () {
		text.text = "The bathroom looks undisturbed, yet something feels out of place. " +
		 			"You try to push your thoughts away, Carmen wouldn't leave again. " + 
					"You open the bathroom cabinet and, as expected, your herat sinks. Her brown gloves are gone. \n\n" + 
					"Press R to Return to the bedroom";		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.bedroom_0;}
	}

	
	// LIVING 0
	void living_0 () {
		text.text = "The photos on the walls are a heavy reminder of Carmen's proclivity for adventure. " + 
					"You had long suspected a new one in the making, but failed to anticipate its timing. \n\n" + 
					"Press R to Return to the bedroom, or L to leave the house.";		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.bedroom_0;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.street_0;}
	}
	
	// STREET
	void street_0 () {
		text.text = "You step out of the house and into your awfully quiet suburban street. " + 
					"At least she didn't take the car, you think to yourself. " + 
					"You can think of three places to start searching for your beloved spy. \n\n" + 
					"Press A to travel to the airport, P to go to the police, A to visit the ACME Detective Agency " +
					"or R to Return inside the house.";
		if (Input.GetKeyDown(KeyCode.A)) 			{myState = States.airport_0;}
		else if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.police_0;}
		else if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.acme_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.living_1;}
	}
	
	// LIVING 1 (returning)
	void living_1 () {
		text.text = "Nothing has changed inside the house, Carmen is still gone and " + 
					"you have no clue where or why she's run off. \n\n" + 
					"Press R to Return to the bedroom, or C to get inside your car again.";		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.bedroom_1;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.car_0;}
	}
	
	// BEDROOM 1 (returning)
	void bedroom_1 () {
		text.text = "You are back in the bedroom. \n\n" +
					"Press T to inspect Carmen's bedside table, W to open her wardrove, B to check the bathroom " +
					"or L to leave the bedroom and go into the living-room.";			
		if 		(Input.GetKeyDown(KeyCode.T)) 		{myState = States.table_0;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.bathroom_0;}
		else if (Input.GetKeyDown(KeyCode.W)) 		{myState = States.wardrove_0;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.living_0;}
	}
	
	// STREET 1 (returning)
	void street_1 () {
		text.text = "Where shall we head first? You ask yourself and this time cannot hold a tiny smile. \n\n" + 
					"Press A to travel to the Airport, P to go to the police, D to visit the ACME Detective Agency " +
					"or R to Return to the house, again.";
		if (Input.GetKeyDown(KeyCode.A)) 			{myState = States.airport_0;}
		else if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.police_0;}
		else if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.acme_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.living_1;}
	}
	
	// ACME 
	void acme_0 () {
		text.text = "The former Agency is now a laundry service. The Chief is fighting over small change. " +
					"What do you want? He asks, as you reply that you are looking for Carmen." +
					"His belly shakes as he laughs, walking away from you.\n\n" + 
					"Press R to Return to your car.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.car_0;}
	}
	
	// POLICE 
	void police_0 () {
		text.text = "Three policemen in uniform see you approaching and stand in front of the door, arms crossed. " +
					"Go away! says the talest one. You never needed us before, you don't need us now.\n\n" +
					"Press R to Return to your car.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.car_0;}
	}
	
	
	// AIRPORT 
	void airport_0 () {
		text.text = "Ah, the airport! How many days, months, spent looking at that departures sign " +
					"and jumping into planes with strange flags attached to them. \n\n" + 
					"Press S to check the departures sign, G to talk to a guard of R to Return to your car.";
		if (Input.GetKeyDown(KeyCode.S)) 			{myState = States.sign_0;}
		else if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.guard_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.car_0;}
	}
	
	// SIGN 
	void sign_0 () {
		text.text = "The destinations have changed, but the feeling remains. " +
					"A deadly mixture of fear and passion, an intensity that only Carmen can cause. " + 
					"It would be pointless to pick a city without more clues, but not impossible. \n\n" + 
					"Press P for Paris, M for Mexico City, R for Reykjavic, S for San Francisco, " +
					"B for Bangkok, K for Kigali or H to return to your house for once and all.";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.end;}
		
		else if (Input.GetKeyDown(KeyCode.H)) 		{myState = States.house_0;}
		
		else if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.badend;}
		else if (Input.GetKeyDown(KeyCode.M)) 		{myState = States.badend;}
		else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.badend;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.badend;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.badend;}
	}
	
	// GUARD 
	void guard_0 () {
		text.text = "You show the guard Carmen's photo. He stares at you for a bit, laughs and then says: " +
					"I saw the person you're looking for and she left in a plane with a " +
					"blue, white and red flag. Then, he turns aroudn and leaves, shaking his head. \n\n" + 
					"Press S to check the departures sign again, or R to Return to your car.";
		if (Input.GetKeyDown(KeyCode.S)) 			{myState = States.sign_1;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.car_0;}
	}
	
	// CAR_0 
	void car_0 () {
		text.text = "You are back in the car. Where to next? \n\n" +
					"Press P to go to the police, A to go back into the airport, " +
					"S to visit the ACME Detective Agency or R to Return to your house.";
		if (Input.GetKeyDown(KeyCode.P)) 			{myState = States.police_0;}
		else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.acme_0;}
		else if (Input.GetKeyDown(KeyCode.A)) 		{myState = States.airport_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.living_1;}
	}
	
	
	// SIGN 1 (return - pre final!)
	void sign_1 () {
		text.text = "And here we are again. The guard mentioned a red, blue and white flag. " +
					"This is it. Make your pick, you tell yourself. Pick Carmen, or not. \n\n" + 
					"Press P for Paris, M for Mexico City, R for Reykjavic, S for San Francisco, " +
					"B for Bangkok, K for Kigali or H to return to your house for once and all.";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.end;}
		
		else if (Input.GetKeyDown(KeyCode.H)) 		{myState = States.house_0;}
		
		else if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.badend;}
		else if (Input.GetKeyDown(KeyCode.M)) 		{myState = States.badend;}
		else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.badend;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.badend;}
		else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.badend;}
	}
	
	// REYKJAVIK (ending)
	void end () {
		text.text = "You got it, it gotta be Reykjavik, of course. You buy a ticket and are soon on your way " +
					"to adventure. You know that by the time you land Carmen will be long gone again, but " +
					"isn't that exactly what you wanted? The pursue, the chase, the certainty that " +
					"no matter how old you are, or how old Carmen is, there will always be a puzzle " +
					"you don't really EVER want to solve. THE END! \n\n" +
					"Press R to Restart";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.bedroom_0;}
	}
	
	// ALL OTHER ENDINGS (ending)
	void badend () {
		text.text = "After flying for hours, you spend most of the evening asking around " +
					"but it seems like you have picked the wrong departure. Don't worry! " +
					"It's not too late! \n\n" +
					"Press A to fly back to the airport.";
		if (Input.GetKeyDown(KeyCode.A)) 			{myState = States.sign_1;}
	}
	
	
	// HOUSE (alternative ending)
	void house_0 () {
		text.text = "You return to your house. Carmen has chosen to go, and you to let her. " + 
					"You have finally grown out of your late eighties obsession. " +
					"About time! You tell yourself. You lie on the queen size bed like a starfish. " +
					"What's that noise now, coming from the kitchen? Is she... is it... " +
					"Yes. The existential angst is now here to stay. \n\n" +
					"Enjoy growing up.";
	}
	
	
}

