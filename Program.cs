/*
    I am Johannus or Rafael in real the world, a jobless cs grad who just devour programming knowledge until
    my brain becomes fried (ofc just kidding)

    You want some basic C# codes? You are in the right repository but please take note that I started
    with methods and not the super basics like declaring a variable, you are wise enough to do that on your own


    Im doing this program along with learning C# @ w3schools.
    you can find it here https://www.w3schools.com/cs
    Having knowledge with C and C++ makes learning this language a lesser pain
    
    by some any chances, Microsoft got rid of their ridiculous boilerplate
*/


/*
    This is the main (because they got tired of boilerplate which is a pain in the ass lol)
    Method names speaks for itself
*/
MultiDimensionalArray();
Spacer();
TraverseArrayForEachApproach();
Spacer();
TraverseArrayForLoopApproach();
Spacer();
PassingParameter("John");
Spacer();
PassingMultipleParameters("John", "Doe", 29);
Spacer();
MultiplyByThirteen(13);




/******************************************************************************/
// Methods starts here :)) 
static void MultiDimensionalArray(){
    // This method traverses the numbers from a two domensional array
        int?[,] numbers = { {1, 4, 2}, {3, 6, 8} };
        Console.WriteLine("Traversing a 2D array...");
        for (int i = 0; i < numbers.GetLength(0); i++) 
        { 
            for (int j = 0; j < numbers.GetLength(1); j++) 
            { 
            Console.WriteLine(numbers[i, j]); 
            } 
        }
}


static void Spacer(){
    /*
        Yes, I made a method just to display a spacer
    */
    Console.WriteLine("=============================");
}


static void TraverseArrayForEachApproach(){
    Console.WriteLine("Traversing an array using foreach");
    int?[] numbers = {1,4,6,9,45,76,32,78,345,0,34,66,69};
    foreach(int? i in numbers){
        Console.WriteLine(i.Value);
    }
}


static void TraverseArrayForLoopApproach(){
    Console.WriteLine("Traversing an array using for loop");
    string?[] names = {
        "Zeus",
        "Hannah",
        "Angelo",
        "Icarus",
        "Roselyn",
        "Apollo"
    };
    for (int i = 0; i < names.Length; i++){
        /*  this is called string interpolation. In C#, we
            need to provide the dollar sign '$' at the beginning
            it makes the code easier to read than using concatenation  */
        Console.WriteLine($"{names[i]}");
    }
}

static void PassingParameter(string firstname){
    Console.WriteLine("Passing a parameter in this method");
    Console.WriteLine($"{firstname} Doe");
}

static void PassingMultipleParameters(string firstname, string lastname, int age){
    Console.WriteLine("Passing parameters in this method");
    // The line below is a ternary operator, a shorthand for if-else or switch statement by any chance    
    string AgeVerification = (age < 18) ? $"{firstname} {lastname} is a minor" : $"{firstname} {lastname} is {age} years old";
    Console.WriteLine(AgeVerification);
}



/*
    As you can see, the methods below is not using the "void" keyword anymore, "void" keyword is used in methods
    that doesn't return any value.
    The methods below returns a value so the word "void" is ommited or else it will return an error
*/
static double MultiplyByThirteen(double number){
    // returns the number multiplied by 13
    return number * 13;
}


