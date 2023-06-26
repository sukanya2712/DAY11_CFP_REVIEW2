namespace review2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*input: "Happy BirthDay"
    output: "hAAPY bIRTHdAY"*/

            //string word = "Happy BirthDay";
            // string answord = string.Empty;
            //char.IsUpper('a')-> false

            /*for (int i=0; i<word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    answord += char.ToLower(word[i]);
                }
                else 
                {
                    answord += char.ToUpper(word[i]);
                }
               
            }

            Console.WriteLine(answord);*/

            Console.WriteLine(ConvertString.Method2("Happy BirthDay"));


        }
    }
}