using System.Diagnostics.Tracing;
//string hello = "hello, world! Here i am!";
string hello = " we are the champions?";
int stringLength = hello.Length;
//string trimmedString = hello.Trim();

hello= hello.Trim();    

//Console.WriteLine(trimmedString.Length); //see 4 rea jaoks.

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace("?", "!");

firstLetter = hello[0];

//hello[0] = 'H' //siin teha ei saa

Console.WriteLine(firstLetter);
Console.WriteLine(hello);

//int wordCounter = 1;

//for(int i = 0; i < hello.Length; i++)
//{
    // Console.WriteLine($"{i} sympol in string: {hello[i]}");
    // if (hello[i] == ' ')
    //{ wordCounter++;}

 //   if (char.IsWhiteSpace(hello[i]))
   // { wordCounter++; }
//}

//Console.WriteLine(hello.Length);
//Console.WriteLine($"Word count in {hello}: {wordCounter} words." );