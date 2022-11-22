<h1 align="center">Test Task</h1>

## Оглавление:
### Тестовое задание №1 - C#
1. [Класс Scalculator](#Класс-Scalculator)
2. [Класс Type](#Класс-Type)
3. [Персонализация](#Персонализация)

### Тестовое задание №2 - SQL
1. [Определение и написание запросов](#Определение-и-написание-запросов)
2. [Результат](#Результат)

## Тестовое задание №1 - C#

### Класс Scalculator

Данный класс является сборником формул, для соответствующих подсчетов. Единственное поле данного класса - это ответ, оно сделано для удобства. Однако совершенно не обязательно. 
Далее следуют два необходимых по условию метода, в которых расчитываются площади треугольника и круга соответственно:

```
public void Trl_rib( double a, double b, double c ){ ... }
```

```
public void Crl_r( double r ){ ... }
```

### Класс Type

Данный класс является звеном, позволяющим пользователю не определять тип фигуры заранее во входных данных. Программа сама определяет тип фигуры в run-time при помощи заданных правил. Более наглядно используемый принцип можно рассмотреть на примере ниже:

```
var info = Console.ReadLine();
Type figure = Type.check(info);
switch (Type.ToLower())
{
    case "square": 
        { ... }; break;
    case "rectangle":  
        { ... }; break;
    case "circle": 
        { ... }; break;
    default:  
        Console.WriteLine("Неверный тип фигуры"); break;
}
```

Таким образом, в зависимости от количества введенных чисел зависит тип рассматриваемой фигуры. В случае, если рассмотриваему количеству введенных данных сопоставляется одна из фигур, данные проверяются на истинност 

<b>*Example:*</b> Проверка существвования треугольника по трем сторонам.

Если же количеству данных сопоставляется несколько типов фигур - данные проходят дополнительные проверки для более точного определения:

<b>*Example:*</b> Является треугольник прямоугольным.

### Персонализация

Исходя из технического задания, необходимо было написать программу, в которую можно будет легко добавлять новые фигуры. Для этого необходимо создать новый метод для рассчета площади в классе <b>Scalculator</b>, а также инициализацию данной фигуры в классе <b>Type</b>. Метод <b>*Type.Check( data[ ] )*</b> возвращаетчисло, которое соответствует той или иной фигуре, однако можно сделать метод строковым и возвращать *string* - название самой фигуры, как было показано в примере. Принцип работы программы подобные подобные коррективы не меняют.

## Тестовое задание №2 - SQL

### Определение и написание запросов

По описанию это связь N:M. Она реализуется с помощью отдельной таблицы, в которую помещаются внешние ключи на первичный ключ из таблицы продукты и категории.

![Диаграмма](https://user-images.githubusercontent.com/90879703/203339846-e3b87aaa-0928-422f-a0de-513444b2a942.jpg)

```
create table products(id integer primary key AUTO_INCREMENT, name_prod varchar(25), constraint product_unique unique(name_prod));
insert into products(name_prod) values ('продукт_1'), ('продукт_2'), ('продукт_3'), ('продукт_4'),('продукт_5');
select * from products;

create table categories( id integer primary key AUTO_INCREMENT, name_cat varchar(25), constraint categories_unique unique(name_cat));
insert into categories(name_cat) values ('категория_1'), ('категория_2'), ('категория_3'), ('категория_4'),('категория_5');
select * from categories;

create table products_categories(id_prod integer not null references products(id), id_cat integer not null references categories(id));
insert into products_categories values (1, 1), (1, 2), (2, 1), (2, 3), (3, 4), (4, 5);
select * from products_categories;

select products.name_prod, categories.name_cat from products
left join products_categories on products.id = products_categories.id_prod
left join categories on categories.id = products_categories.id_cat
```

### Результат

На картинке ниже, можно увидеть вывод работы соответствующих запросов.

![Результат](https://user-images.githubusercontent.com/90879703/203340114-67612e0d-6c65-41cb-b544-532b110ecbe4.jpg)
