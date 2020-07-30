namespace RecordManagementSystemInAxaNSamar.Model
{
    public class ClientPlan
    {
        public int ClientPlanId { get; internal set; }
        public string PolicyNo { get; set; }
        public string SumInsured { get; set; }
        public string ModeOfPayment { get; set; }
        public int DueOfPayment { get; set; }

        public int PlanId { get; set; }
        public Plan Plan { get; set; }


        public int ClientId { get; internal set; }
        public Client Client { get; internal set; }
    }
}