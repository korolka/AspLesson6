//Задание
//Создайте класс с методами для арифметических операций с именем CalcService.
//Создайте контроллер, который будет содержать методы действия для арифметических операций. 
//Настройте DI таким образом, чтобы контроллер воспользовался сервисом CalcService.

//Задание 1
//Создайте контроллер, который выводит пользователю список строковых значений.
//Сделайте два сервиса, один который предоставляет массив названий дней недели,
//второй, который предоставляет массив с названых месяцев.
//Реализуйте через DI передачу контроллеру одного из сервисов,
//используемый сервис зависит от настроек DI.
using AspLesson6.Services;

namespace AspLesson6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<ICalcServices, CalcServices>();
            builder.Services.AddSingleton<IDayOrMonth, Month>();
            var app = builder.Build();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=ListOfDaysOrMonth}/{action=index}");
            });

            app.Run();
        }
    }
}