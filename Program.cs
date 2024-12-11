// See https://aka.ms/new-console-template for more information
MultiDimensionalArray();
Spacer();
TraverseArrayForEachApproach();
TraverseArrayForLoopApproach();


static void MultiDimensionalArray(){
    // This method traverses the numbers from a two domensional array
        int?[,] numbers = { {1, 4, 2}, {3, 6, 8} };

        for (int i = 0; i < numbers.GetLength(0); i++) 
        { 
            for (int j = 0; j < numbers.GetLength(1); j++) 
            { 
            Console.WriteLine(numbers[i, j]); 
            } 
        }
}


static void Spacer(){
    Console.WriteLine("=============================");
}


static void TraverseArrayForEachApproach(){
    int?[] numbers = {1,4,6,9,45,76,32,78,345,0,34,66,69};
    foreach(int? i in numbers){
        Console.WriteLine(i.Value);
    }
}


static void TraverseArrayForLoopApproach(){
    string?[] names = {
        "Zhaira",
        "Rafael",
    };
    for (int i = 0; i < names.Length; i++){
        Console.WriteLine($"{names[i]}");
    }
}


