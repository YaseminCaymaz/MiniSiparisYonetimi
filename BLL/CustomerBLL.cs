using MiniSiparisYonetimi.DAL;
using MiniSiparisYonetimi.Models;

public class CustomerBLL
{
    private readonly CustomerDAL _customerDAL;
   // private readonly OrderDAL _orderDAL;

    public CustomerBLL( CustomerDAL customerDAL)
    {
        _customerDAL = customerDAL;
        //_orderDAL = orderDAL;
    }

    public void NewCustomer(Customer customer)
    {
       
        if (customer==null)
        {
            throw new Exception("Müşteri bilgileri eksik veya hatalıdır.Lütfen tekrar deneyiniz.");
        }

        _customerDAL.AddCustomer(customer);
    }

    public List<Customer> GetCustomers() 
    {
        return _customerDAL.GetCustomers();
    }

    public List<Customer> EnCokSiparisVerenMusteriler()
    {
        return null;
        // OrderDAL aldıgımız en cok sipariş veren müşterilerin listesini burda ID ileri ile eşleştirip 
        // coustomer bilgileri olarak dönüyoruz
       //  List<int> customersId=_orderDAL.EnCokSiparisVerenMusteriler().Select(x=>x.CustomerId).ToList();

        // return _customerDAL.GetCustomers().Where(x => customersId.Contains(x.Id)).ToList();
    }

}