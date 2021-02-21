--Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers --Adi SirketAdi bunlar ALİAS istersen bu sekilde isimlendirerek cagırabiliriz.


Select * from Customers where City = 'Berlin'


--case insensitive yani büyük küçük harf duyarsız
select * from Products where CategoryId=1 or categoryId=3

select * from Products where CategoryId=1 and UnitPrice>=10

select * from Products order by ProductName --orderby sırala ürün ismine göre sırala

select * from Products order by CategoryID

select * from Products order by CategoryID, ProductName

select * from Products order by UnitPrice  asc  --ascending artan

select * from Products order by UnitPrice desc -- descending azalan/düşen

select * from Products where categoryId=1 order by Unitprice desc

Select count(*) from Products -- Tüm satırları say

Select count(*) from Products where CategoryID= 2 -- 2 numaraları kategoride kaç ürün var

Select count(*) Adet from Products where CategoryID= 2 -- .. .. kolonları getir dersen olmaz. Çünkü array mantıgıyla calısıyor


Select categoryID,count(*) from Products group by CategoryID --hangi kategoride kac tane ürün var

Select categoryID,count(*) from Products group by CategoryID having count(*)<10 -- 10 taneden az ürün çeşidi olan kategorileri ver

Select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 -- birim fiyatı 20den fazla olan ürünleri kategoriıd e göre grupla onlardanda sayısı 10 dan az olanlar
-- havingi kümülatife uygularız. önce where komutu çalışır

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories  -- buradaki from Hem product hem categorilerin bir araya getirilmiş hali
on Products.CategoryID = Categories.CategoryID -- bunlar birbirine eşitse jointle yani birleştir. 'on'şarttıyla demek
where Products.UnitPrice>10 --ürünlerden fiyat 10dan büyük olanlar için onu kategorilerle joint et ve getir. 

--DTO Data Transformation Object  
-- İNNER JOİN sadece iki tabloda eşleşen dataları getirir eşleşmeyenleri getirmez.

Select * from Products p inner join [Order Details] od	-- Burada order details veri tabanında ismi ayrı yazıldıgı için köşeli parantez içinde yazdık. p ve od alias
on p.ProductID=od.ProductID

Select * from Products p left join [Order Details] od	-- Solda olup sağda olmayanları da getir üürnler tablosunda var ama hiç satışı yapamayan ürünleri getir
on p.ProductID=od.ProductID

Select * from Products p inner join [Order Details] od	-- 2 den fazla join yapmak için devamına inner join eklersin
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID = od.OrderID


Select * from Customers c inner join Orders o -- 830 tane sipariş var. Detayın çok gelmesinin sebebi her siparişte birden fazla ürün oldugu için
on c.CustomerID = o.CustomerID

Select * from Customers c left join Orders o -- Müşterişte olup Siparişte olmayanları da getir. sağda olmayanlar null olarak gelir, müşteri bilgisi siparişte olur, siparişin bir müşterisi olur
on c.CustomerID = o.CustomerID
where o.CustomerID is null -- burada çıkan müşteriler bizden hiç ürün almamış null ı primary key e uygularız oda CustomerID





