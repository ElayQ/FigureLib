<h1>Практическое задание</h1>
<h2>Задание 1</h2>
<p>Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
<br>1. Библиотека в папке FigureLib.
<br>2. Юнит-тесты в папке FigureLibTests.</p>


<h2>Задание 2</h2>
<p>В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.</p>
<p>Диаграмма связи таблиц:</p>

![image](https://github.com/ElayQ/FigureLib/assets/136975327/c00c6f3a-be8f-4a7e-a89c-3dd44fd9f0cb)

<p>Создание таблиц:</p>
<pre lang="sql">
CREATE TABLE Products
(
	ProductID int primary key,
	ProductName varchar(128) not null,
)
<br>
INSERT INTO Products(ProductID, ProductName) VALUES (1, 'Apple')
INSERT INTO Products(ProductID, ProductName) VALUES (2, 'Apricot')
INSERT INTO Products(ProductID, ProductName) VALUES (3, 'Banana')
INSERT INTO Products(ProductID, ProductName) VALUES (4, 'Kiwi')
INSERT INTO Products(ProductID, ProductName) VALUES (5, 'Blackberry')
INSERT INTO Products(ProductID, ProductName) VALUES (6, 'Blueberry')
INSERT INTO Products(ProductID, ProductName) VALUES (7, 'Cherry')
INSERT INTO Products(ProductID, ProductName) VALUES (8, 'Watermelon')
INSERT INTO Products(ProductID, ProductName) VALUES (9, 'Carrots')
INSERT INTO Products(ProductID, ProductName) VALUES (10, 'Cabbage')
INSERT INTO Products(ProductID, ProductName) VALUES (11, 'Garlic')
INSERT INTO Products(ProductID, ProductName) VALUES (12, 'Cucumbers')
INSERT INTO Products(ProductID, ProductName) VALUES (13, 'Shirt')
INSERT INTO Products(ProductID, ProductName) VALUES (14, 'Tomato')
<br>
CREATE TABLE Categories
(
	CategoryID int primary key,
	CategoryName varchar(128) not null,
)
<br>
INSERT INTO Categories(CategoryID, CategoryName) VALUES (1, 'Fruits')
INSERT INTO Categories(CategoryID, CategoryName) VALUES (2, 'Berries')
INSERT INTO Categories(CategoryID, CategoryName) VALUES (3, 'Vegetables')
<br>
CREATE TABLE Link
(
	ID int primary key,
	CategoryID int foreign key references Categories(CategoryID),
	ProductID int foreign key references Products(ProductID),
)
<br>
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (1, 1, 1)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (2, 1, 2)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (3, 1, 3)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (4, 1, 4)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (5, 2, 5)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (6, 2, 6)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (7, 2, 7)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (8, 2, 8)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (9, 3, 9)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (10, 3, 10)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (11, 3, 11)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (12, 3, 12)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (13, NULL, 13)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (14, 2, 14)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (15, 3, 14)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (16, 2, 4)
INSERT INTO Link(ID, CategoryID, ProductID) VALUES (17, 2, 3)
</pre>
<p>Запрос для выбора всех пар «Имя продукта – Имя категории»:</p>
<pre lang="sql">
SELECT p.ProductName, c.CategoryName
FROM Link AS l
JOIN Products AS p ON l.ProductID = p.ProductID
LEFT JOIN Categories AS c ON l.CategoryID = c.CategoryID
ORDER BY p.ProductName
</pre>
