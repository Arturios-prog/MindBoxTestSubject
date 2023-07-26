SELECT DISTINCT p.Name as Имя продукта, c.Name as Имя Категории
FROM Products as p
LEFT JOIN Categories as c on c.Id = p.CategoryFK
order by p.Name
