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
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Buy_apartment = new HashSet<Buy_apartment>();
            this.Buy_home = new HashSet<Buy_home>();
            this.Buy_premises = new HashSet<Buy_premises>();
            this.Rent_apartment = new HashSet<Rent_apartment>();
            this.Rent_home = new HashSet<Rent_home>();
            this.Rent_promises = new HashSet<Rent_promises>();
        }
    
        public int ID { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string OName { get; set; }
        public double Passport_number { get; set; }
        public System.DateTime Date_of_birth { get; set; }
        public int Positions_ { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string bitrhday
        {
            get
            {
                string s = $"{Date_of_birth.Day}-{Date_of_birth.Month}-{Date_of_birth.Year}";
                return s;
            }
        }
        public string pasport
        {
            get
            {
                string pass = $"{Passport_number}";
                string passlast = "";
                for (int i = 4; i < 9; i++)
                {
                    passlast += pass[i];

                }
                string s = $"{pass[0]}{pass[1]} {pass[2]}{pass[3]} {passlast}";
                return s;
            }
        }
        public string combococks1
        {
            get
            {
                string s = $"{LName} {FName} {OName}";
                return s;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buy_apartment> Buy_apartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buy_home> Buy_home { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buy_premises> Buy_premises { get; set; }
        public virtual Positions Positions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent_apartment> Rent_apartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent_home> Rent_home { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent_promises> Rent_promises { get; set; }
    }
}
