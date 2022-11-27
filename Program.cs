string [] arr1 = {"low", "thing", "-9", ":-)", "i", "Dave"};

//Функция считающая количество ячеек в будущем массиве
int threeOrLess(string [] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length < 4){
            count++;
        }
    }
    return count;
}