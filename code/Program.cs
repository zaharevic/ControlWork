int GetMaxSize(){
    Console.Write($"Введите количество строк: ");
    bool correctNumber = int.TryParse(Console.ReadLine(), out int MaxSize);
    if (correctNumber && MaxSize > 0){
        return MaxSize;
    }
    else{
        Console.Write($"Ошибка обработки числа! Попробуйте снова с другим числом. \n");
        return -1;
    }
}
string[] FillArray(int size, string[]array){
    for(int i = 0; i < size; i++){
        Console.WriteLine($"Строка {i+1}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
string[] StringLenghtLessThree(string[] array){
    string[] temporarryArray = new string[array.Length];
    int j = 0;
    for(int i= 0; i < array.Length; i++){
        if(array[i].Length <= 3){
            temporarryArray[j] = array[i];
            j++;
        }
    }
    return temporarryArray;
}
void PrintArray(string[] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
}


int maxSize = GetMaxSize();
string[] array = new string[maxSize];
array = FillArray(maxSize, array);
string[] newArray = new string[maxSize];
newArray = StringLenghtLessThree(array);
PrintArray(newArray);