using Microsoft.AspNetCore.Mvc;
using MiniSiparisYonetimi.Models;

namespace MiniSiparisYonetimi.Controllers;
public class CustomerController : Controller
{
  
 // product/index
    public IActionResult Index()
    {
        var customer = new Customer();
        customer.Id = 1;
        customer.Name = "Hasan";
        customer.Surname = "Can";
        customer.Email = "hasan@can.com";
        customer.Phone = "25417854";
        customer.RegisterDate = DateTime.Now;
        return View(customer);
    }

    // product/list
     public IActionResult List()
    {
        var customers = new List<Customer>();
        customers.Add(new Customer() { Id = 1, Name = "Hasan", Surname = "Can", Email = "hasan@can.com", Phone = "25417854", RegisterDate = DateTime.Now });
        customers.Add(new Customer() { Id = 2, Name = "Merve", Surname = "Demir", Email = "merve@can.com", Phone = "25417854", RegisterDate = DateTime.Now });    
        customers.Add(new Customer() { Id = 3, Name = "Ali", Surname = "Kaya", Email = "ali@can.com", Phone = "25417854", RegisterDate = DateTime.Now });    
        customers.Add(new Customer() { Id = 4, Name = "Deniz", Surname = "Mavi", Email = "deniz@can.com", Phone = "25417854", RegisterDate = DateTime.Now });    
        customers.Add(new Customer() { Id = 5, Name = "Ayşe", Surname = "Kuzu", Email = "ayse@can.com", Phone = "25417854", RegisterDate = DateTime.Now });    
        customers.Add(new Customer() { Id = 6, Name = "Leyla", Surname = "Bal", Email = "leyla@can.com", Phone = "25417854", RegisterDate = DateTime.Now });

        return View(customers);
    }
    
    //   En cok siparis veren musteriler ekrana yazmak için gönderilir
    
       public IActionResult CustomerList()
         {
            // veritabanına baglı olsaydı bu metodla front-end kısmına bilgileri GET ile gönderilecekti
          //return View(_customerBLL.EnCokSiparisVerenMusteriler());
          return View();
         } 
  
}