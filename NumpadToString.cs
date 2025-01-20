using System;
using System.Text;

public class NumpadToString
{
    const string numpadAlphabets = "&'(abcdefghijklmnopqrstuvwxyz";
    
    //Returns the position of the first character corresponding to this number.
    private static int GetCorrespondingCharPointer(int number)
    {
        if(number > 7)
        {
            return  (number * 3) - 2;
        }
        else
        {
            return (number * 3) - 3;
        }
    }
    
    //Returns a string for the numpad characters provided by the user.
    public static String OldPhonePad(string inputString) 
    {
        char[] numpadCharacters = numpadAlphabets.ToCharArray();
        int previousNumber = default ,stringPointer = default, currentNumber;
        StringBuilder sb = new StringBuilder();
        
        foreach(char i in inputString.ToCharArray())
        {
            if(int.TryParse(i.ToString(),out currentNumber))
            {
                if(currentNumber == previousNumber)
                {
                    stringPointer++;
                }
                else
                {
                    if(previousNumber > 0)
                    {
                        sb.Append(numpadCharacters[stringPointer]);
                    }
                    stringPointer = GetCorrespondingCharPointer(currentNumber);
                    previousNumber = currentNumber;
                }
            }
            else
            {
                if(i == ' ')
                {
                    sb.Append(numpadCharacters[stringPointer]);
                    previousNumber = 0;
                }
                else if(i == '#' && previousNumber > 0)
                {
                    sb.Append(numpadCharacters[stringPointer]);
                }
                else if(i == '*')
                {
                    previousNumber = 0;
                }
            }
        }
        
        return sb.ToString().ToUpper();
    }
}
