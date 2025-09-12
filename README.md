Тестовое задание
Панков Андрей

Также прикладываю SQL запросы из задания 2:

SELECT c.ClientName, count(c.ClientName) as CountContacts FROM ClientContacts as cs join Client as c on cs.ClientId = c.Id group by c.ClientName;

SELECT c.ClientName FROM ClientContacts as cs join Client as c on cs.ClientId = c.Id group by c.ClientName having count(c.ClientName) > 2;

Задание 3:
SELECT
  Id,
  Dt AS StartDate,
  LEAD(Dt) OVER (PARTITION BY Id ORDER BY Dt) AS EndDate,
FROM Dates
WHERE LEAD(Dt) OVER (PARTITION BY Id ORDER BY Dt) IS NOT NULL
