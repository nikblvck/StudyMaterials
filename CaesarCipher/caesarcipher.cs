using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      //Ask the user for a secret message and store the result in a variable;
      Console.WriteLine("Enter a secret message: ");
     //Convert the captured string to an array of characters - store the result in a new variable called secretMessage
     string secretMessageString = Console.ReadLine();
     char[] secretMessage = secretMessageString.ToCharArray();
     //Create a new empty array of characters to hold the encrypted message
     //Should be named encryptedMessage and have length equal to the length of secretMessage
      char[] encryptedMessage = new char[secretMessage.Length];
      //Loop through the secretMessage array
      for (int i = 0; i < secretMessage.Length; i++)
      {
        //access the character at position i and store it in a variable
        char currentCharacter = secretMessage[i];
        //Find the index of the current character in the alphabet array
        int currentCharacterIndex = Array.IndexOf(alphabet, currentCharacter);
        //Add 3 to the currentCharacterIndex
        int newCharacterIndex = (currentCharacterIndex + 3) % 26;
        //Use the newCharacterIndex to access the character at that index in the alphabet array
        char newCharacter = alphabet[newCharacterIndex];
        //Store the new character in the encryptedMessage array
        encryptedMessage[i] = newCharacter;




      }
      //Print the encryptedMessage array
      Console.WriteLine(String.Join("", encryptedMessage));

    }
  }
}
`
