This is the code challenge for Iron software.	
For most of the numbers on a numpad, the first character on that number can be identified by logic number multiplied by three and then three subracted from it since that that's the number of characters on each number. Only for 7 and 9, its different since they contain four characters each.
Created a constant stiring having all the characters that are on the numpad to enumerate on.
In the OldPhonePad method, a for loop is run on the input characters.
I check for the special characters, and if the current character is not a special character i.e. space, asterisk or space, assign that character to a int value. Then get the next character. Based on the current number a character is obtained from the constant string.
If the next character is a special character, then we have to do accordingly. A space means appending the current character to the string builder. An asterisk means, skipping this character. While the pound sign means appending whatever is currently there in the stored character and endign the foreach loop.
If the next character is none of the above, then convert that character to an int and comapre it with the first integer value, currentNumber.
If they are same, move the counter to point to the next character on that number pad.
If its different, append that character to the string.
Once the for loop runs for whole length of the input string, a pound sign is found and the loop exits.

A running version of the code can be found here. https://www.programiz.com/online-compiler/1EGjvsPXLkYmE
