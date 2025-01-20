This is the code challenge for Iron software.  
The first character for a number can be identified by multiplying that number by three and then three subracted from it since that that's the number of characters on each number. Only for 7 and 9, its different since they contain four characters each.  
A foreach loop is used to read each character from the input string.  
For each number, if its same as previous number, then the pointer is incremented otherwise, the current character corresponding to the current number is appended to the string bulilder.  
If the cuurent character is a special character, then a space means appending the current character to the string builder. An asterisk means, skipping this character. While the pound sign means appending whatever is currently there in the stored character and endign the foreach loop.  

**A running version of the code can be found here.** [dotnetfiddle link](https://dotnetfiddle.net/0347OX)
