class ObjectTypeCheck7
{


    static void Main(string[] args)
   {
    string value1="Hello";
    string value2="World";
    object obj=value1+value2;
    string value3=(string) obj;
    System.Console.WriteLine("Object Type values is:: "+value3);



   }


}