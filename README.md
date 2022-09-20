<!---Пример кода-->
[![Typing SVG](https://readme-typing-svg.herokuapp.com?color=%2336BCF7&lines=Test+task+Digital+Design)](https://git.io/typing-svg)

В данном репозитории выполнено тестовое задание компании Digital Design
![image](https://user-images.githubusercontent.com/87894035/190894309-c912e174-c391-4ba4-8225-e47a1a000c8b.png)
 

В качестве первого задания реализована база данных с двумя таблицами: сотрудники и отделение . 

![image](https://user-images.githubusercontent.com/87894035/190894287-1eedfea9-5320-4ad7-ac6a-10feb74e6be6.png)

### Таблица Сотрудник:

![image](https://user-images.githubusercontent.com/87894035/190894355-4a487b9f-be81-490c-bce6-7ad7816afae0.png)

### Таблица Отдел:

![image](https://user-images.githubusercontent.com/87894035/190894400-0a683a46-8291-4720-a949-13adf2db3c20.png)

Запрос сотрудника с наибольшей зарплатой:

```
 SELECT Name FROM 
 Where Salary = (select MAX(Salary) from Employee);
```

### Выполнение запроса:

![image](https://user-images.githubusercontent.com/87894035/190894445-668d154f-97ec-4245-a63b-15eacc660f4b.png)

Запрос отдела, с самой высокой заработной платой между сотрудниками:

```
SELECT Department
FROM Employee
WHERE Salary = (select MAX(Salary) from Employee); 
```
### Выполнение запроса:

![image](https://user-images.githubusercontent.com/87894035/190894545-af2eceda-c218-44a1-bae9-e3c081dac5a0.png)

Запрос отдела, с максимальной сумарной зарплатой сотрудников :
```
SELECT Employee.Department, Sum(Employee.Salary) AS [Sum-Salary] FROM Employee GROUP BY Employee.Department
HAVING Sum(Employee.Salary) >= ALL(
SELECT Sum(Employee.Salary) AS [Sum-Salary] FROM Employee GROUP BY Employee.Department);
```
### Выполнение запроса:

![image](https://user-images.githubusercontent.com/87894035/190894612-31fb4527-e896-4e3c-bfd0-665cd62e61e6.png)

Запрос сотрудника, чье имя начинается на <<Р>> и заканчивается на <<н>>:
```
SELECT Employee.Name
FROM Employee
WHERE Name like 'Р*н';
```
### Выполнение запроса:

![image](https://user-images.githubusercontent.com/87894035/190894748-6cbf095a-02f8-4054-bd48-51032d7b0ee8.png)


В качестве второго задания была реализовано консольное приложение на языке C#, которое принимает большой текстовый файл ( В папке bin/Debug) на выходе создает текстовый файл с перечнем всех используеммых в данном на вход файле слов, и количеством их употреблений, отсортированнхы в порядке убывания количества употреблений. 

## Код програмы:

![image](https://user-images.githubusercontent.com/87894035/190895012-0df57087-93a1-48b0-a52b-9b2067bf524c.png)

![image](https://user-images.githubusercontent.com/87894035/190895032-cd3c01d3-0496-4817-bd7d-c619279bde4c.png)

![image](https://user-images.githubusercontent.com/87894035/190895058-cfd92217-a430-474e-aa52-d0aa1f7e7c36.png)

## Итоговый файл output:

![image](https://user-images.githubusercontent.com/87894035/190895257-0263acc4-f53a-4eb3-a23e-bb78db6a8c71.png)


