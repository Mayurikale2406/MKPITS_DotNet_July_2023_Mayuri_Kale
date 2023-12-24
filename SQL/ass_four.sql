select * from customer1
select * from salesman1
select * from orders1
SELECT *
FROM orders1
WHERE salesman_id IN
    (SELECT salesman_id 
     FROM salesman1 
     WHERE city ='New York');
