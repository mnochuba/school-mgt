// See https://aka.ms/new-console-template for more information
using SchoolManagement.DB;

Console.WriteLine("Hello, World!");

var helper = new FluentNHibernateHelper();
helper.OpenSession();
