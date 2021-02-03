using System;

namespace dz02._02._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id = Convert.ToInt32(Console.ReadLine());
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            string MiddleName = Console.ReadLine();
            string  FavoritSport = Console.ReadLine();
            Participants one = new Participants( Id, FirstName,  LastName,  MiddleName,   FavoritSport);
            one.Participant();
        }
    }
    class Participants
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string MiddleName;
        public string FavoritSport;
       
        public Participants (int Id, string FirstName, string LastName, string MiddleName, string FavoritSport )
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.FavoritSport = FavoritSport;

        }
        public void Participant()
        {
            Console.WriteLine($"Id: {Id},\n FirstName:{FirstName},\n LastName:{LastName},\nMiddleName: {MiddleName},\n FavoritSport:{FavoritSport} ");
        }
    }
}
