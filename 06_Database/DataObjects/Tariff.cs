namespace _06_Database.DataObjects
{
    public class Tariff
    {
        public string Name { get; set; }
        public decimal MonthlyCost { get; set; }

        public override string ToString()
        {
            return $"{Name}, стоит {MonthlyCost} руб/мес";
        }
    }
}