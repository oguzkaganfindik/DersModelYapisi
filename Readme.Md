## Görev-8

- DersModelYapisi isminde yeni bir MVC projesi oluştur.
- Product isminde bir model sınıfı oluştur.
* int Id
* string Name
* decimal Price
- CartProduct isminde bir model sınıfı oluştur. 
* int Id
* Product Product
* int Quantity
* decimal Price
- CartController controller'ı oluşturalım.
* İçerisinde Index metodunda; 3 tane Product oluşturalım.
* var product1 = new Product { … };
* Bu 3 product nesnesini içeren 3 tane CartProduct nesnesi oluşturalım. Örneğin;
* var cartProduct1 = new CartProduct { Product = product1, Quantity=5, Price=5 };
- cartProducts isminde bir listede bu 3 tane CartProduct nesnesini View'e ViewModel olarak gönderelim.
- CartController içerisinde Index View oluşturalım. Bu View içerisinde Sepeti gösterelim. Sepeti tablo olarak gösterebiliriz.
(https://getbootstrap.com/docs/5.1/content/tables/#overview)
- Tablonun en altında sepet tutarının toplamını, KDV'sini ve KDV'li tutarı da gösterelim.

### İşlemler Tamamlandı.
