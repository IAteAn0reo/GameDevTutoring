using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add "using TMPro;" at the beginning of every script that will 
using TMPro;

public class Game : MonoBehaviour
{
    //Everything that you code must be in here

    //If you have any questions, lmk in the discord

    //For now until Mr. Crawford shows us how to do nested variables, create every variable inside of the class
    //but dont put any inside any function. Just between them like in this area here.
    //ALWAYS END EVERY COMMAND WITH A SEMICOLON;

    //When creating a variable, there are three things you must add. Visibility, Type, and Name. For example:
    public int number;
    //Only include the Type before the name when you are first creating the variable, never anytime else.
    //The visibility can only be public, private, or [SerializeField].
    //Public means it will show up in unity and can be accessed by other scripts, but it takes up the most storage
    //Private means it only exists in this script and will not be accessible in unity
    //[SerializeField] means that it will show up in unity, but cannot be accessed by other scripts.

    //To access a text object from unity, do this:
    [SerializeField] TextMeshProUGUI testText;
    //We use [SerializeField] because we have no need to access this in another script, and it saves storage
    //TextMeshProUGUI is the Type we use for text objects
    //the name testText can be whatever you want it to be, so long as it isn't the same as another variable.

    //To make a button function, do this:
    public void Name()
    {
        //The name can be whatever you want it to be, but there can't be any spaces and it can't be the
        //same name as another function
        //Everything inside here is what will happen when you press the button in game

        //To change text to a number (using the number and testText variables made earlier), do this:
        testText.text = number.ToString();
        //The ".text" is necessary, always use it or else it won't work.
        //The ".ToString()" is also necessary, as you are converting a number to text which doesn't make sense
        //to unity, so this is the only way to set text to anything that is not text.

        //To change a number to a random number (using the number variable made earlier), do this:
        number = Random.Range(0, 1);
        //Make the number after the comma always 1 higher than what you are going for. So if you're making
        //something that is 1 through 6, you would do Random.Range(0, 7) since 7 is 1 higher than 6.

        //To change text to a sum of numbers (using the number and testText variables made earlier), do this:
        testText.text = (number + number).ToString();
        //Obviously you can replace the numbers with whatever numbers or variables you wanted them to be

        //To call the function from another function (Hint: For the button on the test that does all of the
        //dice and the sum button at once, call every other function inside of one new function), do this:
        Name();
        //Just the name of the function, two parentheses, and a semicolon.
    }
}
