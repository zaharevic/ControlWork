# Решение Контрольной задачи
## Задание:
*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*
***
## Действие 1. Заполнение массива.
### Для начала необходимо узнать сколько строк хочет ввести человек. 
Для этого введем функцию GetMaxSzie() в которой человек воодит целочисленное число, равное количеству строк которое будет вводится после. Если же число не является целочисленным или оно меньше 0, то выводится "Ошибка обработки числа! Попробуйте снова с другим числом." и дальше произойдет ошибка, т.к. размер массива будет -1. Если же число удовлетворяет условиям, то массив с размером этого числа "пойдет" далее.
###  Далее необходимо ввести строки
Для этого введем функцию FillArray(int size, string[]array). В нее поступает размер массива(size) и массив строк(array).После через Enter вводятся строки, и заполняют массив, который после возвращается в основную(main) функцию.
## Действие 2. Поиск подходящих условию строк.
Для этого введем функцию StringLenghtLessThree(string[] array). В нее поступает массив строк(array). Каждый член массива строк проверяется на то, меньше или равно ли количество символов в нем, чем 3. Если строка удовлетворяет этми условиям, то она записывается в другой массив(temporarryArra), который возвращается в основную функию.
## Действие 3. Вывод результата.
Для этого введе функцию PrintArray(string[] arr), в которую поступает массив строк (arr), в котором все строки с количеством символов меньше 4. После  каждая строка выводится на поле.
***
# Конец