Console.Clear();

bool exitting = false;
string? readResult;
do{
    Console.WriteLine("Enter number of array(n): ");
    readResult = Console.ReadLine();
    int value;
    if(int.TryParse(readResult, out value)){
        Console.WriteLine($"The first {value} sequence of the Fibonnaci Series is: ");
        Fibonnaci(value);        
    }
    else if(readResult == "exit"){
        exitting = true;
    }
    else{
        Console.Clear();
        Console.WriteLine("Please Enter a valid number");
    }

}while(!exitting);

int[] Fibonnaci(int n){
    int[] sequence = new int[n];
    int sum = 1;
    int preNUm = 0;    
    for(int i = 0; i < n; i++){   
        sum+=preNUm; 
        //Console.WriteLine(sum);
        preNUm = sum - preNUm;
        sequence[i] = sum;
    }
    PrintSeq(sequence);
    return sequence; 
}
void PrintSeq(int[] array){
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}");
        if(i != array.Length-1){
            Console.Write(", ");
        }
        
    }
    Console.Write(" ]\n");
}
