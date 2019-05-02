using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Country.Services;
using Country.DataAccess;

namespace ExamCountryCity
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Add
            //using (CountryRepository countryRepository = new CountryRepository())
            //{
            //    Console.WriteLine("Сколько стран добавить?");
            //    int countCity = int.Parse(Console.ReadLine());
            //    for (int i = 0; i < countCity; i++)
            //    {
            //        Console.WriteLine("Введите названия стран?");
            //        string nameCountry = Console.ReadLine();
            //        Countries country = new Countries
            //        {
            //            Name = nameCountry
            //        };
            //        countryRepository.AddCountry(country);
            //    }
            //}
            //using (CityRepository streetRepository = new CityRepository())
            //{
            //    Console.WriteLine("Сколько городов добавить?");
            //    int countCity = int.Parse(Console.ReadLine());
            //    for (int i = 0; i < countCity; i++)
            //    {
            //        Console.WriteLine("Введите названия города?");
            //        string nameCity = Console.ReadLine();
            //        Console.WriteLine("Введите Id страны?");
            //        int idCountry = int.Parse(Console.ReadLine());
            //        var getCountryId = streetRepository.GetCountryById(idCountry);
            //        while (getCountryId == null)
            //        {
            //            Console.WriteLine("Такого Id нет, Введите заново!");
            //            Console.ReadLine();
            //            idCountry = int.Parse(Console.ReadLine());
            //        }
            //        City city = new City
            //        {
            //            Name = nameCity,
            //            CountryId = idCountry
            //        };
            //        streetRepository.AddCity(city);
            //    }
            //}
            //using (StreetRepository streetRepository = new StreetRepository())
            //{
            //    Console.WriteLine("Сколько улиц добавить?");
            //    int countStreet = int.Parse(Console.ReadLine());
            //    for (int i=0; i<countStreet; i++)
            //    {
            //        Console.WriteLine("Введите названия улиц?");
            //        string nameStreet = Console.ReadLine();
            //        Console.WriteLine("Введите Id города?");
            //        int idCity = int.Parse(Console.ReadLine());
            //        var getCityId = streetRepository.GetCityById(idCity);
            //        while (getCityId == null)
            //        {
            //            Console.WriteLine("Такого Id нет, Введите заново!");
            //            Console.ReadLine();
            //            idCity = int.Parse(Console.ReadLine());
            //        }
            //        Street street = new Street
            //        {
            //            Name =  nameStreet,
            //            CityId = idCity
            //        };
            //        streetRepository.AddStreet(street);
            //    }
            //}
            #endregion

            #region Change
            //using (CountryRepository changeCountryRepository = new CountryRepository())
            //{
            //    Console.WriteLine("Введите Id страны которую хотите изменить?");
            //    int idCountry = int.Parse(Console.ReadLine());
            //    var getId = changeCountryRepository.GetCountryById(idCountry);
            //    while (getId == null)
            //    {
            //        Console.WriteLine("Такого Id нет, Введите заново!");
            //        Console.ReadLine();
            //        idCountry = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("Введите название страны?");
            //    string nameCountry = Console.ReadLine();
            //    changeCountryRepository.ChangeCountry(nameCountry, idCountry);
            //}
            //using (CityRepository changeCityRepository = new CityRepository())
            //{
            //    Console.WriteLine("Введите Id города которую хотите изменить?");
            //        int idCity = int.Parse(Console.ReadLine());
            //        var getId = changeCityRepository.GetCityById(idCity);
            //        while (getId == null)
            //        {
            //            Console.WriteLine("Такого Id нет, Введите заново!");
            //            Console.ReadLine();
            //            idCity = int.Parse(Console.ReadLine());
            //        }

            //        Console.WriteLine("Введите Id страны?");
            //        int idCountry = int.Parse(Console.ReadLine());
            //        var getCountryId = changeCityRepository.GetCountryById(idCountry);
            //        while (getCountryId == null)
            //        {
            //            Console.WriteLine("Такого Id нет, Введите заново!");
            //            Console.ReadLine();
            //            idCountry = int.Parse(Console.ReadLine());
            //        }
            //        Console.WriteLine("Введите название города?");
            //        string nameCity = Console.ReadLine();
            //    changeCityRepository.ChangeCity(nameCity, idCity);
            //}
            //using (StreetRepository changeStreetRepository = new StreetRepository())
            //{
            //    Console.WriteLine("Введите Id улицы которую хотите изменить?");
            //    int idCity = int.Parse(Console.ReadLine());
            //    var getId = changeStreetRepository.GetCityById(idCity);
            //    while (getId == null)
            //    {
            //        Console.WriteLine("Такого Id нет, Введите заново!");
            //        Console.ReadLine();
            //        idCity = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("Введите Id города?");
            //    int idStreet = int.Parse(Console.ReadLine());
            //    var getCityId = changeStreetRepository.GetCityById(idStreet);
            //    while (getCityId == null)
            //    {
            //        Console.WriteLine("Такого Id нет, Введите заново!");
            //        Console.ReadLine();
            //        idStreet = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("Введите название улицы?");
            //    string nameStreet = Console.ReadLine();
            //    changeStreetRepository.ChangeStreet(nameStreet, idCity);
            //}
            #endregion

            #region Delete
            using (StreetRepository deleteStreetRepository = new StreetRepository())
            {
                Console.WriteLine("Введите Id улицы которую хотите удалить?");
                int idCity = int.Parse(Console.ReadLine());
                var getId = deleteStreetRepository.GetCityById(idCity);
                while (getId == null)
                {
                    Console.WriteLine("Такого Id нет, Введите заново!");
                    Console.ReadLine();
                    idCity = int.Parse(Console.ReadLine());
                }
                deleteStreetRepository.DeleteStreet(idCity);
            }
            using (CityRepository deleteCityRepository = new CityRepository())
            {
                Console.WriteLine("Введите Id города которую хотите удалить?");
                int idCity = int.Parse(Console.ReadLine());
                var getId = deleteCityRepository.GetCityById(idCity);
                while (getId == null)
                {
                    Console.WriteLine("Такого Id нет, Введите заново!");
                    Console.ReadLine();
                    idCity = int.Parse(Console.ReadLine());
                }
                deleteCityRepository.DeleteCity(idCity);
            }
            using (CountryRepository deleteCountryRepository = new CountryRepository())
            {
                Console.WriteLine("Введите Id страны которую хотите удалить?");
                int idCountry = int.Parse(Console.ReadLine());
                var getId = deleteCountryRepository.GetCountryById(idCountry);
                while (getId == null)
                {
                    Console.WriteLine("Такого Id нет, Введите заново!");
                    Console.ReadLine();
                    idCountry = int.Parse(Console.ReadLine());
                }

                deleteCountryRepository.DeleteCountry(idCountry);
            }
            
            
            #endregion
        }
    }
}
