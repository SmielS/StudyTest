# **Проверочная работа**
**Задача** :

*Написать программу, которая из имеющегося массива формирует массив из строк, длина которых меньше либо равна 3 (трём) символам*
***
**Решение** :

Заданный массив **array** разбивается поэлементно, и каждый элемент, длина которого больше либо равна трём, заносится в новый массив **newArray**.


```
string[] ArrayMethod(string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        string temp = array[i];
        if (temp.Length <= 3) newArray[i] = temp;
    }
    return newArray;
}
```