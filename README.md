Реализовать приложение для сортировки массивов данных. 
Алгоритмы сортировки (bubbleSort, insertionSort, selectionSort, heapSort, quickSort) должны быть представлены в виде классов, реализующих паттерн “стратегия”. 
Данные в массиве могут быть любого типа. 
В рамках процесса можно выполнить несколько различных сортировок массива (объект, хранящий массив, должен реализовывать паттерн “прототип”). 
Сортировать данные можно по возрастанию/убыванию. 
В качестве параметров для создания объектов “стратегий” передаются селектор ключа (поле или набор полей, по которому (-ым) производится сортировка) и правило нахождения отношения порядка между ключами (делегат или объект, реализующий интерфейс IComparer).
