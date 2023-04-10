namespace LinqCheatSheet
{
    public enum CaseType
    {
        Commercial,
        ProBono
    }
    public class Case
    {
        public Client Client { get; set; } = default!;
        public Lawyer Lawyer { get; set; } = default!;
        public string Title { get; set; } = default!;
        public CaseType CaseType { get; set; } = default!;
        public decimal AmountDispute { get; set; } = default!;
    }
}