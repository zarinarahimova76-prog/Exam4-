using System.Net;

public class Book
{
    public string? Title {get; set;}
    public string? Author{get; set;}
    public BookStatus Status {get; set;}
    public DateTime BorrowDate {get; set;}
    public DateTime DueDate {get; set;}

    public void Borrow(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Ошибка");
            return;
        }
        if (Status != BookStatus.Available)
        {
            Console.WriteLine("Книга уже видана ");
            return;
        }

    
        Status = BookStatus.Borrowed;
        BorrowDate = DateTime.Now;
        DueDate = BorrowDate.Value.AddDays(days);

        Console.WriteLine("Книга успешно выдана.");
        Console.WriteLine("Дата выдачи: " + BorrowDate);
        Console.WriteLine("Дата возврата: " + DueDate);

    }


    public int Return(DateTime returnDate)
    {
        if (Status != BookStatus.Borrowed)
        {
            Console.WriteLine("Ошибка: книга не была выдана.");
            return 0;
        }

        int fine = 0;
        if (returnDate > DueDate)
        {
            TimeSpan difference = returnDate - DueDate.Value;
            int overdueDays = difference.Days;

            fine = overdueDays * 5;
        }
          Status = BookStatus.Available;
        BorrowDate = null;
        DueDate = null;
        Console.WriteLine("Книга возвращена.");
        Console.WriteLine("Штраф: " + fine + " сомони");

        return fine;
    }
    public bool IsOverdue
    {
        get
        {
            if (Status == BookStatus.Borrowed && DateTime.Now > DueDate)
            {
                return true;
            }

            return false;
        }
    }
}




