//Завдання 4

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application,
//потрібно створити клас DocumentWorker. У тілі класу створіть три методи OpenDocument(),
//EditDocument(), SaveDocument().У тіло кожного з методів додайте виведення на екран відповідних
//рядків: "Документ відкритий", "Редагування документа у версії Про", "Збереження документа у версії Про".

//Створіть похідний клас ProDocumentWorker.
//Перевизначте відповідні методи, при перевизначенні методів виводьте наступні рядки:
//"Документ відредаговано", "Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт".

//Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker.
//Перевизначте відповідний спосіб. При викликі даного методу необхідно виводити на екран
//"Документ збережений у новому форматі".

//У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу pro і exp.
//Якщо користувач не вводить ключ, він може користуватися лише безкоштовною версією (створюється екземпляр базового класу),
//якщо користувач ввів номери ключа доступу pro і exp, то повинен створити екземпляр відповідної версії класу,
//наведений до базового - DocumentWorker.

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string proKey = "PRO123456";
            string expKey = "EXP123456";
            Console.Write("If you have key to accept to pro or exp versions, please enter -> ");
            string userKey = Console.ReadLine().ToUpper();
            if (userKey == proKey)
            {
                ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                proDocumentWorker.OpenDocument();
                proDocumentWorker.EditDocument();
                proDocumentWorker.SaveDocument();
            }
            else if (expKey == userKey)
            {
                ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                expertDocumentWorker.OpenDocument();
                expertDocumentWorker.EditDocument();
                expertDocumentWorker.SaveDocument();
            }
            else
            {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();
            }

        }
    }
}