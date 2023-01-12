# Массив строк
### Представлены программы, которые из имеющегося массива строк формируют новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

### Вариант, когда первоначальный массив задан на старте выполнения.

__Для выполнения задачи сделаем следующее__:
- необходимо объявить переменные. Массив строк; текущее кол-во строк в массиве; переменную, которая сохраняет старый массив. 
- далее создаем цикл ввода строк. Обнуляем кол-во строк, выделяем память для строк, вводим строку, проверяем непустая ли, и до тех пор пока строка непустая добавляем ее в массив, предварительно выделяем память для нового массива, в котором на 1 элемент больше. Копируем старый массив в новый (промежуточный), добавляем введенную строку в массив и делаем массив равным промежуточному.
- далее выводим массив.

Блок-схему, описанной задачи, можно посмотреть в файле "block diagram2.jpg"

### Вариант, когда первоначальный массив массив можно ввести с клавиатуры.
__Для выполнения задачи сделаем следующее__:
- необходимо обозначить два массива. Один масcив задан, второй будет создан в итоге выборки. 
- далее создать функцию, в которой проходя ч/з цикл будут выбираться из первого массива элементы с количеством символов до трех включительно (итоговая выборка и станет вторым массивом).
- далее создать функцию вывода второго массива.

Блок-схему, описанной задачи, можно посмотреть в файле "block diagram1.jpg"