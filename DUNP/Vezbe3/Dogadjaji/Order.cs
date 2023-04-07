namespace CSharp.DUNP.Vezbe3.Dogadjaji;

public class CustomEventArgs : EventArgs
{
    public Product Product { get; set; }
}
public class Order
{
    public delegate void OrderProcessEventHandler(object sender, CustomEventArgs e);
    public event OrderProcessEventHandler OrderProcess;
    public void Process(Product product)
    {
        Console.WriteLine($"Processing product with id {product.Id}");
        Thread.Sleep(3000);

        OnOrederProcess(product);


    }
    public virtual void OnOrederProcess(Product product)
    {
        if (OrderProcess != null)
        {
            OrderProcess(this, new CustomEventArgs { Product = product});
        }


    }
}

/*
* Main funkcija
* 
* public class SMSService(){

public void OrderProcessed(object sender, CustomEventArgs e)
{
Console.WriteLine($"Hey I got request from order that order {e.Product.Name} has been processed  (SMS)");
}
}
public class EmailService(){

public void OrderProcessed(object sender, CustomEventArgs e)
{
Console.WriteLine($"Hey I got request from order that order {e.Product.Id} has been processed (Email) ");
}
}

Order o = new Order();
SMSService sMS = new SMSService();
EmailService email = new EmailService();
o.OrderProcess += sMS.OrderProdessed;
o.OrderProcess += email.OrderProdessed;

o.Process();

    //Kreirati extention metodu koja skracuje naslov na doredjeni broj reci a u nastavku dodaje 
    // ...
*/
