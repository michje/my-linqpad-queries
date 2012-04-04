<Query Kind="Statements" />

string encodedText = "";


byte [] decodedBytes = Convert.FromBase64String (encodedText);
string decodedText = Encoding.UTF8.GetString (decodedBytes);
Console.Out.WriteLine ("Decoded text: {0}", decodedText);

