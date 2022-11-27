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

//Функция, создающая массив с выражениями длинной менее или равным 3 символам
string [] arrOfThreeAndLess(int number, string [] beginArr){
    string [] finalArr = new string[number];
    int j = 0;
    for (int i = 0; i < beginArr.Length; i++){
        if(beginArr[i].Length < 4){
            finalArr[j] = beginArr[i];
            j++;
        }
    }
    return finalArr;
}

string [] finalArr1 = (arrOfThreeAndLess(threeOrLess(arr1), arr1));
for (int j = 0; j < finalArr1.Length; j++){
        if (j == 0){
            Console.Write("['" + finalArr1[j] + "', ");
        }
        else if (j == finalArr1.Length - 1){
            Console.WriteLine("'" + finalArr1[j] + "']");
        }
        else {Console.Write("'" + finalArr1[j] + "', ");}
    }