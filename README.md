
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
___

**Описание алгоритма решения:**
1. Создаем метод  заполнения FillingArray первоначального массива с клавиатуры, разделителем между элементами которого выступает ","
2. Создаем метод  вывода информации о массиве на консоль PrintArray
3. Создаем метод формирования второго массива ArrayFormation: 
* Из условия формирования строк второго массива, длина которых меньше либо равна 3 символа, вычисляем его размерность-length;
* Объявляем второй массив нужной размерности;
* Вводим переменную count, определяющую позицию элемента во втором массиве;
* Заполняем массив элементами, длина которых меньше либо равна 3 символа;
* Выводим получившийся массив на консоль, используя метод PrintArray



