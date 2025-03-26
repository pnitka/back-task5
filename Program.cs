// Задачи с использованием массивов и условий

//Задача 1: Фильтр книг
using System;

public class Book
{
    public string title;
    public string author;
    public double price;
}

public class BookFilter
{
    public static void Main(string[] args)
    {
        Book[] books = new Book[5];

        books[0] = new Book { title = "Книга 1", author = "Автор 1", price = 250 };
        books[1] = new Book { title = "Книга 2", author = "Автор 2", price = 400 };
        books[2] = new Book { title = "Книга 3", author = "Автор 3", price = 800 };
        books[3] = new Book { title = "Книга 4", author = "Автор 4", price = 1200 };
        books[4] = new Book { title = "Книга 5", author = "Автор 5", price = 600 };

        Console.WriteLine("Книги с ценой от 300 до 1000:");
        foreach (Book book in books)
        {
            if (book.price >= 300 && book.price <= 1000)
            {
                Console.WriteLine(book.title + " - " + book.author + " - " + book.price);
            }
        }
    }
}


//Задача 2: расписание уроков (там 5 уроков, а у меня 8:( )
using System;

public class Lesson
{
    public string subject;
    public string time;
    public string teacher;
}

public class Schedule
{
    public static void Main(string[] args)
    {
        Lesson[] lessons = new Lesson[5];

        lessons[0] = new Lesson { subject = "Математика", time = "9:00", teacher = "Иванов" };
        lessons[1] = new Lesson { subject = "Русский язык", time = "10:00", teacher = "Петрова" };
        lessons[2] = new Lesson { subject = "Физика", time = "11:00", teacher = "Сидоров" };
        lessons[3] = new Lesson { subject = "Химия", time = "12:00", teacher = "Иванов" };
        lessons[4] = new Lesson { subject = "История", time = "13:00", teacher = "Смирнов" };

        Console.WriteLine("Уроки, которые проводит Иванов:");
        foreach (Lesson lesson in lessons)
        {
            if (lesson.teacher == "Иванов")
            {
                Console.WriteLine(lesson.subject + " - " + lesson.time);
            }
        }
    }
}

// Сложные задачки (задачи выше были кста сложнее чучуть)

//Задача 1: Система управления сотрудниками
using System;
using System.Collections.Generic;

public class Employee
{
    public string name;
    public string position;
    public double salary;
}

public class Manager : Employee
{
    public List<Employee> subordinates = new List<Employee>();

    public void AddSubordinate(Employee employee)
    {
        subordinates.Add(employee);
    }

    public double CalculateTotalSalaryBudget()
    {
        double total = 0;
        foreach (Employee employee in subordinates)
        {
            total += employee.salary;
        }
        return total;
    }
}

public class EmployeeManagement
{
    public static void Main(string[] args)
    {
        Manager manager = new Manager { name = "Петров", position = "Менеджер", salary = 50000 };

        Employee employee1 = new Employee { name = "Иванов", position = "Разработчик", salary = 30000 };
        Employee employee2 = new Employee { name = "Сидоров", position = "Тестировщик", salary = 25000 };

        manager.AddSubordinate(employee1);
        manager.AddSubordinate(employee2);

        Console.WriteLine("Общий бюджет зарплат подчинённых: " + manager.CalculateTotalSalaryBudget());
    }
}


// Задача 2: Интернет-магаз
using System;
using System.Collections.Generic;

public class User
{
    public string username;
    public string email;

    public void PlaceOrder(Order order)
    {
        Console.WriteLine(username + " оформил заказ на сумму " + order.totalCost);
    }
}

public class Product
{
    public string name;
    public double price;
    public int quantity;
}

public class Order
{
    public List<Product> products = new List<Product>();
    public double totalCost;

    public void AddProduct(Product product, int amount)
    {
        if (product.quantity >= amount)
        {
            products.Add(product);
            totalCost += product.price * amount;
            product.quantity -= amount;
        }
        else
        {
            Console.WriteLine("Недостаточно товара на складе: " + product.name);
        }
    }
}

public class Shop
{
    public static void Main(string[] args)
    {
        User user = new User { username = "user1", email = "user1@example.com" };

        Product product1 = new Product { name = "Товар 1", price = 100, quantity = 10 };
        Product product2 = new Product { name = "Товар 2", price = 200, quantity = 5 };

        Order order = new Order();

        order.AddProduct(product1, 2);
        order.AddProduct(product2, 1);

        user.PlaceOrder(order);

        Console.WriteLine("Остаток товара " + product1.name + ": " + product1.quantity);
        Console.WriteLine("Остаток товара " + product2.name + ": " + product2.quantity);
    }
}


//Задачка 3: гонка машинок
using System;
using System.Collections.Generic;

public class Car
{
    public string model;
    public int speed;
    public double distance;

    public void Drive(int hours)
    {
        distance += speed * hours;
    }
}

public class Race
{
    public static void Main(string[] args)
    {
        Car car1 = new Car { model = "Машина 1", speed = 120, distance = 0 };
        Car car2 = new Car { model = "Машина 2", speed = 150, distance = 0 };
        Car car3 = new Car { model = "Машина 3", speed = 100, distance = 0 };

        List<Car> cars = new List<Car>();
        cars.Add(car1);
        cars.Add(car2);
        cars.Add(car3);

        int raceDuration = 5;
        foreach (Car car in cars)
        {
            car.Drive(raceDuration);
        }

        Console.WriteLine("Результаты гонки:");
        Car winner = car1;
        foreach (Car car in cars)
        {
            Console.WriteLine(car.model + ": " + car.distance);
            if (car.distance > winner.distance)
            {
                winner = car;
            }
        }

        Console.WriteLine("Победитель: " + winner.model);
    }
}
