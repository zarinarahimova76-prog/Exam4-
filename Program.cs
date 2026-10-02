
// //1 Enum перечисление это специальный тип данных в C# который позволяет создават набор именованных констант (например банковский  статус sent failed sucsses)  Он улучшает читаемость кода так как вместо использования магических чисел или обычных констант можно использовать понятные имена. Это делает код более понятным и поддерживаемым.

// // 2 
// //DateTime это структура в С# которая собой моментами времени и операциями по времени кати кор мекунад


// //3 Идирокани истисно ин барои хатогихои худро дар як строка фахмо барорад масалан try ба хамон шарти масала яне чиро кабул мекунад ва catch бошад барои хамон ошибкаро капидан  ва finally ки кетч кор мекунад ё не ягомчиро мебарорад try ва finally якбор мешавад я catch чандборхам мешавад 

// //4
//Полиморфизм ин манои бисёршакли дорад ки ба хамаи класои дочернияш любой намуд подход карда метавонад а класси Абстракти бошад ин тана надорад ва хар як класба метавонем тани худашро созем дар холати масалан shape фигура метаввонем абстракт истифода барем а класи animal метавонем палимарфизм истифода барем 


// //Task5

        // try
        // {
        //     Book book1 = new Book();
        //     Console.Write("Введите название книги: ");
        //     book1.Title = Console.ReadLine();
        //     Console.Write("Ведите автора: ");
        //     book1.Author = Console.ReadLine();
        //     Console.Write("Введите статус (Available, Borrowed, Reserved, Lost): ");
        //     string statusText = Console.ReadLine();
        //     book1.Status = Enum.Parse<BookStatus>(statusText);
        //     Console.Write("Введите количество дней: ");
        //     string daysText = Console.ReadLine();
        //     int days = int.Parse(daysText);
        //     Console.WriteLine();
        //     Console.WriteLine("Информация о книге:");
        //     Console.WriteLine("Название: " + book1.Title);
        //     Console.WriteLine("Автор: " + book1.Author);
        //     Console.WriteLine("Статус: " + book1.Status);
        //     Console.WriteLine();
        //     book1.Borrow(days);
        //     Console.WriteLine();
        //     Console.WriteLine("Просрочена ли книга: " + book1.IsOverdue); 
        //     Console.WriteLine();
        //     Console.Write("Введите дату возврата: ");
        //     string returnText = Console.ReadLine();
        //     DateTime returnDate = DateTime.Parse(returnText);
        //     book1.Return(returnDate);

        //     Console.WriteLine();
        //     Console.WriteLine("Текущий статус: " + book1.Status);
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine("Ошибка: " + ex.Message);
        // }
    

























