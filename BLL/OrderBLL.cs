using MiniSiparisYonetimi.DAL;
using MiniSiparisYonetimi.Models;

public class OrderBLL
{
    private readonly OrderDAL _orderDAL;
    private readonly CustomerDAL _customerDAL;

    public OrderBLL(OrderDAL orderDAL, CustomerDAL customerDAL)
    {
        _orderDAL = orderDAL;
        _customerDAL = customerDAL;
    }

    public void NewOrder(Order order)
    {
        
        // Aynı müşterinin 24 saat içinde en fazla 3 sipariş verebilme kuralını kontrol et
        if (_orderDAL.GetSon24SaatSiparisSayisi(order.CustomerId) >= 3)
        {
            throw new Exception("Aynı müşteri 24 saat içinde en fazla 3 sipariş verebilir.");
        }

        // İndirim kodu atama işlemini gerçekleştir
        order.DiscountCode = IndirimKoduUygula(order);
        order.DiscountCode = IkinciIndirim(order);

        _orderDAL.AddOrder(order);
    }

   
  //Tutar 100'den fazla ise yüzde 10 indirim kodunu atayacak
    private string IndirimKoduUygula(Order order)
    {
        // toplam tutara göre indirim kodu atanıyor
        if (order.TotalPrice > 100)
        {
            return "YUZDE10";
        }

        return null;
    }
    //Son 24 saatte yapılan 3. alışverişte indirim tanımlanıyor.
    private string IkinciIndirim(Order order)
    {
        if(_orderDAL.GetSon24SaatSiparisSayisi(order.CustomerId) ==3){
            return "YUZDE5";
        }  
        return null;
    }

    internal List<Order> GetOrders()
    {
        return _orderDAL.GetOrders();        
    }
}