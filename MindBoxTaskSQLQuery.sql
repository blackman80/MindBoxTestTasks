CREATE TABLE Products (
		Id INT PRIMARY KEY,
		"Name" TEXT
);

INSERT INTO Products
VALUES
		(1, 'Говядина'),
		(2, 'Свинина'),
		(3, 'Молоко'),
		(4, 'Помидоры'),
		(5, 'Шоколад');

CREATE TABLE Categories (
		Id INT PRIMARY KEY,
		"Name" TEXT
);

INSERT INTO Categories
VALUES
		(1, 'Мясо'),
		(2, 'Молочная продукция'),
		(3, 'Овощи');

CREATE TABLE ProductCategories (
		ProductId INT FOREIGN KEY REFERENCES Products(Id),
		CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
		PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
		(1, 1),
		(2, 1),
		(3, 2),
		(4, 3);

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
		ON P.Id = PC.ProductId
LEFT JOIN Categories C
		ON PC.CategoryId = C.Id;