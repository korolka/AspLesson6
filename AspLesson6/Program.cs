//�������
//�������� ����� � �������� ��� �������������� �������� � ������ CalcService.
//�������� ����������, ������� ����� ��������� ������ �������� ��� �������������� ��������. 
//��������� DI ����� �������, ����� ���������� �������������� �������� CalcService.

//������� 1
//�������� ����������, ������� ������� ������������ ������ ��������� ��������.
//�������� ��� �������, ���� ������� ������������� ������ �������� ���� ������,
//������, ������� ������������� ������ � �������� �������.
//���������� ����� DI �������� ����������� ������ �� ��������,
//������������ ������ ������� �� �������� DI.
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