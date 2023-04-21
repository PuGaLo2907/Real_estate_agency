//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Real_estate_agency
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Rent_apartment
    {
        public int ID { get; set; }
        public int Apartment { get; set; }
        public int Tenant { get; set; }
        public System.DateTime Deal_date { get; set; }
        public System.DateTime Arrival_date { get; set; }
        public System.DateTime Date_of_departure { get; set; }
        public Nullable<int> Deadline { get; set; }
        public int Staff { get; set; }
        public int Owner { get; set; }
        public string Data_v
        {
            get
            {
                string _data_v = $"{Deal_date.Day}.{Deal_date.Month}.{Deal_date.Year}";
                return _data_v;
            }
        }
        public string Data_a
        {
            get
            {
                string _data_v = $"{Arrival_date.Day}.{Arrival_date.Month}.{Arrival_date.Year}";
                return _data_v;
            }
        }
        public string Data_d
        {
            get
            {
                string _data_v = $"{Date_of_departure.Day}.{Date_of_departure.Month}.{Date_of_departure.Year}";
                return _data_v;
            }
        }

        public virtual Apartment Apartment1 { get; set; }
        public virtual Client Client { get; set; }
        public virtual Client Client1 { get; set; }
        public virtual Staff Staff1 { get; set; }
        [NotMapped]
        public Client BuyAppartment
        {
            get
            {
                return DataWorker.GetClient(Owner);
            }
        }
        public Client BuyAppartment1
        {
            get
            {
                return DataWorker.GetClient(Tenant);
            }
        }
        public Apartment Adres
        {
            get
            {
                return DataWorker.GetKvatir(Apartment);
            }
        }
    }
}
